using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata.Logic
{
    public interface IRegistryRecord
    {
        public int Amount { get; set; }
        public DateTime Datetime { get; set; }
        public int Balance { get; set; }

        public int Execute();

    }
}
