using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //print hello world
            Console.WriteLine("Hello World.");

            //take user input and show them
            Console.Write("enter your name: ");
            string name = Console.ReadLine();

            Console.Write("enter your phone no: ");
            double phoneNo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("User Information: ");
            Console.Write("Name: "+name+" ");
            Console.WriteLine("Phone No: "+phoneNo);
            Console.ReadKey();


        }
    }
}
