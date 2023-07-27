using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_HT2
{
    public class UniquePasswordGenerate : SecurePasswordGenerator
    {
         HashSet<string> uniquePasswordList = new HashSet<string>();


        public UniquePasswordGenerate(int length, bool hasLetters, bool hasDigits = false)
            : base(length, hasLetters, hasDigits) { }


        public string GenerateUniquePassword()
        {
            string uniquePassword = Generate();

            if (!uniquePasswordList.Contains(uniquePassword))
            {
                uniquePasswordList.Add(uniquePassword);
                return uniquePassword;
            }

            return GenerateUniquePassword();
        }
    }
}
