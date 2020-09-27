using GenerateValuesApi;
using GenerateValuesApi.Controllers;
using GenerateValuesApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class TestController
    {
        [TestMethod]
        public void TestGetInsert()
        {

            Name name = new Name { ColumnTitle = "Name", type = NameType.FirstNameFemale };
            Telephone phone = new Telephone { ColumnTitle = "Phone", FormatSpecifier = "7951xxxxxxxx" };
            Email email = new Email { ColumnTitle = "email" };
            Date date = new Date { ColumnTitle = "date", EndDate = DateTime.Now };
            List<DataType> dataTypes = new List<DataType> { name, phone, email, date };
            InsertController controller = new InsertController(new RandomItemGenerator());
            var values = controller.GetInsert(dataTypes, "TestTable", 100, 10);
            foreach(var value in values)
            {
                Console.WriteLine(value);
            }
            Assert.IsTrue(values.Count() == 10);
        }
    }
}
