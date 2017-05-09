using ClassLibrary1;
using System;
using System.Numerics;

namespace WinterLights.Project
{
    class Program
    {
        static void Main(string[] args)
        {

            String continueQuestion = "Y";
            while (continueQuestion.ToUpper() == "Y" || continueQuestion.ToUpper() == "YES")
            {

                Console.Write("S = ");
                string S = Console.ReadLine();
                BigInteger S1 = new BigInteger();
                if (BigInteger.TryParse(S, out S1))
                {

                    int answer;
                    Solution solutionObject = new Solution(200000);//should be 200000

                    answer = solutionObject.solutionMethod(S);
                    Console.WriteLine(answer);
                    Console.WriteLine("Continue? Yes or No ");
                    continueQuestion = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Input a number");
                }

            }


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
