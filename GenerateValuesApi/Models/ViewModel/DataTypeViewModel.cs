using GenerateValuesApi.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models.ViewModel
{
    public class DataTypeViewModel
    {
        [Required(ErrorMessage = "Enter the table name")]
        public string TableName { get; set; }
        [Required(ErrorMessage ="Choose your database type")]
        public string DatabaseType { get; set; }
        [Required(ErrorMessage ="Choose your Row Numbers")]
        [Range(1,int.MaxValue,ErrorMessage = "The minimum supported value is 1")]
        //[MinLength(0,ErrorMessage ="The least number is 0")]
        public int RowNumbers { get; set; }
        //[MinLength(0, ErrorMessage = "The least number is 0")]
        [Required(ErrorMessage = "Choose your Batch size")]
        [Range(1, int.MaxValue,ErrorMessage ="The minimum supported value is 1")]

        public int BatchSize { get; set; }
        [Required]
        [ListFilled()]
        public List<RowViewModel> Rows { get; set; }
    }
}
