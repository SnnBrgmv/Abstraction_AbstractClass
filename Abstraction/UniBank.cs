using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class UniBank : BankCard
    {
        public UniBank(string fullname, string cardNumber, string cvv, decimal balance) : base(fullname, cardNumber, cvv, balance)
        {}
        
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("My UniBank account:\nMy balance: " + Balance + " AZN");
            Console.WriteLine("Withdrawn money: " + amount + " AZN");
            decimal commission = amount * .015m;
            amount -= commission;
            if(amount <= Balance) 
            {
                Balance -= amount;
                Console.WriteLine("Commission fee: " + commission + " AZN\n" + amount + " AZN withdraw from your account.\nCurrent balance: " + Balance + " AZN");
            }
            else
            {
                Console.WriteLine("There is not enough money in your balance");
            }

        }

    }
}
