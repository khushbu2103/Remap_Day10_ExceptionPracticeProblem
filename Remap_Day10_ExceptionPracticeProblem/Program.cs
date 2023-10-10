using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day10_ExceptionPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a person's age:");
            string age = Console.ReadLine();
           
            PersonAge.PersonAgeAbility(age);
            Console.ReadLine();
        }
    }
}
