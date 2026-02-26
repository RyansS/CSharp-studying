Random randomNumbs = new Random();


int[] arrayofNumbs = new int[10];

for (int i = 0; i <= arrayofNumbs.Length; i++)
{
    arrayofNumbs[i] = randomNumbs.Next(1, 10);
}

var Odd = arrayofNumbs.Where(i => i % 2 == 1);

    foreach (var j in Odd)
{
    Console.WriteLine(j);
}

Console.ReadKey();