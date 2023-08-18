using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class LeoBank : BankCard
    {
        public LeoBank(string fullname, string cardNumber, string cvv, decimal balance) : base(fullname, cardNumber, cvv, balance)
        {}
    }
}
