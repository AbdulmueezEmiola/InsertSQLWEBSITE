using GenerateValuesApi.Models.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace GenerateValuesApi.Extension
{
    public class ListFilled: ValidationAttribute
    {
        public ListFilled(): base("List must have more than one element")
        {

        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(this.ErrorMessageString, name);
        }

        public override bool IsValid(object value)
        {
            IList myList = value as List<RowViewModel>;            
            foreach(RowViewModel model in myList)
            {
                if(model.ColumnName != null && model.DataType != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
