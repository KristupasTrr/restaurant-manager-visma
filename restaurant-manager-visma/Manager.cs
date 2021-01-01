using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager_visma
{
    class Manager
    {
        private ProductStock productStock { get; set; }
        private Menu menu { get; set; }
        private Orders orders { get; set; }

        // for product stock temp variable creation
        private string productStockFile { get; set; }

        public Manager(string productStockFile, string menuFile, string ordersFile)
        {
            productStock = new ProductStock(productStockFile);
            menu = new Menu(menuFile);
            orders = new Orders(ordersFile);
            this.productStockFile = productStockFile;
        }

        public int getInputNumber()
        {
            int action;
            while (!int.TryParse(Console.ReadLine(), out action))
                Console.WriteLine("Input must be number!");
            return action;
        }

        public void mainPage()
        {
            Console.Clear();
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Restaurant stock");
            Console.WriteLine("2. Restaurant menu");
            Console.WriteLine("3. Customer orders");
            Console.WriteLine("9. Exit");
            Console.Write("Action: ");

            int action = getInputNumber();

            switch (action)
            {
                case 1:
                    productStockPage();
                    break;
                case 2:
                    menuPage();
                    break;
                case 3:
                    orderPage();
                    break;
                case 9:
                    break;
                default:
                    mainPage();
                    break;
            }
        }

        public void productStockPage()
        {
            Console.Clear();
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Create product");
            Console.WriteLine("2. Update stock");
            Console.WriteLine("3. Remove existing stock");
            Console.WriteLine("4. Print stock");
            Console.WriteLine("5. Back");
            Console.WriteLine("9. Exit");
            Console.Write("Action: ");

            int action = getInputNumber();

            switch (action)
            {
                case 1:
                    createProductPage();
                    break;
                case 2:
                    updateStockPage();
                    break;
                case 3:
                    removeStockPage();
                    break;
                case 4:
                    printStockPage();
                    break;
                case 5:
                    mainPage();
                    break;
                case 9:
                    break;
                default:
                    productStockPage();
                    break;
            }
        }


        public void createProductPage()
        {
            Console.Clear();

            try
            {
                int id = this.productStock.newID();

                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Portion count: ");
                var portionCount = getInputNumber();

                Console.Write("Unit: ");
                var unit = Console.ReadLine();

                Console.Write("Portion size: ");
                var portionSize = Convert.ToDouble(Console.ReadLine());

                var product = new Product(id, name, portionCount, unit, portionSize);

                if (portionCount >= 0 && portionSize >= 0)
                {
                    this.productStock.addToStock(product);
                    this.productStock.updateDataFile();
                    Console.WriteLine("Product has been added successfully");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Portion count and size must be >= 0");
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                Console.WriteLine("Error while add product to stock!");
                Console.ReadKey();
            }

            productStockPage();
        }

        public void updateStockPage()
        {
            Console.Clear();
            this.productStock.printStock();

            try
            {
                Console.Write("\nID: ");
                int id = getInputNumber();

                Console.Write("Stock: ");
                int stock = getInputNumber();

                if (this.productStock.isAvailable(id) && stock >= 0)
                {
                    this.productStock.updateStock(id, stock);
                    this.productStock.updateDataFile();
                    Console.WriteLine("Stock has been updated successfully");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Check ID or stock");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Error while updating stock!");
                Console.ReadKey();
            }
            productStockPage();
        }

        public void removeStockPage()
        {
            Console.Clear();
            this.productStock.printStock();

            try
            {
                Console.Write("\nID: ");
                int id = getInputNumber();

                if (this.productStock.isAvailable(id))
                {
                    this.productStock.removeStock(id);
                    this.productStock.updateDataFile();
                    Console.WriteLine("Stock has been deleted successfully");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Check ID!");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Error while deleting stock!");
                Console.ReadKey();
            }
            productStockPage();
        }

        public void printStockPage()
        {
            Console.Clear();
            this.productStock.printStock();

            //Console.WriteLine("Error while deleting stock!");
            Console.ReadKey();
            productStockPage();
        }

        public void menuPage()
        {
            Console.Clear();
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Create menu item");
            Console.WriteLine("2. Update menu item");
            Console.WriteLine("3. Remove menu item");
            Console.WriteLine("4. Print menu");
            Console.WriteLine("5. Back");
            Console.WriteLine("9. Exit");
            Console.Write("Action: ");

            int action = getInputNumber();

            switch (action)
            {
                case 1:
                    createMenuItemPage();
                    break;
                case 2:
                    updateMenuPage();
                    break;
                case 3:
                    removeMenuItemPage();
                    break;
                case 4:
                    printMenuPage();
                    break;
                case 5:
                    mainPage();
                    break;
                case 9:
                    break;
                default:
                    menuPage();
                    break;
            }
        }

        public void createMenuItemPage()
        {
            Console.Clear();

            Console.WriteLine("Available products");
            this.productStock.printStock();
            Console.WriteLine("\n");

            try
            {
                int id = this.menu.newID();

                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Products: ");
                var productIdsString = Console.ReadLine();
                var productIds = productIdsString.Split(' ').Select(Int32.Parse).ToList();

                var menuItem = new MenuItem(id, name, productIds);

                // check if all given products are available in the stock list
                foreach (var productId in productIds)
                {
                    if (this.productStock.isAvailable(productId) == false)
                    {
                        Console.WriteLine("Products are not available!");
                        Console.ReadKey();
                        menuPage();
                    }
                }

                // given product count must be > 0
                if (productIds.Count > 0)
                {
                    this.menu.addMenuItem(menuItem);
                    this.menu.updateDataFile();
                    Console.WriteLine("Menu item has been added successfully");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Product count must be > 0");
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Error while adding item to menu!");
                Console.ReadKey();
            }
            menuPage();
        }

        public void updateMenuPage()
        {
            Console.Clear();
            this.menu.printMenu();

            try
            {
                Console.Write("\nID: ");
                int id = getInputNumber();

                Console.Write("Stock: ");
                int stock = getInputNumber();

                if (this.productStock.isAvailable(id) && stock >= 0)
                {
                    this.productStock.updateStock(id, stock);
                    this.menu.updateDataFile();
                    Console.WriteLine("Stock has been updated successfully");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Check ID or stock");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Error while updating stock!");
                Console.ReadKey();
            }
            menuPage();
        }
        public void removeMenuItemPage()
        {
            Console.Clear();
            this.menu.printMenu();

            try
            {
                Console.Write("\nID: ");
                int id = getInputNumber();

                if (this.menu.isAvailable(id))
                {
                    this.menu.removeMenuItem(id);
                    this.menu.updateDataFile();
                    Console.WriteLine("Menu item has been deleted successfully");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Check ID!");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Error while deleting menu item!");
                Console.ReadKey();
            }
            menuPage();
        }

        public void printMenuPage()
        {
            Console.Clear();

            this.menu.printMenu();

            Console.ReadKey();
            menuPage();
        }

        public void orderPage()
        {
            Console.Clear();
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Create order");
            Console.WriteLine("2. Check orders");
            Console.WriteLine("3. Back");
            Console.WriteLine("9. Exit");
            Console.Write("Action: ");

            int action = getInputNumber();

            switch (action)
            {
                case 1:
                    createOrderPage();
                    break;
                case 2:
                    printOrdersPage();
                    break;
                case 3:
                    mainPage();
                    break;
                case 9:
                    return;
                default:
                    orderPage();
                    break;
            }
        }

        public void createOrderPage()
        {
            Console.Clear();
            Console.WriteLine("Menu items");
            this.menu.printMenu();
            Console.WriteLine("\n");

            try
            {
                int id = this.orders.newID();

                Console.Write("Menu items: ");
                var menuIdsString = Console.ReadLine();
                var menuIds = menuIdsString.Split(' ').Select(Int32.Parse).ToList();

                // create temporary variable for productStock
                // deduct each product
                // if product stock is not below 0 
                // this.productStock = tempProductStock
                var tempProductStock = new ProductStock(this.productStockFile);
                // check if all given menu items are available in the menu
                foreach (var menuId in menuIds)
                {
                    if (this.menu.isAvailable(menuId) == false)
                    {
                        Console.WriteLine("Menu items are not available!");
                        Console.ReadKey();
                        orderPage();
                    }
                    else
                    {
                        var menuItem = this.menu.getMenuListItem(menuId);

                        foreach (var productId in menuItem.products)
                        {
                            tempProductStock.deductStock(productId);
                            if (tempProductStock.getStock(productId) < 0)
                            {
                                Console.WriteLine("Products are not available! Order cancelled");
                                Console.ReadKey();
                                orderPage();
                            }
                        }
                    }
                }



                // given product count must be > 0
                if (menuIds.Count > 0)
                {
                    // replace original productStock list with list with deducted values
                    this.productStock = tempProductStock;
                    this.productStock.updateDataFile();

                    var orderItem = new OrderItem(id, DateTime.Now, menuIds);

                    this.orders.createOrder(orderItem);
                    this.orders.updateDataFile();
                    Console.WriteLine("Order has been created successfully");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Menu item count must be > 0");
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                Console.WriteLine("Error while adding item to menu!");
                Console.ReadKey();
            }

            orderPage();
        }

        public void printOrdersPage()
        {
            Console.Clear();

            this.orders.printOrders();

            Console.ReadKey();
            orderPage();
        }
    }
}
