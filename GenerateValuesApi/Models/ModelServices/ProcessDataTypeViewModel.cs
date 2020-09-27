using GenerateValuesApi.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models.NewFolder
{
    public static class ProcessDataTypeViewModel
    {
         public static IEnumerable<DataType> ConvertDataType(DataTypeViewModel dataTypeViewModel)
         {
            foreach(RowViewModel row in dataTypeViewModel.Rows)
            {
                switch (row.DataType)
                {
                    case "Name":
                        yield return ConvertName(row);
                        break;
                    case "Phone":
                        yield return ConvertPhone(row);
                        break;
                    case "Email":
                        yield return ConvertGenericDataType<Email>(row);
                        break;
                    case "Passport Number":
                        yield return ConvertPassport(row);
                        break;
                    case "Company":
                        yield return ConvertGenericDataType<Company>(row);
                        break;
                    case "Street Address":
                        yield return ConvertGenericDataType<StreetAddress>(row);
                        break;
                    case "City":
                        yield return ConvertGenericDataType<City>(row);
                        break;
                    case "Country":
                        yield return ConvertGenericDataType<Country>(row);
                        break;
                    case "Postal/Zip":
                        yield return ConvertZipCode(row);
                        break;
                    case "Fixed Number Of Words":
                        yield return ConvertWordsFixed(row);
                        break;
                    case "Random Number Of Words":
                        yield return ConvertWordsRange(row);
                        break;
                    case "Date":
                        yield return ConvertDate(row);
                        break;
                    case "Credit Card":
                        yield return ConvertCreditCard(row);
                        break;
                    case "Pin":
                        yield return ConvertGenericDataType<PinCode>(row);
                        break;
                    case "CVV":
                        yield return ConvertGenericDataType<CVV>(row);
                        break;
                    case "Boolean":
                        yield return ConvertBoolean(row);
                        break;
                    case "AlphaNumeric":
                        yield return ConvertAlphaNumeric(row);
                        break;
                    case "Numbers":
                        yield return ConvertNumbers(row);
                        break;
                    case "List of Words":
                        yield return ConvertWordsFromList(row);
                        break;
                }
            }
         }
        private static WordsFromList ConvertWordsFromList(RowViewModel row)
        {
            return new WordsFromList { ColumnTitle = row.ColumnName, Type = row.Value };
        }
        private static AlphaNumeric ConvertAlphaNumeric(RowViewModel row)
        {
            return new AlphaNumeric { ColumnTitle = row.ColumnName, Format = row.Value };
        }
        private static Numbers ConvertNumbers(RowViewModel row)
        {
            return new Numbers { ColumnTitle = row.ColumnName, MinValue = int.Parse(row.MinValue), MaxValue = int.Parse(row.MaxValue) };
        }
        private static BooleanValue ConvertBoolean(RowViewModel row)
        {
            switch (row.Value)
            {
                case "True or False":
                default:
                    return new BooleanValue { ColumnTitle = row.ColumnName, type = BooleanEnum.TRUE_FALSE };
                case "T or F":
                    return new BooleanValue { ColumnTitle = row.ColumnName, type = BooleanEnum.T_F };
                case "0 or 1":
                    return new BooleanValue { ColumnTitle = row.ColumnName, type = BooleanEnum.ZERO_ONE };
                case "Yes or No":
                    return new BooleanValue { ColumnTitle = row.ColumnName, type = BooleanEnum.YES_NO };
                case "Y or N":
                    return new BooleanValue { ColumnTitle = row.ColumnName, type = BooleanEnum.Y_N };
            }
        }
        private static Telephone ConvertPhone(RowViewModel row)
        {
            return new Telephone { ColumnTitle = row.ColumnName, FormatSpecifier = row.Value };
        }
        private static Passport ConvertPassport(RowViewModel row)
        {
            return new Passport { ColumnTitle = row.ColumnName, FormatSpecifier = row.Value };
        }
        private static T ConvertGenericDataType<T>(RowViewModel row) where T : DataType, new()
        {
            return new T { ColumnTitle = row.ColumnName };
        }
        private static ZipCode ConvertZipCode(RowViewModel row)
        {
            return new ZipCode { ColumnTitle = row.ColumnName, FormatSpecifier = row.Value };
        }
        private static Words ConvertWordsFixed(RowViewModel row)
        {
            return new Words { ColumnTitle = row.ColumnName, length = int.Parse(row.Value) };
        }
        private static Words ConvertWordsRange(RowViewModel row)
        {
            return new Words { ColumnTitle = row.ColumnName, MinLength = int.Parse(row.MinValue), MaxLength = int.Parse(row.MaxValue) };
        }
        private static Date ConvertDate(RowViewModel row)
        {
            return new Date { ColumnTitle = row.ColumnName, StartDate = DateTime.Parse(row.MinValue), EndDate = DateTime.Parse(row.MaxValue) };
        }
        private static CreditCard ConvertCreditCard(RowViewModel row)
        {
            switch (row.Value)
            {
                case "MASTERCARD":
                    return new CreditCard { ColumnTitle = row.ColumnName, type = CreditCardEnum.MASTERCARD };
                case "VISA":
                    return new CreditCard { ColumnTitle = row.ColumnName, type = CreditCardEnum.VISA };
                case "OTHERS":
                default:
                    return new CreditCard { ColumnTitle = row.ColumnName, type = CreditCardEnum.OTHER };
            }
        }
        private static Name ConvertName(RowViewModel row)
        {
            switch (row.Value)
            {
                case "First Name(Male)":
                    return new Name { ColumnTitle = row.ColumnName, type = NameType.FirstNameMale };
                case "First Name(Female)":
                    return new Name { ColumnTitle = row.ColumnName, type = NameType.FirstNameFemale };
                case "Full Name(Male)":
                    return new Name { ColumnTitle = row.ColumnName, type = NameType.FullNameMale };
                case "Full Name(Female)":
                    return new Name { ColumnTitle = row.ColumnName, type = NameType.FullNameFemale };
                case "Initials":
                    return new Name { ColumnTitle = row.ColumnName, type = NameType.Initials};
                case "Last Name":
                default:
                    return new Name { ColumnTitle = row.ColumnName, type = NameType.Surname };
            }
        }
    }
}
