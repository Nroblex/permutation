using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Permutation , writes combination of words...");

            Permutation.RunPermutaion();

            Console.ReadKey();

        }
    }

    static class Permutation
    {
        static string text1 = "hat";
        static char[] alphabet = "abcdefghijklmnopqrstuvxyzåäö".ToCharArray();
        static char startLetter;
        
        internal static char[] letterArray(int startIndex, char[] letters)
        {
            char[] result = new char[letters.Length];

            int counter = 0;

            result[0] = letters[startIndex];
            for (int n = 0; n<=letters.Length -1; n++)
            {
                if (n != startIndex)
                {
                    result[++counter] = letters[n];
                }
            }


            return result;

        }

        internal static void RunPermutaion()
        {
            char[] startArray = text1.ToCharArray();

            //char[] dd = letterArray(2, startArray);

            var sortList = text1.ToCharArray().OrderBy(p => p.ToString());

            char[] data = (char[])sortList.ToArray();

            //Array.Copy(data, startArray, data.Length);

            startLetter = data[0];
            

            int FakLength = 1;
            for (int n =1; n<=text1.Length; n++)
            {
                FakLength = n * FakLength;
            }

            List<string> combinations = new List<string>();

            for (int n = 0; n<= FakLength; n++)
            {
                int cnt = n + 1;
                string line = "";
                for (int p = 0; p<= data.Length -1; p++)
                {
                    line += data[p].ToString();
                }

                combinations.Add(line);

                data = (char[])data.OrderByDescending(p => p.ToString().StartsWith(startArray[cnt].ToString())).ToArray();


                /*
                //Reorder.
                if (cnt > startArray.Length -1)
                {
                    cnt = 0;
                    data = (char[])data.OrderByDescending(p => p.ToString().StartsWith(startArray[cnt].ToString())).ToArray();
                } else
                {
                    data = (char[])data.OrderByDescending(p => p.ToString().StartsWith(startArray[cnt].ToString())).ToArray();
                }
                */


            }

        }

     
    }
}
