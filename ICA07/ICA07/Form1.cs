//***********************************************************************************
//Program: BinarySearch ICA07
//Description: Program takes names as inputs and displays them in lists by order of entry and alphabetically sorted
//Program allows user to searhc for a name in the sorted list using a binary search method
//Date: feb. 12/2023
//Author: Marcelo Napoleao  
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA07
{
    public partial class Form1 : Form
    {
        //Declares empty list of strings
        List<string> nameList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //********************************************************************************************
        //Method: private int BinarySearch(List<string> list, int min, int max, string name)
        //Purpose: Recursively searches for a string in a sorted list using binary search algorithm
        //Parameters: List<string> list -- list of sorted strings
        // int min -- minimum index for search
        // int max -- maximum index for search
        // string name -- string to be searched for
        //Returns: int -- index of string if found, -1 if not found
        //*********************************************************************************************
        private int BinarySearch(List<string> list, int min, int max, string name)
        {         
                int mid = (max + min) / 2;   //Calculate mid value for search 
                int result = name.CompareTo(list[mid]); //Compare both strings using compareTo method and store result
                //Return index if sring we are searching for was found at current mid index 
                if (result == 0)
                    return mid;
                //If max and min are equal and string was not found, return -1, string is not in the list
                if (max <= min)
                    return -1;
                //If name smaller than current search item, search only the lower half next
                if (result < 0)
                    return BinarySearch(list, min, mid - 1, name);
                //If name greater than current search item, search only upper half
                else
                    return BinarySearch(list, mid + 1, max, name);           
        }
        //Add button event listener
        private void UI_ADD_BTN_Click(object sender, EventArgs e)
        {   
            //If name is already in list, display message and clear list
             if(nameList.Contains(UI_TBX.Text))
            {
                UI_TBX.Text = "";
                MessageBox.Show($"That name is already in the list!", "Sorry!", MessageBoxButtons.OK);
            }
            //Check if textbox is not empty and has a letter at the first character
            if (UI_TBX.Text.Length > 0 && UI_TBX.Text[0] >= 65 )
            {
                nameList.Add(UI_TBX.Text);     //Adds name in texbox to list
                UI_LBX1.Items.Add(UI_TBX.Text);//Adds name to list
                UI_TBX.Text = "";              //Clears text in textbox

                UI_LBX2.Items.Clear();//Clears sorted list display
                nameList.Sort();      //Sorts list
                                      //Repopulates sorted list display with sorted list
                foreach (string item in nameList)
                {
                    UI_LBX2.Items.Add(item);
                }
            }

        }
        //Search button event listener
        private void UI_SRCH_BTN_Click(object sender, EventArgs e)
        {
            //Checks if textbox is not empty and if first character is a letter
            if (UI_TBX.Text.Length > 0 && UI_TBX.Text[0] >= 65) {
                //Stores result of binary search 
                int result = BinarySearch(nameList, 0, nameList.Count - 1, UI_TBX.Text);
                //If name was found, display corresponding message and index
                if (result>=0)
                {
                    MessageBox.Show($"The name {UI_TBX.Text} was found at index: {result} ", "Success!", MessageBoxButtons.OK);
                }
                else//If name was not found, display corresponding message
                {
                    MessageBox.Show($"The name {UI_TBX.Text} was not found!", "Sorry!", MessageBoxButtons.OK);
                }
                UI_TBX.Text = ""; //Clears textbox
            }
        }
    }
}
