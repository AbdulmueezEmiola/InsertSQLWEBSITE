using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public interface DataType
    {
        string ColumnTitle { get; set; }
        object RandomValue(IRandomItemGenerator randomItemGenerator);
    }
}
