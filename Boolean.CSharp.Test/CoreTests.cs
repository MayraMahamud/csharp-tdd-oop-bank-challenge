using Boolean.CSharp.Main;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Core _core;



        [Test]
        public void CreateAccountTest()
        {
            BankService bankService = new BankService();
            var expectedName = "Mayra";

            var account = bankService.CreateAccount(expectedName);

            Assert.AreEqual(expectedName, account.AccountHolder);
        }


        [Test]
        public void CreateSavingsAccountTest()
        {
            string accountHolderName = "Mayra";
            var savingsAccount = new SavingsAccount(accountHolderName);

            Assert.AreEqual(accountHolderName, savingsAccount.AccountHolder);

        }


        [Test]
        public void GenereateStatementTest()
        {
            var account = new Account("Mayra");

            account.Deposit(1000.00M, new DateTime(2024, 8, 24));
            account.Deposit(2000.00M, new DateTime(2024, 8, 30));
            account.Withdraw(500.00M, new DateTime(2024, 8, 31));

            string expectedStatement = "date||credit||debit||balance\n" + "31/08/2024||||500.00 ||2500.00\n" + "30/08/2024||2000.00||||3000.00\n" + "24/08/2024||1000.00||||1000.00\n";

            string actualStatement = account.GenerateStatement();

            Assert.AreEqual(expectedStatement, actualStatement);




        }


   
        [Test]

        public void Deposit2Test()
        {
            var account = new Account("Mayra");
            decimal depositAmount = 1000.00M;
            DateTime depositDate = DateTime.Now;    

            account.Deposit(depositAmount, depositDate);

            Assert.AreEqual(depositAmount, account.GetBalance());
        }




        [Test]
        public void WithdrawTest()
        {
            var account = new Account("Mayra");
            account.Deposit(1000.00M, DateTime.Now);
            decimal withdrawAmount = 200.00M;
            DateTime withdrawDate = DateTime.Now;

            account.Withdraw(withdrawAmount, withdrawDate);

            Assert.AreEqual(800.00M, account.Balance);


           
        }

        
       

       

    }
}




   


