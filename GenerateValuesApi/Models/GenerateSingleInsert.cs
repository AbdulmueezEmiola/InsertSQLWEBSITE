using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public static class GenerateSingleInsert
    {
        public static string Insert(List<DataType> dataTypes, IRandomItemGenerator randomItemGenerator, string tableName, int batch)
        {
            var values = GetValuePairs(dataTypes, randomItemGenerator,batch);
            var newKeyFormat = from value in values.Keys
                               select "[" + value + "]";
            String data = GenerateData(values.Values, batch);
            return $"INSERT INTO {tableName}({String.Join(',', newKeyFormat)}) VALUES {data} ;";
        }
        private static string GenerateData(IEnumerable<List<string>> values, int batch)
        {
            StringBuilder Data = new StringBuilder();
            for (int i = 0; i < batch; i++)
            {
                var elementString = "(";
                var dataPerElement = from value in values
                                     select "'" + value.ElementAt(i).ToString() + "'";

                elementString += String.Join(",", dataPerElement) + "),";
                Data.Append(elementString);
            }
            return Data.Remove(Data.Length - 1,1).ToString();
        }
        private static Dictionary<string,List<string>> GetValuePairs(List<DataType> dataTypes, IRandomItemGenerator randomItemGenerator, int batch)
        {
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string,List<string>>();
            foreach (DataType type in dataTypes)
            {
                List<string> list = new List<string>();
                for(int i = 0; i < batch; i++)
                {
                    list.Add(type.RandomValue(randomItemGenerator).ToString());
                }
                keyValuePairs.Add(type.ColumnTitle, list);
            }
            return keyValuePairs;
        }

    }
}
