using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GenerateValuesApi.Controllers
{
    public class DocumentationController : Controller
    {
        public IActionResult Index()
        {
            List<string> dataTypes = new List<string> { "Names", "Phone","Email","Passport Number",
                "Company","Street Address","City","Country","Postal/Zip","Fixed No of words",
                "Random No of words","Date","Credit Card","Pin","CVV"};
            ViewData["DataTypes"] = dataTypes;
            return View();
        }
    }
}