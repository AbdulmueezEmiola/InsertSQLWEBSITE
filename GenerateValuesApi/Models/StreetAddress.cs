using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public class StreetAddress:DataType
    {
        public string ColumnTitle { get; set; }

        public object RandomValue(IRandomItemGenerator randomItemGenerator)
        {
            return randomItemGenerator.RandomStreetAddress();
        }
    }
}
