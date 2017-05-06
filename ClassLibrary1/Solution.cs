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

        private static List<char[]> elementsRangeSelector(char[] inputArray, int range)//This method should take a number representing a number of elements and an array, then return indexes for all elements that span the given range.
        {
            List<char[]> resultsList = new List<char[]>();
            if (range == 1)
            {//hello? :D
                return resultsList;
            }


            for (int i = 0; i < inputArray.Length - range + 1; i++)
            {
                char[] aResult = new char[range];
                Array.Copy(inputArray, i, aResult, 0, range);
                resultsList.Add(aResult);
            }

            return resultsList;
        }

        //Even check symmetry method:
        private static bool EvenSymmetryCheck(char[] characterArray)
        {//made good for odds... done.
            int Length = characterArray.Length;
            //int EndIndex = Length - 1;
            Boolean SymmetricBoolean = true;

            int[] howManyOfEach = new int[10];
            foreach (var item in characterArray)
            {
                int compareChar = Convert.ToInt32(item.ToString());
                for (int i = 0; i < 9; i++)
                {
                    if (compareChar == i)
                    {
                        howManyOfEach[i]++;
                    }
                }
            }
            //Here see if it can be symmetric when rearranged (which makes some other code not required, because if it can be rearranged then there's no need to check its current order):
            //If in the case of an odd length array if more than 1 number appears an odd number of times then false, and if in the case of an even length array if any numbers appears a number of odd times then false.
            int howManyTimesOdd = 0;
            for (int i = 0; i < 10; i++)
            {
                if (howManyOfEach[i] % 2 == 1)
                {
                    howManyTimesOdd++;
                }
            }
            if ((howManyTimesOdd > 1 && Length % 2 == 1) || (howManyTimesOdd > 0 && Length % 2 == 0))
            {
                SymmetricBoolean = false;
            }
            //

            /*
            if (characterArray.Length % 2 != 0)//if odd number of elements.
            {
                decimal two = 2;
                decimal middleIndex = Math.Floor(Length / two);
                int middleIndexInt = Decimal.ToInt32(middleIndex);
                char[] characterArrayToCheckOddSymmetry = new char[EndIndex];

                

                Array.Copy(characterArray, 0, characterArrayToCheckOddSymmetry, 0, middleIndexInt);//Pull out middle number and make new even array.
                Array.Copy(characterArray, middleIndexInt + 1, characterArrayToCheckOddSymmetry, middleIndexInt, middleIndexInt);

                //Check Symmetry of odd reconstructed to be even array.
                for (int i = 0; i < EndIndex / 2; i++)//EndIndex is := length in the odd case.
                {
                    if (characterArrayToCheckOddSymmetry[i] != characterArrayToCheckOddSymmetry[EndIndex - 1])
                    {
                        SymmetricBoolean = false;
                    }
                    EndIndex--;
                }
                //
            }

            if (characterArray.Length % 2 == 0)//If even check symmetry.
            {
                for (int i = 0; i < Length / 2; i++)
                {
                    if (characterArray[i] != characterArray[EndIndex])
                    {
                        SymmetricBoolean = false;
                    }
                    EndIndex--;
                }
            }
            */

            if (SymmetricBoolean)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            //if (effectiveLength % 2 == 0)//need to delete this condition.******************
            //{

            decimal two = 2;
            int j1 = 0;
            decimal arrayLengthOdds = Math.Ceiling(effectiveLength / two);
            int arrayLengthOddsDec = Decimal.ToInt32(arrayLengthOdds);

            int[] odds = new int[arrayLengthOddsDec];
            for (int j = 1; j < effectiveLength + 1; j++)//Get odd numbers between length and 0.
            {
                if (j % 2 == 1)//Is this a problem with 0?... Nope, 0 is even.
                {
                    odds[j1] = j;
                    j1++;
                }

            }

            decimal arrayLengthEvensDec = 0;
            if (effectiveLength % 2 == 1)//if effectiveLength Length is odd.
            {
                arrayLengthEvensDec = arrayLengthOddsDec - 1;
            }
            if (effectiveLength % 2 == 0)//if effectiveLength Length is even.
            {
                arrayLengthEvensDec = arrayLengthOddsDec;
            }
            int arrayLengthEvens = Decimal.ToInt32(arrayLengthEvensDec);

            j1 = 0;
            int[] evens = new int[arrayLengthEvens];
            for (int j = 0; j < arrayLengthEvens + 1; j++)//Get even numbers between length and 0.
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
                //Actually no, I need to use an extra method to test if it can be arranged into something symmetric without actually doing it because there would be too many results otherwise.

                foreach (var item in elements)
                {
                    if (EvenSymmetryCheck(item))//Give this a different portion of the array starting from longest going to smallest.
                    {
                        numberOfWays++;
                    }
                }
            }

            foreach (var item1 in odds)
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
            //}



            return numberOfWays; //Here should be number of segments victor can buy modulo (%) 1000000007.
        }


    }
}
