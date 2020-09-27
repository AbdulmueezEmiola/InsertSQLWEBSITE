using GenerateValuesApi;
using GenerateValuesApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class TestingGenerateSingleInsert
    {
        [TestMethod]
        public void TestInsert()
        {
            Name name = new Name { ColumnTitle = "Name", type = NameType.FirstNameFemale };
            Telephone phone = new Telephone { ColumnTitle = "Phone", FormatSpecifier = "7951xxxxxxxx" };
            Email email = new Email { ColumnTitle = "email" };
            Date date = new Date { ColumnTitle = "date", EndDate = DateTime.Now };
            List<DataType> dataTypes =new List<DataType> { name, phone, email, date };
            string value = GenerateSingleInsert.Insert(dataTypes, new RandomItemGenerator(), "TableTest",3);
            Console.WriteLine(value);
            Assert.IsNotNull(value);
        }
    }
}
