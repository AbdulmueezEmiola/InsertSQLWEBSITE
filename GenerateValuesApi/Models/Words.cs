using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public class Words : DataType
    {
        public string ColumnTitle { get; set; }
        public int? length { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }

        public object RandomValue(IRandomItemGenerator randomItemGenerator)
        {
            if(length != null)
            {
                return randomItemGenerator.RandomWords((int)length);
            }else if(MinLength != null && MaxLength != null)
            {
                return randomItemGenerator.RandomWords((int)MinLength, (int)MaxLength);
            }
            else
            {
                return randomItemGenerator.RandomWords(1);
            }
        }
    }
}
