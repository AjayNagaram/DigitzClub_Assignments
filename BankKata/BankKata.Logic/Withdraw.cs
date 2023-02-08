using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata.Logic
{
    public class Withdrawal : RegistryRecord, IRegistryRecord
    {
        public Withdrawal(int balance, int amount, DateTime datetime) : base(balance, amount, datetime)
        {
        }

        public override int Execute()
        {
            if (Balance - Amount >= 0)
            {
                Balance = Balance - Amount;
            }

            return Balance;
        }
    }
}
