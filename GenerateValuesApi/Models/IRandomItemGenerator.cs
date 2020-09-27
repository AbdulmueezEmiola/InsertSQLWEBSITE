using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi
{
    public interface IRandomItemGenerator
    {
        string RandomFirstNameMale();
        string RandomFirstNameFemale();
        string RandomSurname();
        string RandomFullName(Gender gender);
        string RandomInitials();
        long RandomPhoneNumber(string formatSpecifier);
        string RandomEmail();
        DateTime RandomDate(DateTime startDate, DateTime endDate);
        string RandomCompany();
        string RandomPassportNumber(string formatSpecifier);
        string RandomStreetAddress();
        string RandomCity();
        string RandomCountry();
        string RandomZipCode(string formatSpecifier);
        long RandomCreditCard(CreditCardEnum creditCard);
        int RandomPinCode();
        int RandomCVV();
        string RandomWords(int length);
        string RandomWords(int minLength, int maxLength);
        string RandomWordsFromList(string values);
        string RandomBoolean(BooleanEnum booleanEnum);
        string RandomAlphaNumeric(string formatSpecifier);
        int RandomNumberRange(int min, int max);

    }
    public enum BooleanEnum { TRUE_FALSE, T_F, ZERO_ONE, YES_NO,Y_N}
    public enum Gender { MALE,FEMALE,OTHER };
    public enum CreditCardEnum { VISA, MASTERCARD, VERVE, OTHER};
}
