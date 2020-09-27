using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public class AlphaNumeric : DataType
    {
        public string ColumnTitle { get; set; }
        public string Format { get; set; }
        public object RandomValue(IRandomItemGenerator randomItemGenerator)
        {
            return randomItemGenerator.RandomAlphaNumeric(Format);
        }
    }
}
