internal class Program
{
    private static void Main(string[] args)
    {
        Console.ReadKey();
    }

    class BankAccount
    {
        private static int iduserincrement = 1;
        public string Username {get; private set;}

        public decimal Balance {get; private set;}

        private int IdUser {get; set;}

        private string Email {get; set;}

        private string Password {get; set;}

        List <BankAccount> AllBankAccounts = new List<BankAccount>();

        public BankAccount (string username, string email, string password)
        {

            Username = username;
            IdUser += iduserincrement;
            Email = email;
            Password = password;
        }

        public void CreateAccount ()
        {
            bool repeat = false;

            do
            {
            Console.Write("- Tell us your full name: ");
            string fullname = Console.ReadLine();

            Console.Write("- Give us your email: ");
            string email = Console.ReadLine();

            Console.Write("- Create a strong password: ");
            string password = Console.ReadLine();

            if (fullname.Length <10 || email.Length <10 || password.Length < 8)
                {
                    Console.Clear();
                    repeat = true;
                }
                else
                {
                    BankAccount account = new BankAccount(fullname, email, password);

                    Console.WriteLine("Account created!!");
                }

            }

            while (repeat);
            {
                Console.Write("- Tell us your full name: ");
            string fullname = Console.ReadLine();

            Console.Write("- Give us your email: ");
            string email = Console.ReadLine();

            Console.Write("- Create a strong password: ");
            string password = Console.ReadLine();

            if (fullname.Length <10 || email.Length <10 || password.Length < 8)
                {
                    Console.Clear();
                }
                else
                {
                    BankAccount account = new BankAccount(fullname, email, password);
                    Console.WriteLine("Account created!!");
                    repeat = false;
                }
            }
            
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