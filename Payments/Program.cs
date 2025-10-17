
internal class Program
{
    private static void Main(string[] args)
    {
        var processor = new PaymentProcessor();

        processor.ProcessPayment(new PaypalPayment(), 100.0m);
    }
}

public interface IPayment
{
    void Process(decimal amount);
}

public class PaypalPayment
{
    public void Process (decimal amount)
    {
        Console.WriteLine($"Registering payment of the total: {amount}$");
    }
}

public class CreditCardPayment
{
    public void Process (decimal amount)
    {
        Console.WriteLine($"Registering payment of the total: {amount}$");
    }
}

public class PixPayment
{
    public void Process(decimal amount)
    {
        Console.WriteLine($"Registering payment of the total: {amount}$");
    }
}

public class PaymentProcessor
{
    public void ProcessPayment(IPayment payment, decimal amount)
    {
        payment.Process(amount);
    }

    internal void ProcessPayment(PaypalPayment paypalPayment, decimal v)
    {
        throw new NotImplementedException();
    }
}

