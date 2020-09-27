using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateValuesApi.Models
{
    public class Name:DataType
    {
        public string ColumnTitle { get; set; }       
        public NameType type { get; set; }

        public object RandomValue(IRandomItemGenerator randomItemGenerator)
        {            
            if(type == NameType.FirstNameFemale)
            {
                return randomItemGenerator.RandomFirstNameFemale();
            }else if(type == NameType.FirstNameMale)
            {
                return randomItemGenerator.RandomFirstNameMale();
            }else if(type == NameType.FullNameMale)
            {
                return randomItemGenerator.RandomFullName(Gender.MALE);
            }else if(type == NameType.FullNameFemale)
            {
                return randomItemGenerator.RandomFullName(Gender.FEMALE);
            }else if (type == NameType.Initials)
            {
                return randomItemGenerator.RandomInitials();
            }
            else {
                return randomItemGenerator.RandomSurname();                    
            }
        }
    }
    public enum NameType { FirstNameMale, FirstNameFemale,Surname, FullNameMale,FullNameFemale, Initials};
}
