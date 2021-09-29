namespace lib
{
    public class Transaction{
        public string TransactionType {get; set;}//enum?
        public int Id {get; set;}
        public int Amount {get; set;}
        public Account Account {get; set;}
    }
}