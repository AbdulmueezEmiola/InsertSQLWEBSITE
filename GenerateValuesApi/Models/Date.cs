using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public class Date : DataType
    {
        public string ColumnTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public object RandomValue(IRandomItemGenerator randomItemGenerator)
        {            
            return randomItemGenerator.RandomDate(StartDate, EndDate);            
        }
    }
}
