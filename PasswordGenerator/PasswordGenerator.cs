using System;
using System.Linq;

namespace PasswordGenerator
{
    public class Generator
    {

        public string PasswordGenOne(string firstname, string lastname, int age)
        {


            firstname.ToLower();
            string lName = lastname.ToUpper();
            char[] lArray = lName.ToCharArray();


            int year = 2019 - age;

            return firstname.ToLower() + lArray[0] + "_" + year;



            //throw new NotImplementedException();
        }

        public string PasswordGenTwo(string firstname, string lastname, int age)
        {

            int year = 2019 - age;

            string fName = firstname.ToUpper();
            char[] fArray = fName.ToCharArray();

            return lastname + year + fArray[0];

            //throw new NotImplementedException();
        }

        public string PasswordGenThree(int length)
        {


            string input = "AB@#ef12";

            if (input.Any(c => !char.IsLetterOrDigit(c)) && input.Any(char.IsUpper))
            {
                return input.Length.ToString();
            }
            else
            {
                throw new NotImplementedException();

            }





        }
    }
}
