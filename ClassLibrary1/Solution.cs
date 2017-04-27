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
        private static bool SymmetryCheck(char[] characterArray, int Length)//For even number of elements only.
        {
            if (characterArray.Length % 2 != 0)//if not even number of elements.
            {
                return false;
            }

            int EndIndex = Length;
            for (int i = 0; i < Length / 2; i++)
            {
                if (i!=EndIndex)
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
                return numberOfWays;
            }



            //If even number of elements:
            if (Length % 2 == 0)
            {


                if (SymmetryCheck(characterArray, Length))
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
