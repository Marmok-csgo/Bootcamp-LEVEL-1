using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace N13_HT2
{
    public class PasswordGenerate
    {
        public int Length;
        public bool HasLetters;
        public bool HasDigits;


        public PasswordGenerate(int  length, bool hasletters, bool hasdigits = true)
        {
            Length = length;
            HasLetters = hasletters;
            HasDigits = hasdigits;
        }


        public string Generate()
        {
            string CharSet = "";
            Random random = new Random();

            if (HasLetters)
            {
                CharSet += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (HasDigits)
            {
                CharSet += "0123456789";
            }
            char[] passwordChars = new char[Length];

            for (int i = 0; i < Length; i++)
            {
                int randomIndex = random.Next(CharSet.Length);
                passwordChars[i] = CharSet[randomIndex];
            }

            return new string(passwordChars);

        }
    }
}
