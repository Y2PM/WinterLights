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

        private static List<char[]> digitScramblerMethod(List<char[]> elements)//Scramble the elements and return results.
        {
            List<char[]> scrambled = new List<char[]>();
            //Scramble here, add to list, return.

            return scrambled;
        }

        private static List<char[]> elementsRangeSelector(char[] inputArray, int range)//This method should take a number representing a number of elements and an array, then return indexes for all elements that span the given range.
        {
            List<char[]> resultsList = new List<char[]>();

            for (int i = 0; i < inputArray.Length - range + 1; i++)
            {
                char[] aResult = new char[range];
                Array.Copy(inputArray, i, aResult, 0, range);
                resultsList.Add(aResult);
            }

            return resultsList;
        }

        //Even check symmetry method:
        private static bool EvenSymmetryCheck(char[] characterArray)//For even number of elements only.
        {//*****************************Make good for odds too*************************************** 
            int Length = characterArray.Length;
            if (characterArray.Length % 2 != 0)//if not even number of elements.
            {
                return false;
            }

            int EndIndex = Length - 1;
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
            char[] characterArrayReversed = new char[Length];// probably not required.
            characterArray = S.ToCharArray();
            int effectiveLength = characterArray.Length;
            int numberOfWays = effectiveLength;

            //Create a reversed version:
            characterArrayReversed = characterArray.Reverse().ToArray();

            //Array.Reverse(characterArray);//stack and heap problem was here.
            //characterArrayReversed = characterArray;
            //Array.Reverse(characterArray);

            if (effectiveLength < 2)
            {
                return 1;
            }



            //If even number of elements (and Length > 1):*****************************Make good for odds too***************************************
            if (effectiveLength % 2 == 0)
            {
                int j1 = 0;
                int[] evens = new int[effectiveLength / 2];
                for (int j = 0; j < effectiveLength; j++)//Get even numbers between length and 0.
                {
                    if (j % 2 == 0)//Is this a problem with 0?... Nope, 0 is even.
                    {
                        evens[j1] = j;
                        j1++;
                    }

                }
                //Add two to every element in the array to get rid of 0:
                for (int i = 0; i < evens.Length; i++)
                {
                    evens[i] = evens[i] + 2;
                }


                foreach (var item1 in evens)
                {
                    //Use elementsRangeSelector method around here.
                    List<char[]> elements = elementsRangeSelector(characterArray, item1);

                    //Around here I need to make and use a digit scrambler method on the results in elements to put in the loop.

                    foreach (var item in elements)
                    {
                        if (EvenSymmetryCheck(item))//Give this a different portion of the array starting from longest going to smallest.
                        {
                            numberOfWays++;
                        }
                    }
                }
            }

            //If odd number of elements:*************************do odd things
            if (effectiveLength % 2 == 1)
            {

            }

            return numberOfWays; //Here should be number of segments victor can buy modulo (%) 1000000007.
        }


    }
}
