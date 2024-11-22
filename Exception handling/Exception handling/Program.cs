using System.Numerics;

int nums1 = 0;
int nums2 = 0;
int nums = nums1 + nums2;

try
{
        Console.Write("Write a number: ");
        nums1 = int.Parse(Console.ReadLine());

        Console.Write("Write a number: ");
        nums2 = int.Parse(Console.ReadLine());
}
catch (FormatException e)
{
    Console.WriteLine("You can write only numbers");
}
finally
{
    Console.WriteLine("Thanks for using");
}


int total = numbs(nums);

Console.WriteLine(total);

Console.ReadKey();

static int numbs(params int[]  nums) // the params keyword is used to a method receive a variable number of arguments
    // but it only can be used in methods that have the type and return something
{
    int total = 0;
    foreach (int prices in nums)
    {
        
        total += prices;
    }
    return total;
}