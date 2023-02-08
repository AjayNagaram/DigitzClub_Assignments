using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata.Logic
{
    public class Deposit : RegistryRecord
    {
        public Deposit(int balance, int amount, DateTime datetime) : base(balance, amount, datetime)
        {
        }

        public override int Execute()
        {

            Balance = Balance + Amount;

            return Balance;
        }
    }
}
