using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterLights.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "5414543541541534215878896454621321";
            int answer;
            Solution solutionObject = new Solution(200000);//should be 200000

            answer = solutionObject.solutionMethod(S);
            Console.WriteLine(answer);
            Console.ReadLine();

            /*
            //Testing reverse method:
            char[] characterArray = new char[10];
            string numbers = "0123456789";

            characterArray = numbers.ToCharArray();
            Console.WriteLine("Not reversed: ");
            foreach (var item in characterArray)
            {
                Console.Write(item);
            }
            
            Array.Reverse(characterArray);
            Console.WriteLine();
            Console.WriteLine("Reversed: ");
            foreach (var item in characterArray)
            {
                Console.Write(item);
            }

            Console.ReadLine();
            */

            //Console.WriteLine(4 % 2 + " " + 5 % 2);
            //Console.ReadLine();

        }
    }
}
