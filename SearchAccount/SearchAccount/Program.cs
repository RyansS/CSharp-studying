public class CurrentAccount
{
    public string Account { get; set; }
    public string Owner { get; set; }
    public double Value { get; set; }

    public CurrentAccount (string account, string owner, double value)
    {
        Account = account;
        Owner = owner;
        Value = value;
    }

    private List<CurrentAccount> accounts = new();

    CurrentAccount acc1 = new CurrentAccount( "nubank", "john", 3000 );
    CurrentAccount acc2 = new CurrentAccount("itau", "zeph", 3000);

    private CurrentAccount SearchAccountByBank(string? account)
    {
        return (from j in accounts
                where j.Account.Equals(account)
                select j).FirstOrDefault();
    }
}

