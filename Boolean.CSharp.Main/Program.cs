using Boolean.CSharp.Main;
using NUnit.Framework;



    var account = new Account("Mayra");

    account.Deposit(1000.00M, new DateTime(2024, 8, 24));
    account.Deposit(2000.00M, new DateTime(2024, 8, 30));
    account.Withdraw(500.00M, new DateTime(2024, 8, 31));

    string expectedStatement = "date||credit||debit||balance\n" + "31/08/2024||||500.00 ||2500.00\n" + "30/08/2024||2000.00||||3000.00\n" + "24/08/2024||1000.00||||1000.00\n";

    string actualStatement = account.GenerateStatement();

  
    Console.WriteLine(actualStatement);
