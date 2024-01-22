using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string Name = "John";
            int age;
            // Initiation of variables
            age = 16;
            Console.WriteLine("There was a boy called" + Name);
            Console.WriteLine(Name + "was " + age + "of age");
            Console.WriteLine(Name + "realy never liked his name");
            
            // changing values of variables.
            age = 18;
            Name = "Tom";
            Console.WriteLine("Ar age " + age + "he changed his name to" + Name);

            // to freeze the console
            Console.ReadLine();

        }
    }
}
