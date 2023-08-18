using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class AccessBank : BankCard
    {
        public AccessBank(string fullname, string cardNumber, string cvv, decimal balance) : base(fullname, cardNumber, cvv, balance)
        {}
        public override void Deposit(decimal amount)
        {
            Console.WriteLine("My AccessBank account:\nMy balance: " + Balance + " AZN");
            Console.WriteLine("Deposit money: " + amount + " AZN");
            decimal commission = amount * .003m;
            amount -= commission;
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Commission fee: " + commission + " AZN\n" + amount + " AZN added to your account.\nCurrent Balance: " + Balance + " AZN");
            }
            else
            {
                Console.WriteLine("This amount cannot be deposited");
            }
        }
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("My AccessBank account:\nMy balance: " + Balance + " AZN");
            Console.WriteLine("Withdrawn money: " + amount + " AZN");
            decimal commission = amount * .016m;
            amount -= commission;
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Commission fee: " + commission + "AZN\n" + amount + "AZN withdraw from your account.\nCurrent balance: " + Balance + " AZN");
            }
            else
            {
                Console.WriteLine("There is not enough money in your balance");
            }
        }
    }
}
