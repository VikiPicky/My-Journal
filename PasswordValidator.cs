using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Journal
{
    public static class PasswordValidator
    {

        const int NUM_UPPER_LETTERS = 1;
        const int NUM_LOWER_LETTERS = 1;
        const  int NUM_DIGITS = 1;
        

        public static string GetPasswordValidationErrorMessage(String password)
        {
            int upperCount = 0;
            int lowerCount = 0;
            int digitCount = 0;
            int letterCount = 0;

            int inputLength = password.Length;

            for (int i = 0; i < inputLength; i++)
            {
                char ch = password.ElementAt(i);
                if (Char.IsUpper(ch))
                    upperCount++;
                else if (Char.IsLower(ch))
                    lowerCount++;
                else if (Char.IsDigit(ch))
                    digitCount++;
            }

            if (upperCount < NUM_UPPER_LETTERS)
            {
                return "IMPORTANT: Invalid Password not enough: upper case letters";

            }

            if (lowerCount < NUM_LOWER_LETTERS)
            {
                return "IMPORTANT: Invalid Password not enough: lower case letters";

            }

            if (digitCount < NUM_DIGITS)
            {
                return "IMPORTANT: Invalid Password not enough: digits";
            }

            return null;
        }
    }
}
        
    
