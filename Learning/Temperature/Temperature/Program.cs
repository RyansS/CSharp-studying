

using TemperatureIs; // The namespace can't have the same name of the class, it will cause a problem.

Console.WriteLine("How is the temperature today?");
int degree = int.Parse(Console.ReadLine());

Temperature.weather(degree); // it works like a normal method, i just call the class first

Console.ReadKey();

