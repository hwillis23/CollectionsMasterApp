using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
           
            
            //Create an integer array of size 50- DONE 
            int[] fifty = new int[50];

            Populater(fifty);

            //Print the first number of the array-DONE 
            Console.WriteLine(fifty[0]);

            //Print the last number of the array-DONE  
            Console.WriteLine(fifty[fifty.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists-DONE 
            NumberPrinter(fifty);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.DONE >>>>>>>>>>>>
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(fifty);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers-DONE
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(fifty);
            

            Console.WriteLine("-------------------");

            //Sort the array in order (SMALLEST TO LGEST #) now-DONE 
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(fifty);
            foreach (int i in fifty)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion


            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List-DONE
            var fiftyList = new List<int>();
            

            //Print the capacity of the list to the console-DONE 

            Console.WriteLine($"Capacity:{fiftyList.Count}");


            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this -DONE
            // Go to POPULATOR LIST METHOD scroll down 
            Populater(fiftyList); //call the method
            NumberPrinter(fiftyList); //call the method to run the numbers 


            //Print the new capacity      -DONE                

            Console.WriteLine($"New Capacity:{fiftyList.Capacity}");
            

           Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            
            int userNumber;
            bool numberType;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");     ///DONE
                numberType = int.TryParse(Console.ReadLine(), out userNumber);

            } while (numberType == false);
            NumberChecker(fiftyList, userNumber);                                                ///DONE


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(fiftyList);                          ///DONE

            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results

            Console.WriteLine("Evens Only!!");  //////////////////////////////////////////////////////DONE
            OddKiller(fiftyList);

            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            fiftyList.Sort();
            NumberPrinter(fiftyList);                   ////////DONE 
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var convertArray = fiftyList.ToArray();

            //Clear the list

            fiftyList.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)  ///DONE
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }

            foreach (int threes in numbers) 
            {
                Console.WriteLine(threes); 
            }
        }

        private static void OddKiller(List<int> numberList)                                  ////DONE
        {
            for (int i = numberList.Count - 1; i >=0; i--)
            { 
                if (numberList[i] % 2 != 0)
                { 
                    numberList.Remove(numberList[i]);
                           // or this way --  var evens = numberList.Where x => x % 2 != 0); ////////
                }
            }
            NumberPrinter(numberList);

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)  ///DONE
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Your number is listed.");
            }
            else
            {
                Console.WriteLine($"The number is not listed.");
            }

        }

        private static void Populater(List<int> numberList) ///DONE
        {

            for (int i = 0; i <= 50; i++)
            {
                Random rng = new Random();    //given>>>>>
                int ranNum = rng.Next(0,50);
                numberList.Add(ranNum);

            }
     
        }
        //Create a method to populate the number array with 50 random numbers that are between 0 and 50-DONE
        private static void Populater(int[] numbers)  ///DONE
        {
            Random rng = new Random(); //given
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0,50);

            }

            foreach (int rand in numbers)
                {

                Console.WriteLine(rand);
               
                 }

        }        

        private static void ReverseArray(int[] array)  ////DONE 
        {
            var reverse = new int[array.Length];
            var counter = 0;

            for (int i = array.Length-1; i >= 0; i--)
            {
                reverse[counter] = array[i];
                counter++;
            }

            NumberPrinter(reverse);
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
