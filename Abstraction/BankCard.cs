using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public  class BankCard
    {
        public BankCard(string fullname,string cardNumber, string cvv, decimal balance)
        {
            Fullname = fullname;
            CardNumber = cardNumber;
            CVV = cvv;
            Balance = balance;
        }
        public string Fullname { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount) 
        {
            Console.WriteLine("My balance: " + Balance + " AZN");
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine(amount + " AZN added to your account.\nCurrent Balance: " + Balance + " AZN");
            }
            else
            {
                Console.WriteLine("This "+amount+" AZN cannot be deposited");
            }
        }
        public virtual void Withdraw(decimal amount) 
        {
            Console.WriteLine("Withdraw:\n"+"My balance: " + Balance + " AZN");
            if (amount <= Balance) 
            {
                Balance -= amount;
                Console.WriteLine(amount + " AZN withdraw from your account.\nCurrent Balance: " + Balance + " AZN");
            }
            else { Console.WriteLine("Withdraw money: " + amount + " AZN\n" + "There is not enough money in your balance"); }
        }
    }
}
