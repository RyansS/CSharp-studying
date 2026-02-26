string[,] names = { { "Ryan", "Luiza", "Isa" }, 
                    { "Macaco", "Silvio Santos", "Mcc rei" },
                    {"Paulo", "Eu", "Ta" } 
                  }; // so, the multidimensional array use a main array and inside of it arrays


Console.WriteLine(names[2, 2]); //the first number will get the array and the second the element

foreach (string documents in names)
{
    Console.WriteLine(documents); //here's the easier one but less flexible
}

for (int i = 0; i < names.GetLength(0); i++ ) // here is a way of show the multidimensional array with for loops
{
    for (int g = 0; g < names.GetLength(1); g++)
    {
        Console.Write(names[i, g] + " ");
    }
    Console.WriteLine();
}

Console.ReadKey();
