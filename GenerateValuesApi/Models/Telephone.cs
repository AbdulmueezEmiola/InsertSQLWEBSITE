using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public class Telephone : DataType
    {
        public string ColumnTitle { get; set; }
        public string FormatSpecifier { get; set; }

        public object RandomValue(IRandomItemGenerator randomItemGenerator)
        {
            return randomItemGenerator.RandomPhoneNumber(FormatSpecifier);
        }
    }
}
