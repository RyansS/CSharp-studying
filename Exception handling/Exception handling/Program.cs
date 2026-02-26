using System.Numerics;

int nums1 = 0;
int nums2 = 0;
int nums = nums1 + nums2;

try // the try is the block of code that indicates the possible problem
{
        Console.Write("Write a number: ");
        nums1 = int.Parse(Console.ReadLine());

        Console.Write("Write a number: ");
        nums2 = int.Parse(Console.ReadLine());
}
catch (FormatException e) // the catch takes the kind of exception and do something
//there are different options of exceptions
{
    Console.WriteLine("You can write only numbers");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("U can't divide by zero");
}



int total = calc(nums1, nums2, nums);

Console.WriteLine(total);

Console.ReadKey();

static int calc(int nums1, int nums2, int nums) 

{
    nums = nums1 + nums2;

    return nums;
}