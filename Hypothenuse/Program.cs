
Console.WriteLine("Give me the value of the A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Give me the value of the B: ");
double b = Convert.ToDouble(Console.ReadLine());  //i used the convert inside the double to who will write the number doesn't need to give the decimal part, and i put the value of b, being the console.ReadLine

double c = Math.Sqrt((a * a) + (b * b)); // here, i used the math.sqrt to put them on square root and i didn't need to use the math.pow because i only multiplied the a * a and vice versa

Console.WriteLine("The value of the hypothenuse is: " + Math.Round(c)); // i used the math round to give a aproximately number 

Console.ReadKey();