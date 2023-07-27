using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace N13_HT2
{
    public class SecurePasswordGenerator : PasswordGenerate
    {
        public SecurePasswordGenerator(int length, bool hasLetters, bool hasDigits = false)
            : base(length, hasLetters, hasDigits){}


        public string Generate(bool hasSymbols = true)
        {
            string CharSet = "";

            if (HasLetters)
            {
                CharSet += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (HasDigits)
            {
                CharSet += "0123456789";
            }
            if (hasSymbols)
            {
                CharSet += "!@#$%^&*()-_=+[]{}|;:,.<>?";
            }

            char[] passwordChars = new char[Length];
            Random random = new Random();

            for (int i = 0; i < Length; i++)
            {
                int randomIndex = random.Next(CharSet.Length);
                passwordChars[i] = CharSet[randomIndex];
            }

            return new string(passwordChars);
        }
    }
}
