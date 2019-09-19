using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classgroupproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("What is your Age?");
            string inputAge = Console.ReadLine();
            Console.WriteLine("What grade do you expect to get in this class?");
            string inputGrade = Console.ReadLine();
            int inputvalue = int.Parse(inputGrade);



            for (int i = 0; i < 4; i++)
            {

                if (inputvalue >= 90 && inputvalue <= 100)
                {
                    Console.WriteLine("You will recieve an A in the class");
                }
                if (inputvalue >= 80 && inputvalue <= 89)
                {
                    Console.WriteLine("You will recieve an B in the class");
                }
                if (inputvalue >= 69 && inputvalue <= 79)
                {
                    Console.WriteLine("You will recieve an C in the class");
                }
                if (inputvalue >= 49 && inputvalue <= 68)
                {
                    Console.WriteLine("You will recieve an D in the class");
                }
                if (inputvalue < 48)
                {
                    Console.WriteLine("You will recieve an F in the class");
                }

            }

            
            Console.Write(inputName + " " + inputAge + " " + inputGrade + " ");
        }
    }
}
