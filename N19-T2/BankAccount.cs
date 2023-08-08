using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_T2
{
    abstract class BankAccount
    {
        protected string AccountHolderName { get; set; }
        protected string AccountNumber { get; set; }
        protected double Balance { get; set; }


        public virtual void Depozit(double money)
        {
            if (money >= 1000)
            {
                Balance += money;
            }
            else
            {
                throw new Exception("You enter invalid money.");
            }
        }


        public virtual void WithDraw(double money)
        {
            if (money < Balance)
            {
                Balance -= money;
            }
            else
            {
                throw new Exception("You enter invalid money.");
            }
        }
    }
}
