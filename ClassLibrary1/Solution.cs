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

            //Check for symmetry

            //If even number of elements:
            if (Length % 2 == 0)
            {
                foreach (var item in characterArray)//Start comparing the elements starting with the biggest segment then going to the smallest. 
                {
                    
                }
            }

            //If odd number of elements:
            if (Length % 2 == 1)
            {
                for (int i = 0; i < length; i++)
                {

                }
            }

            return numberOfWays % 1000000007; //Here should be number of segments victor can buy modulo 1000000007.
        }


    }
}
