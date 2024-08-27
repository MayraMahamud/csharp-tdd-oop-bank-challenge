using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Transaction
    {
        public DateTime Date {  get; private set; } 
        public decimal Amount { get; private set; }
        public string Type { get; private set; }
      

      
        public Transaction(DateTime date, decimal amount, string type)
        {
            Date = date;
            Amount = amount;
            Type = type;
          
        }



    }
}
