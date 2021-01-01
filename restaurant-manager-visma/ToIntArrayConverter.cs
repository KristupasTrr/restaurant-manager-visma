using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Collections.Generic;
using System.Linq;

namespace restaurant_manager_visma
{
    public class ToIntArrayConverter : TypeConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            if (text == "") return new List<int>();
            string[] allElements = text.Split(' ');
            int[] elementsAsInteger = allElements.Select(s => int.Parse(s)).ToArray();
            return new List<int>(elementsAsInteger);
        }

        public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            return string.Join(" ", ((List<int>)value).ToArray());
        }
    }
}
