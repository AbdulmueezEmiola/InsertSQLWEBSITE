using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public class CreditCard : DataType
    {
        public string ColumnTitle { get; set; }
        public CreditCardEnum type { get; set; }

        public object RandomValue(IRandomItemGenerator randomItemGenerator)
        {
            return randomItemGenerator.RandomCreditCard(type);
        }
    }
}
