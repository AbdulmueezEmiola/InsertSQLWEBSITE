using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public class Numbers : DataType
    {
        public string ColumnTitle { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public object RandomValue(IRandomItemGenerator randomItemGenerator)
        {
            return randomItemGenerator.RandomNumberRange(MinValue, MaxValue);
        }
    }
}
