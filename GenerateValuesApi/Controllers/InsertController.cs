using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerateValuesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenerateValuesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        private IRandomItemGenerator randomItemGenerator;
        public InsertController(IRandomItemGenerator randomItemGenerator)
        {
            this.randomItemGenerator = randomItemGenerator;
        }
        [HttpGet]
        public IEnumerable<string> GetInsert(List<DataType> dataTypes,string tableName, int count, int batch)
        {
            for(int i = 0; i < count / batch; i++)
            {
                yield return GenerateSingleInsert.Insert(dataTypes, randomItemGenerator, tableName, batch);
            }
        }
    }
}