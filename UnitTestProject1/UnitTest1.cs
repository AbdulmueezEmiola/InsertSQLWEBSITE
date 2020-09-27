using GenerateValuesApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForRandomCity()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            string city = randomItemGenerator.RandomCity();
            Console.WriteLine(city);
            Assert.IsNotNull(city);
        }
        [TestMethod]
        public void TestForRandomCountry()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            string country = randomItemGenerator.RandomCountry();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomSurname()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            string country = randomItemGenerator.RandomSurname();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomFirstNameMale()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            string country = randomItemGenerator.RandomFirstNameMale();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomFirstNameFemale()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            string country = randomItemGenerator.RandomFirstNameFemale();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomFullNameMale()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            string country = randomItemGenerator.RandomFullName(Gender.MALE);
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomFullNameFemale()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            string country = randomItemGenerator.RandomFullName(Gender.FEMALE);
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomCompany()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            string country = randomItemGenerator.RandomCompany();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomWords()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            string country = randomItemGenerator.RandomWords(3);
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomWordsWithException()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            Assert.ThrowsException<ArgumentException>(() => randomItemGenerator.RandomWords(0));
        }
        [TestMethod]
        public void TestForRandomCreditCard()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            long country = randomItemGenerator.RandomCreditCard(CreditCardEnum.MASTERCARD);
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomCreditCardNull()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            long country = randomItemGenerator.RandomCreditCard();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomCVV()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            int country = randomItemGenerator.RandomCVV();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomDateWithStartAndEnd()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomDate(endDate:DateTime.Now);
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomDateWithOnlyStart()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomDate(new DateTime(1999, 11, 12));
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomDate()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomDate();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomEmail()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomEmail();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomInitials()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomInitials();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomPassportNumber()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomPassportNumber("ANNNAA");
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }

        [TestMethod]
        public void TestForRandomPhoneNumber()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomPhoneNumber();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomPinCode()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomPinCode();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomStreetAddress()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomStreetAddress();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
        [TestMethod]
        public void TestForRandomZipCode()
        {
            RandomItemGenerator randomItemGenerator = new RandomItemGenerator();
            var country = randomItemGenerator.RandomZipCode();
            Console.WriteLine(country);
            Assert.IsNotNull(country);
        }
    }
}
