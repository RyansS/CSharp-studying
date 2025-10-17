internal class Program
{
    private static void Main(string[] args)
    {
        var processor = new PaymentProcessor();

        processor.ProcessPayment(new PaypalPayment(), 100.0m);
        processor.ProcessPayment(new CreditCardPayment(), 50.0m);
        processor.ProcessPayment(new PixPayment(), 175.0m);
    }
}

public interface IPayment
{
    void Process(decimal amount);
}

public class PaypalPayment : IPayment
{
    public void Process (decimal amount)
    {
        Console.WriteLine($"Registering payment of the total: {amount}$");
    }
}

public class CreditCardPayment : IPayment
{
    public void Process (decimal amount)
    {
        Console.WriteLine($"Registering payment of the total: {amount}$");
    }
}

public class PixPayment : IPayment
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
}

