using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class BankService
    {
        public Account CreateAccount (string accountHolderName)
        {
            return new Account (accountHolderName); 
        }


       



    }
}
