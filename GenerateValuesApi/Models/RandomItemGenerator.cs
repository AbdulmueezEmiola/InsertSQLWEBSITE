using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi
{
    //Implement support for lower case letters
    public class RandomItemGenerator : IRandomItemGenerator
    {
        public string RandomAlphaNumeric(string formatSpecifier)
        {
            string result = string.Empty;
            var rand = new Random();
            foreach(char value in formatSpecifier)
            {
                if (value == 'x')
                {
                    result += (char)rand.Next('a', 'z');
                }else if(value == 'X')
                {
                    result += (char)rand.Next('A', 'Z');
                }else if (value == 'N')
                {
                    result += rand.Next(0, 9);
                }
                else
                {
                    result += value;
                }
            }
            return result;
        }

        public string RandomBoolean(BooleanEnum booleanEnum)
        {
            var rand = new Random();
            var value = rand.Next(0, 2);
            switch (booleanEnum) {
                case BooleanEnum.TRUE_FALSE:
                    return value == 0 ? "TRUE" : "FALSE";
                case BooleanEnum.T_F:
                    return value == 0 ? "T" : "F";
                case BooleanEnum.YES_NO:
                    return value == 0 ? "YES" : "NO";
                case BooleanEnum.Y_N:
                    return value == 0 ? "Y" : "N";
                case BooleanEnum.ZERO_ONE:
                default:
                    return value.ToString();                
            }
        }

        public string RandomCity()
        {
            using (StreamReader r = new StreamReader("Data.json"))
            {
                string json = r.ReadToEnd();
                var rand = new Random();
                dynamic array = JsonConvert.DeserializeObject(json);
                return array.City[rand.Next(0, 15)];
            }
        }

        public string RandomCompany()
        {
            var rand = new Random();
            return RandomWords(rand.Next(2, 3)) + " plc";
        }

        public string RandomCountry()
        {
            using (StreamReader r = new StreamReader("Data.json"))
            {
                string json = r.ReadToEnd();
                var rand = new Random();
                dynamic array = JsonConvert.DeserializeObject(json);
                return array.Country[rand.Next(0, 15)];
            }
        }

        public long RandomCreditCard(CreditCardEnum creditCard = CreditCardEnum.OTHER)
        {
            var rand = new Random();
            if(creditCard == CreditCardEnum.MASTERCARD)
            {
                return rand.NextLong(4000_0000_0000_0000, 4999_9999_9999_9999);
            }
            else if(creditCard == CreditCardEnum.VISA)
            {
                return rand.NextLong(5100_0000_0000_0000, 5199_9999_9999_9999);
            }
            else
            {
                return rand.NextLong(5500_0000_0000_0000, 5599_9999_9999_9999);
            }
        }

        public int RandomCVV()
        {
            var rand = new Random();
            return rand.Next(100, 999);
        }

        public DateTime RandomDate(DateTime startDate = default, DateTime endDate = default)
        {
            var rand = new Random();
            if(startDate != default && endDate != default)
            {
                int difference = (endDate - startDate).Days;
                int value = rand.Next(0, difference);
                return startDate.AddDays(value);
            }
            else if(startDate != default && endDate == default)
            {
                int value = rand.Next(0,1000);
                return startDate.AddDays(value);
            }
            else if (startDate == default && endDate != default)
            {
                int value = rand.Next(0,1000);
                return endDate.AddDays(value*-1);
            }
            else
            {
                int value = rand.Next(0,1000);
                return DateTime.Today.AddDays(value * Math.Pow(-1,value));
            }
        }
        
        public string RandomEmail()
        {
            return RandomFirstNameMale() + RandomSurname() + "@gmail.com";
        }

        public string RandomFirstNameFemale()
        {
            using (StreamReader r = new StreamReader("Data.json"))
            {
                string json = r.ReadToEnd();
                var rand = new Random();
                dynamic array = JsonConvert.DeserializeObject(json);
                return array.Name.FirstNamesFemale[rand.Next(0, 15)];
            }
        }

        public string RandomFirstNameMale()
        {
            using (StreamReader r = new StreamReader("Data.json"))
            {
                string json = r.ReadToEnd();
                var rand = new Random();
                dynamic array = JsonConvert.DeserializeObject(json);
                return array.Name.FirstNamesMale[rand.Next(0, 15)];
            }
        }

        public string RandomFullName(Gender gender)
        {
            if (gender == Gender.MALE)
            {
                return RandomFirstNameMale() +" "+ RandomSurname();
            }
            else
            {
                return RandomFirstNameFemale() + " " + RandomSurname();
            }
        }

        public string RandomInitials()
        {
            Random rnd = new Random();
            return (char)rnd.Next('A','Z')+"."+(char)rnd.Next('A', 'Z');
        }

        public int RandomNumberRange(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }

        public string RandomPassportNumber(string formatSpecifier = "ANNNNNNNNNN") 
        {            
            if(formatSpecifier == null)
            {
                formatSpecifier = "ANNNNNNNNNN";
            }
            string returnValue = String.Empty;
            foreach(char c in formatSpecifier)
            {
                Random rnd = new Random();
                if (c == 'A')
                {
                    returnValue += (char)rnd.Next('A', 'Z');
                }
                else if (c == 'N') { 
                    returnValue += rnd.Next(0,9);
                }
            }
            return returnValue;
        }

        public long RandomPhoneNumber(string formatSpecifier = "234-xx-xxx-xxx-xx")
        {            
            if(formatSpecifier == null)
            {
                formatSpecifier = "234-xx-xxx-xxx-xx";
            }
            string returnValue = string.Empty;
            foreach(char c in formatSpecifier)
            {
                Random rnd = new Random();
                if(Char.IsNumber(c))
                {
                    returnValue += c;
                }else if(c == '-')
                {
                    continue;
                }else if(c == 'x')
                {
                    returnValue += rnd.Next(0,9);
                }
            }
            return long.Parse(returnValue);
        }

        public int RandomPinCode()
        {
            var rand = new Random();
            return rand.Next(1000, 9999);
        }

        public string RandomStreetAddress()
        {
            var rand = new Random();
            return rand.Next(1, 100) +" "+ RandomWords(rand.Next(2, 3));
        }

        public string RandomSurname()
        {
            using (StreamReader r = new StreamReader("Data.json"))
            {
                string json = r.ReadToEnd();
                var rand = new Random();
                dynamic array = JsonConvert.DeserializeObject(json);
                return array.Name.Surname[rand.Next(0, 15)];
            }
        }

        public string RandomWords(int length =1)
        {
            if(length < 1)
            {
                throw new ArgumentException("The length of the words has to be greater than 1");
            }
            using (StreamReader r = new StreamReader("Data.json"))
            {
                string json = r.ReadToEnd();
                var rand = new Random();
                dynamic array = JsonConvert.DeserializeObject(json);
                string value = array.Text;
                List<string>valueAsList = value.Split(' ').ToList();
                int start = rand.Next(0, valueAsList.Count);
                while ((start +length) > valueAsList.Count)
                {
                    valueAsList.AddRange(valueAsList);
                }
                return String.Join(" ",valueAsList.Skip(start).Take(length));                
            }
        }

        public string RandomWords(int minLength, int maxLength)
        {
            var rand = new Random();
            return RandomWords(rand.Next(minLength, maxLength));
        }

        public string RandomWordsFromList(string values)
        {
            var array = values.Split(';',',');
            Random rand = new Random();
            int value = rand.Next(0, array.Length);
            return array[value];
        }

        public string RandomZipCode(string formatSpecifier = "ANNNNNN")
        {            
            if(formatSpecifier == null)
            {
                formatSpecifier = "ANNNNNN";
            }
            string returnValue = String.Empty;
            foreach (char c in formatSpecifier)
            {
                Random rnd = new Random();
                if (c == 'A')
                {
                    returnValue += (char)rnd.Next('A', 'Z');
                }
                else
                {
                    returnValue += rnd.Next(0,9);
                }
            }
            return returnValue;
        }
    }
}
