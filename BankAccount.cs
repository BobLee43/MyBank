using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public class BankAccount
    {
        public int Number {  get; set; }
        public string Owner { get; set; }   
        public decimal Balance { get; set; }

        public void Credit(decimal amount, DateTime tranDate, string note)
        {
        
        } //Credit()

        public void Debit(decimal amount, DateTime tranDate, string note) { 
        
        } //Debit()

        public BankAccount(String name, decimal openBalance) 
        {
            Owner = name;
            Balance = openBalance;
        }


    }
}
