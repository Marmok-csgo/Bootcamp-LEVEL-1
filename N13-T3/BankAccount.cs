using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_T3
{
    public class BankAccount
    {
        public string FirstName;
        public string LastName;
        public double Deposit = -20;


        public BankAccount(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }


        public BankAccount(string firstname, string lastname, double deposit)
            :this(firstname, lastname)
        {
            Deposit = deposit;
            if (deposit > 0)
            {
                Deposit = deposit;
            }
            else
            {
                throw new Exception("Deposit must bigger than ZERO!");
            }
        }

        public override string ToString()
        {
            return $"{FirstName} - {LastName} - {Deposit}";
        }
    }
}
