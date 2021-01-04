using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Jose_Hernandez_comp212_sec003lab1
{
       class GenericMethodTest
       {
            static void Main(string[] args)
            {
                {//the arrays
                    int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8};
                    string[] stringArray = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

                    // displays the arrays 
                    Console.Write("array of int contains\n");
                    DisplayArray(intArray);
                    Console.Write("array of string\n");
                    DisplayArray(stringArray);

                // first result if for intArray
               int result = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("you found {0}", result + $" in The {Search(intArray, result)} position of the array ");
                searchVoid(intArray, result);
                // second array is for stringArray
                string result2 = Console.ReadLine();
                //Console.WriteLine($"you found {Search(stringArray, result2)}");
                //Search(stringArray, result2);
                searchVoid(stringArray, result2);
                }
            }
         // generic methond that searches the arrays
        public static void searchVoid<T>(T[] dataArray, T searchKey) where T : IComparable<T>
        {
            var notThere = Array.IndexOf(dataArray , searchKey);
            int i = -1;
            if ( notThere != -1 ){
                foreach (var element in dataArray)
                {

                    i++;
                    if ((element.Equals(searchKey)))
                    {
                        Console.Write($"> found : {element} in this position {i} \n");
                        break;
                    }
                    else if (element.Equals(searchKey) == false)
                    {
                        Console.WriteLine("did not find your value in the {0} position  but instead found the value : {1} ", i, element);

                        //throw new System.IndexOutOfRangeException("not in the array ");

                    }

                }
            }
            else
            {
                Console.WriteLine("\n : {0} is not in the array", searchKey); 
            }
        }
        // this is a generic methode. can take both strings and int arrays.
        static void DisplayArray<T>(T[] intputArray)
        { 
                foreach (var element in intputArray)
                {
                    Console.Write($"{element}\n");
                }
        }
       }
}


