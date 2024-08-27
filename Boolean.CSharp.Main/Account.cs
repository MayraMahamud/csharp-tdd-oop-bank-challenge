using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Account
    {
        public string AccountHolder { get; private set; }
        public decimal Balance { get; private set; }

        private List<Transaction> _transactions;

        public Account(string accountHolder)
        {
            AccountHolder = accountHolder;
            Balance = 0.0M;
            _transactions = new List<Transaction>();

        }


        public void Deposit(decimal amount, DateTime date)
        {

            Balance += amount;


        }

        public void Deposit2(decimal amount, decimal balance, DateTime date)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New balance ; {balance}");
                DateTime dateTime = DateTime.Now;


            }
            Balance += amount;

        }





        public void Withdraw(decimal amount, DateTime date)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(date, amount, "debit"));


           
        }


       


        public decimal GetBalance()
        {
            return Balance;
        }






        public string GenerateStatement()
        {
            var statement = new StringBuilder();
            statement.AppendLine("date||credit||debit||balance");
            decimal runningBalance = 0.0M;

            foreach (var transaction in _transactions.OrderByDescending(t => t.Date))
            {
                if (transaction.Type == "credit")
                {
                    runningBalance += transaction.Amount;

                    statement.AppendLine($"{transaction.Date:dd/MM/yyyy}||{transaction.Amount,7:F2}||||{runningBalance,8:F2}");
                }

                else if (transaction.Type == "debit")
                {
                    runningBalance -= transaction.Amount;

                    statement.AppendLine($"{transaction.Date:dd/MM/yyyy}||||{transaction.Amount,7:F2}||{runningBalance,8:F2}");

                }
            }

            return statement.ToString();

        }
      
        public string GetStatement23() 
        {
            var sb = new StringBuilder();
            sb.AppendLine("date||credit||debit||balance");
            foreach(var transaction in _transactions.OrderByDescending (t => t.Date))
            {
                sb.AppendLine($"{transaction.Date:dd/MM/yyyy}||{transaction.Amount,7:F2}||{transaction,7:F2}");
            }
            return sb.ToString();   
        }
       




    }
}





    

