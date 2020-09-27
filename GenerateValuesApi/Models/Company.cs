using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public class Company : DataType
    {
        public string ColumnTitle { get; set; }

        public object RandomValue(IRandomItemGenerator randomItemGenerator)
        {
            return randomItemGenerator.RandomCompany();
        }
    }
}
