using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public static decimal ViewBalance()
        {
            return Program.Balance;
        }
        public static decimal Withdraw(decimal amount)
        {
            if (amount <= Program.Balance && amount > 0)
            {
                Program.Balance = Program.Balance - amount;
                return Program.Balance;
            }
            return amount;

        }
        public static decimal Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Program.Balance = Program.Balance + amount;
                return Program.Balance;
            }
            return amount;
        }
    }
}
