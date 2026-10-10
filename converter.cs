using System;

class Program
{
    static void Main()
    {
     Console.Write("enter celsisus");   
     double celsius = double.Parse(Console.ReadLine());
     double fahrenheit = (celsius * 9 / 5) + 32;
     Console.WriteLine("result" + fahrenheit + "f");
    }
}
