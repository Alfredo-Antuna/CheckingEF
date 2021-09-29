using System.Collections.Generic;
namespace lib
{

    public class Account{
        public List<Transaction> Transactions = new List<Transaction>();
        public int Id {get; set;}
        public int Balance {get; set;}

    }

    
}