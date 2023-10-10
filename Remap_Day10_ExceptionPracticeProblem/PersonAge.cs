using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day10_ExceptionPracticeProblem
{
    internal class PersonAge
    {
        public static void PersonAgeAbility(string Age)
        {
           
            try
            {
                int age = int.Parse(Age);

                if (age >= 1 && age <= 14)
                    Console.WriteLine("Children");
                else if (age > 14 && age <= 24)
                    Console.WriteLine("Youth");
                else if (age > 24 && age <= 64)
                    Console.WriteLine("Adults");
                else if (age > 64)
                    Console.WriteLine("Seniors");
                else
                    throw new CustomAgeException("Invalid Age");
            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (CustomAgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
