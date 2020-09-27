using GenerateValuesApi;
using GenerateValuesApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class TestingModels
    {
        [TestMethod]
        public void TestName()
        {
            Name name = new Name { ColumnTitle = "Name", type = NameType.FirstNameFemale};
            string value = name.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value,typeof(string));
        }
        [TestMethod]
        public void TestPhoneNumber()
        {
            Telephone phone = new Telephone { ColumnTitle = "Phone" ,FormatSpecifier="7951xxxxxxxx"};
            string value = phone.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestEmail()
        {
            Email email = new Email { ColumnTitle = "email" };
            string value = email.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestDate()
        {
            Date date = new Date { ColumnTitle = "date", EndDate = DateTime.Now };
            string value = date.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestCompany()
        {
            Company company = new Company { ColumnTitle = "company" };
            string value = company.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestPassportNumbet()
        {
            Passport passport = new Passport { ColumnTitle = "passport" };
            string value = passport.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestStreetAddress()
        {
            StreetAddress address = new StreetAddress();
            string value = address.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestCity()
        {
            City city = new City();
            string value = city.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestCountry()
        {
            Country country = new Country();
            string value = country.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestZipCode()
        {
            ZipCode code = new ZipCode { FormatSpecifier = "ANNNNAA" };
            string value = code.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestCreditCard()
        {
            CreditCard card = new CreditCard { type = CreditCardEnum.MASTERCARD };
            string value = card.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestPinCode()
        {
            PinCode code = new PinCode();
            string value = code.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestCVV()
        {
            CVV cvv = new CVV();
            string value = cvv.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
        [TestMethod]
        public void TestRandomWord()
        {
            Words words = new Words { length = 10 };
            string value = words.RandomValue(new RandomItemGenerator()).ToString();
            Console.WriteLine(value);
            Assert.IsInstanceOfType(value, typeof(string));
        }
    }
}
