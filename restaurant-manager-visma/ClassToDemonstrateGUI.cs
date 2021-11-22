using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager_tests
{
    class ClassToDemonstrateGUI
    {
        private string NameTest { get; set; }
        public ClassToDemonstrateGUI(string test)
        {
            NameTest = test;
        }

        public string ReturnTest()
        {
            return NameTest;
        }
    }
}
