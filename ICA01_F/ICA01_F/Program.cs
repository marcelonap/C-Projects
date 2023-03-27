//***********************************************************************************
//Program: ICA01
//Description: Allows user to generate and search through an array of integers
//Date: Jan. 16/2023
//Author: Marcelo Sampaio
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ICA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int UPPERBOUND = 100; // Upper bound for integers
            const int LOWERBOUND = 10;  // Lower bound for integers
            int[] array;                // Array of Integers
            string selection;           // Empty string used later to test (Y/N) input from user
            string search = " \nEnter Value to be searched (10-20): ";                  //Search in array prompt
            string message = "\nDo you want to search for another value? (Y/N, y/n) : ";//New search prompt
            string prompt = "\nInput the size of the array to generate  (10-100):  ";   //First prompt

            // Input the size of the array that is going to be generated
            GetValue(prompt, LOWERBOUND, UPPERBOUND, out int size);
            // Input the range for the values in the array
            GetRange(out int LRange, out int URange);
            // Generate array using previous inputs and store it in our pre-declared array
            array = GenerateArray(size, LRange, URange);
            // Display the generated array 
            DisplayArray(array);

            //Repeat while user chooses to keep searching for different values in the array by pressing Y or y
            do
            {
                // Input the value to be searched in the array
                GetValue(search, LRange, URange, out int number);
                // Store the number of occurences of the number inputed
                int occurences = CountOccurences(array, number);

                // If there are more than one occurences, display the appropriate message
                if (occurences >= 1)
                {
                    Console.WriteLine("\nNumber of Occurences of " + number + " is " + occurences);
                }
                // If there are no occurences, display the appropriate message
                else
                {
                    Console.WriteLine("\n" + number + " not found in array");
                }

                //Repeat until user presses y or Y, breaks out of the loop if user presses n or N, repeats if user inputs anything else.
                do
                {
                    // Prompt user for input
                    Console.Write(message);
                    // Stores user input
                    selection = Console.ReadLine();
                    // Checks for n or N
                    if (selection == "n" || selection == "N")
                        break;
                // Checks for y or Y
                } while (selection != "y" && selection != "Y");

            } while (selection == "y" || selection == "Y");



        }


        //********************************************************************************************
        //Method: static void GetValue(string prompt, int min, int max, out int output)
        //Purpose: Prompts the user for an integer value and checks for range and error
        //Parameters:string prompt - prompt to display to the user
        // int min - minimum value accepted
        // int max - maximum value accepted
        // out int output -- value received from user      
        //*********************************************************************************************
        static void GetValue(string prompt, int min, int max, out int output)
        {
            bool flag = false; // Flag variable to control loop
            output = 0;        // Assigning output in case loop fails to avoid build errors

            // Repeats until a valid input is received
            while (!flag)
            {
                // Prompts user for input
                Console.Write(prompt);
                // Stores user input
                string input = Console.ReadLine();
                // Checks for validity and displays custom error message.
                if (int.TryParse(input, out output))
                {
                    if (output < min)
                    {
                        Console.WriteLine("\n Invalid input, upper range cannot be smaller than lower range, please enter a valid input: ");
                        continue;
                    }
                }
                // Checks input for  range
                if ( output >= min && output <= max)
                {
                    flag = true; // Update control variable
                    break;       // Exits loop
                }                             
                // Prompts the user again if input was invalid
                Console.WriteLine("\n Invalid Input, please enter a valid input: ");
            }

        }


        //********************************************************************************************
        //Method:  static void GetRange(out int LRange, out int URange)
        //Purpose: Prompts the user for a minimum and a maximum value which are stored to out parameters
        //Parameters:out int LRange -- Lowerbound value of the range
        // out int URange -- Upperbound value of the range
        //*********************************************************************************************

        static void GetRange(out int LRange, out int URange)
        {
            // Strings with the prompts for upper and lower inputs
            string LPrompt = "\nEnter the lower limit of the range of values to generate (0-100):  ";
            string UPrompt = "\nEnter the upper limit of the range of values to generate (0-100):  ";

            // Minimum and maximum input bounds
            const int UPPERBOUND = 100;
            const int LOWERBOUND = 0;
            
            // Prompting user for lower reange then prompting user for an upper range that has to be greater than the lower range
            GetValue(LPrompt, LOWERBOUND, UPPERBOUND, out LRange);
            GetValue(UPrompt, LRange, UPPERBOUND, out URange);

        }


        //********************************************************************************************
        //Method: static int[] GenerateArray(int size, int min, int max)
        //Purpose: Generates an array of integers of a given size within a given range
        //Parameters:int size -- size of array 
        // int min - minimum value accepted
        // int max - maximum value accepted
        //Returns: int[] - array generated by the method
        //*********************************************************************************************
        static int[] GenerateArray(int size, int min, int max)
        {
            // Starts off randomizer and declares array of inputed size
            Random random = new Random();
            int[] array = new int[size];
            // Stores random values within the range given into the array
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }


        //********************************************************************************************
        //Method: static void DisplayArray(int[] array)
        //Purpose: Displays an array of integers
        //Parameters:int[] array - array to be displayed
        //*********************************************************************************************
        static void DisplayArray(int[] array)
        {
            Console.Write("\nThe Generated Values are: ");
            foreach (int item in array)
            {
                Console.Write(item + ", ");
            }
            Console.Write("\n");
        }


        //********************************************************************************************
        //Method: static int CountOccurences(int[] array, int number)
        //Purpose: Counts the number of time a given number appears in a given array
        //Parameters:int [] array -- array of ints to be searched through
        // int number -- value to be searched for in the array
        //Returns: int - number of times the given number occurs in the given array
        //*********************************************************************************************
        static int CountOccurences(int[] array, int number)
        {
            int count = 0; // Count variable
            // Counts the occurences of the number in the array
            foreach (int item in array)
            {
                if (item == number)
                {
                    count++;
                }
            }
            return count;
        }
    }

}



