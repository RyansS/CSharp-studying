Random random = new Random();

int key1 = random.Next(1, 100);
double key2 = random.NextDouble();
int key3 = random.Next(1, 50);

Console.WriteLine("You're key is: " + key1);
Console.WriteLine("You're key is: " + key2);
Console.WriteLine("You're key is: " + key3);

Console.ReadKey();