using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Solution
    {
        int Length = new int();

        public Solution(int length)
        {
            Length = length;
        }

        //Even check symmetry method:
        private static bool EvenSymmetryCheck(char[] characterArray)//For even number of elements only.
        {
            int Length = characterArray.Length;
            if (characterArray.Length % 2 != 0)//if not even number of elements.
            {
                return false;
            }

            int EndIndex = Length;
            for (int i = 0; i < Length / 2; i++)
            {
                if (characterArray[i] != characterArray[EndIndex])
                {
                    return false;
                }
                EndIndex--;
            }

            return true;
        }

        public int solutionMethod(string S)//Symmetry finding method.
        {
            char[] characterArray = new char[Length];
            char[] characterArrayReversed = new char[Length];
            characterArray = S.ToCharArray();
            int numberOfWays = Length;

            //Create a reversed version:
            Array.Reverse(characterArray);
            characterArrayReversed = characterArray;
            Array.Reverse(characterArray);
            //

            if (characterArray.Length < 2)
            {
                return 1;
            }



            //If even number of elements (and Length > 1):
            if (Length % 2 == 0)
            {
                int j1 = 0;
                int[] evens = new int[Length / 2];
                for (int j = 0; j < Length; j++)//Get even numbers between length and 0.
                {
                    if (j % 2 == 0)//Is this a problem with 0?... Nope, 0 is even.
                    {
                        evens[j1] = j;
                        j1++;
                    }
                    //Add two to every element in the array:
                    for (int i = 0; i < evens.Length; i++)
                    {
                        evens[i] = evens[i] + 2;
                    }
                }//done


                if (EvenSymmetryCheck(characterArray))//Give this a different portion of the array starting from longest going to smallest.
                {
                    numberOfWays++;
                }



            }

            //If odd number of elements:
            if (Length % 2 == 1)
            {

            }

            return numberOfWays % 1000000007; //Here should be number of segments victor can buy modulo 1000000007.
        }


    }
}
