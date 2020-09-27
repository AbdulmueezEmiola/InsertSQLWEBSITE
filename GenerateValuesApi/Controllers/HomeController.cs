using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerateValuesApi.Models;
using GenerateValuesApi.Models.NewFolder;
using GenerateValuesApi.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace GenerateValuesApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRandomItemGenerator randomItemGenerator;

        public IActionResult Index()
        {
            return View();
        }
        public HomeController(IRandomItemGenerator randomItemGenerator)
        {
            this.randomItemGenerator = randomItemGenerator;
        } 
        [HttpPost]
        public IActionResult ProcessRequest(DataTypeViewModel dataTypeViewModel)
        {
            if (ModelState.IsValid)
            {
                List<DataType> dataTypes = ProcessDataTypeViewModel.ConvertDataType(dataTypeViewModel).ToList();
                var values = GetInsert(dataTypes, dataTypeViewModel.TableName, dataTypeViewModel.RowNumbers, dataTypeViewModel.BatchSize);
                return View("ProcessRequest", values);
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult SelectDataType(int value)
        {
            return PartialView("SelectDataTypePartialView",value);
        }
        public IEnumerable<string> GetInsert(List<DataType> dataTypes, string tableName = "Table", int count=10, int batch=2)
        {
            for (int i = 0; i < count / batch; i++)
            {
                yield return GenerateSingleInsert.Insert(dataTypes, randomItemGenerator, tableName, batch);
            }
        }
    }
}