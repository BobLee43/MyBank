using MyBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class Program
    {
        static void Main(String[] args)
        {
            var newAccount = new BankAccount("Larry", 100);
            Console.WriteLine($"New Account for {newAccount.Owner} with balance of {newAccount.Balance}");
            Console.ReadLine();
        }
    }
}