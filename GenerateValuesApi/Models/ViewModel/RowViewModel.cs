using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models.ViewModel
{
    public class RowViewModel
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public string MinValue { get; set; }
        public string MaxValue { get; set; }
        public string Value { get; set; }
    }
}
