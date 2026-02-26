
Random rand = new Random();
int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++ )
{
    numbers[i] = rand.Next(1,20);
}

var even = from j in numbers
           where j % 2 == 0
           select j;