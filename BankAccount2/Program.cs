internal class Program
{
    private static void Main(string[] args)
    {
        Console.ReadKey();
    }

    class BankAccount
    {
        public string Username {get; private set;}

        public decimal Balance {get; private set;}

        private int IdUser {get; set;}

        List <BankAccount> AllBankAccounts = new List<BankAccount>();

        public BankAccount (string username, decimal balance, int iduser)
        {
            Username = username;
            Balance = balance;
            IdUser = iduser;
        }

        public void Withdraw () {
            
            Console.WriteLine("- Please, say your name: ");
            string NameAnswer = Console.ReadLine();

            Console.WriteLine("- Please, write your id: ");
            int IdAnswer = int.Parse(Console.ReadLine());

            var SearchAccount = AllBankAccounts.Where(match => match.Username == NameAnswer && match.IdUser == IdAnswer);

            if (SearchAccount != null)
            {
                Console.WriteLine($"- Your balance: {Balance}");
                Console.Write("How much would you like to withdraw? ");
                decimal Ammount = decimal.Parse(Console.ReadLine());

                Balance -= Ammount;

                Console.WriteLine($"- Withdrawing {Ammount}$...");
                Console.ReadKey();
            }
        }
    }


}