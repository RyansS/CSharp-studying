using System.Net.Http.Headers;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {       
        List<int> salarys = new List<int>(); // here i created the list that i will use to store the salarys
        string answe = ""; // that's the answer to the terceirizado
        int emplye = 0; //this variable stores how many employees you want to see
        int hours = 0; //this hpw many hour they worked
        int perhour = 0;//this is how much they earn by hour
        int total = 0;// this is the total that they earn
        int display;

        Console.WriteLine("How many employees? "); //here i ask how many employees the user wanna see
        emplye = int.Parse(Console.ReadLine()); //convert the answer

        for (int i = 1; i <= emplye; i++) // according to the number the user got in
        {
            pergu(i, answe); // here i will show the method that asks if the employee is terceirado or no

            display = emp(hours, perhour, total); //it's a variable created to store the method employees

            salarys.Add(display); //the value of the return in the method will be added to the list by the display variable
        }

        foreach (int v in salarys) //now it will show the salaries
        {
            Console.WriteLine("Earns: " + v);
        }
        
        Console.ReadKey();
    }
    static int emp(int hours, int perhour, int total)
    {
        Console.WriteLine("How many hours he worked? ");
        hours = int.Parse(Console.ReadLine());

        Console.WriteLine("How much he earns per hour? ");
        perhour = int.Parse(Console.ReadLine());

        return total = hours * perhour; //this return is the hours times how much the employee earns per hour
    }
    static void pergu(int i, string answe) // here is the method used for ask if it's terceirizado or no
    {
        Console.WriteLine("Employee " + i + "*");
        Console.WriteLine("It's terceirazado? (Y/N): ");
        answe = Console.ReadLine();
        answe = answe.ToUpper();
    }
    
}