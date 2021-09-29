using System;
using System.IO;
using lib;
namespace myAp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mycontext = new Context();
            var myAcct = new Account();
            
            mycontext.Add(myAcct);
            mycontext.SaveChanges();

            var depositTransaction = new Transaction {Amount = 100,TransactionType = "deposit",Account = myAcct};
            // var withTransaction = new Transaction{Amount = 50,TransactionType = "withdraw"};
            // var overdraftTransaction = new Transaction{Amount = 75,TransactionType = "overdraft fee"};
            // var secondDeposit = new Transaction{Amount = 300,TransactionType = "deposit"};
            mycontext.Add(depositTransaction);
            // myAcct.Transactions.Add(depositTransaction);
            mycontext.SaveChanges();
            // myAcct.Transactions.Add(withTransaction);
            // myAcct.Balance -= 50;
            // mycontext.SaveChanges();
            // myAcct.Transactions.Add(overdraftTransaction);
            // myAcct.Balance -= 75;
            // mycontext.SaveChanges();
            // myAcct.Transactions.Add(secondDeposit);
            // myAcct.Balance += 300;
 

            // mycontext.SaveChanges();
            // Console.WriteLine($"account Final state : {mycontext.Entry(myAcct).State}");


        }
    }
}
