//***********************************************************************************
//Program: lAB01 - Money Calculator
//Description: Sorts and displays a monetary value as the different bills and coins used to count it.
//Date: Feb 01/2023
//Author: Marcelo Napoleao Sampaio
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace LAB01
{
    internal class Program
    {
        //Initializing GDIDrawer window
        static CDrawer Canvas = new CDrawer(800,600,false);
        static void Main(string[] args)
        {
            
            string message = "How much do you wish to convert?";                       //Prompt for user value
            string repeat = "\nDo you want to sort another value? (YES/NO, yes/no) : ";//New search prompt
            string selection;  //Empty string to check for user selection

            //Loop that allows user to try mutiple values
            do
            {

                Console.Clear();                    //Clears console at the beginning of each cycle
                Canvas.Clear();                     //Clears canvas at the beginning of each cycle
                Canvas.Render();                    //Renders the newly cleared canvas
                double input = GetValue(message);   //Prompts User for input and stores it
                double rounded = RoundValue(input); //Rounds User's input and stores the rounded value
                Canvas.AddText($"${rounded.ToString("0.00")}", 20, 325, 5 , 200, 100, Color.Yellow); //Adds the rounded value with proper formatting to the Canvas
                Console.WriteLine($"User entry of {input} interpreted and rounded to {rounded.ToString("0.00")}"); //Displays the rounding performed to the console
                DisplayArray(SortMoney(rounded));   //Sorts rounded value and returns an array with the Proper counts for each currency, which is then passed to the display method
                                                    //which displays the amounts counted on the console and draws them on the the GDIDrawer window 
                
                //This loop prompts the user for wether they want to sort a different value or not
                //If input is yes or YES, the program will leave this inner loop, and repeat, if the input is no or NO it will break out of the loop 
                //and allow the outer loop to stop, Any other input will keep this inner loop running until either a yes or no selection is made.
                do
                {
                    // Prompt user for input
                    Console.Write(repeat);
                    // Stores user input
                    selection = Console.ReadLine();
                    // Checks for no or NO
                    if (selection == "no" || selection == "NO")
                        break;
                    // Checks for yes or YES
                } while (selection != "yes" && selection != "YES");

            } while (selection == "yes" || selection == "YES");
        }

        //********************************************************************************************
        //Method:    static double GetValue(string prompt)
        //Purpose: Records a double value form user input and error checking, accepting only numbers or numbers with $ sign
        //Parameters:string prompt - prompt to display to the user
        //Returns: double - value accepted by the method
        //*********************************************************************************************
        static double GetValue(string prompt)
        {
            //Variables for storing and checking
            double value;
            string input;
            //Prompts user for input
            Console.WriteLine(prompt);

            //Records user input and accounts for possible $ sign
            input = Console.ReadLine();
            input = input.Replace('$', ' ');

            //Continously checks user input until a valid input is Given
            if (!double.TryParse(input, out value)) {
                Console.WriteLine("Invalid input! ");
                return GetValue(prompt);              
            }
            //Returns valid double
            return value;
        }

        //********************************************************************************************
        //Method:    static double RoundValue(double num)
        //Purpose: Rounds a double value passed as a parameter to the nearest .05
        //Parameters:double num - double value to be rounde to nearest .05
        //Returns: double - rounded value
        //*********************************************************************************************
        static double RoundValue(double num)
        {
            //returns Rounded value to nearest .05 using mathematical manipulation
            return (Math.Round(num*20)/20);
        }

        //********************************************************************************************
        //Method:    static int[] SortMoney(double num)
        //Purpose: Sorts a monetary value into units of currency used to count it
        //Parameters:double num - double value to be sorted into counted currencies
        //Returns: int[] - returns an array of integers with the respective currency values at the proper locations.
        //*********************************************************************************************
        static int[] SortMoney(double num)
        {

            double amount = num;                //Stores value given into a variable within the scope of the method
            double[] currencies = new double[] {50,20,10,5,2,1,.25,.1,.05};  //Array of Integers with the values of each unit of currency
            int[] amounts = new int[9];         //Empty array of integers to be populated with the counts for each unit of currency

            //Loop that counts the amount for each currency from the total value
            for(int i = 0; i < currencies.Length; i++)
            {
                amounts[i] = (int)(amount/currencies[i]); //Storing amount of units for the current currency unit
                amount = Math.Round(amount % currencies[i], 2); //Updating the value to be counted with however much is left to still be counted
            }
            //Returning array with counts
            return amounts;
      }

        //********************************************************************************************
        //Method:    static void DisplayArray(int[] array)
        //Purpose: Displays the counted
        //Parameters:double num - double value to be sorted into counted currencies
        //Returns: int[] - returns an array of integers with the respective currency values at the proper locations.
        //*********************************************************************************************
        static void DisplayArray(int[] array)
        {
            
            string[] names = new string[] {"Fifty","Twenty", "Ten", "Five", "Toonie", "Loonie", "Quarter", "Dime", "Nickel" };  //Array with names for the currency unit values
            string[] numbers = new string[] { "50", "20", "10", "5", "2", "1", "0.25", "0.10", "0.05" };        //Array with strings containing the numerical representation for currency unit values
            //Array with different colors for the different currencies
            Color[] colors = new Color[] { Color.LightPink, Color.LightGreen, Color.Lavender, Color.LightBlue, Color.LightYellow, Color.Yellow, Color.LightGray, Color.LightGray, Color.LightGray };
            int[] xCor = new int[] { 200, 600 };         //Array with the 2 possible x cooordinates for the drawings as integers
            int yCor = 100;                              //Integer with the y coordinate increment          
            int ycount = 1;                              //Integer with the y coordinate multiplier
            int count = 0;                               //Count variable to keep track of how many items have been drawn 

            //For loop that iterates through the array of integers receives as a parameter
            for (int i = 0; i < array.Length; i++)
            {
                //Displaying Counted amounts to the console
                Console.WriteLine($"{names[i]} x {array[i]}");
                //Check if current position should be drawn to canvas
                if (array[i] > 0)
                {
                    //Check if ycount variable needs to be reset once drawing should be done on the right side of the screen
                    //causing it to start from top to bottom
                    if (count == 5)
                    {
                        ycount = 1;
                    }
                    //Checks if we should draw to left or right side of the screen based on how many shapes have been drawn so far. Under 5 means we're still on the first (left) column
                    if (count <5)
                    {
                        //Check if shape to be drawn should be a rectangle or ellipse based on the index of the array that indicates wether it is a bill or a coin
                        if(i < 4)
                        {
                            Canvas.AddCenteredRectangle(xCor[0], yCor*ycount, 200, 95, colors[i], 2,Color.Gray); //Draws appropriate rectangle using the left x coordinate, the current y coordinate and the respective color
                            
                        }
                        else
                        {
                            Canvas.AddCenteredEllipse(xCor[0], yCor * ycount,95, 95, colors[i], 2, Color.Gray);//Draws appropriate ellipse using the left x coordinate, the current y coordinate and the respective color
                        }
                        Canvas.AddText($"${numbers[i]} x {array[i]}", 15, xCor[0] - 50, (yCor * ycount) - 50, 100, 100, Color.Black); //Draws text inside respective shape containing the numeric representation for the value
                        ycount++; //Updates y coordinate multiplier
                    }
                    else 
                    {
                        //Check if shape to be drawn should be a rectangle or ellipse based on the index of the array that indicates wether it is a bill or a coin
                        if (i < 4)
                        {
                            Canvas.AddCenteredRectangle(xCor[1], yCor * ycount, 200, 95, colors[i], 2, Color.Gray);//Draws appropriate rectangle using the left x coordinate, the current y coordinate and the respective color
                        }
                        else
                        {
                            Canvas.AddCenteredEllipse(xCor[1], yCor * ycount, 95, 95, colors[i], 2, Color.Gray);//Draws appropriate ellipse using the left x coordinate, the current y coordinate and the respective color
                        }
                        Canvas.AddText($"${numbers[i]} x {array[i]}", 15, xCor[1] - 50, (yCor * ycount) - 50, 100, 100, Color.Black);//Draws text inside respective shape containing the numeric representation for the value
                        ycount++; //Updates y coordinate multiplier
                    }
                    
                    count++; //Updates count variable
                }
            }

            //Renders shapes after the process is done
            Canvas.Render();
           
        }
    }
}
