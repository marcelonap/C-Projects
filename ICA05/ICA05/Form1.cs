
//***********************************************************************************
//Program: Palindrome Checker (ICA05)
//Description: Palindrome Checker forms application
//Date: Feb. 04/2023
//Author: Marcelo Sampaio
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ICA05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //********************************************************************************************
        //Method: static bool IsPalindrome(string input)
        //Purpose: receives a string as a parameter and checks if its a palindrome returning the result as true or false
        //Parameters:string input -- string to be checked
        //Returns: bool -- true if string is a palindrome false if it is not
        //*********************************************************************************************
        static bool IsPalindrome(string input)  
        {
            input = input.ToLower(); //Converts all characters to lowercase to avoid bugs

            //Checks if the input is at its last letter or has no letters left meaning it is a palindrome
            if(input.Length <= 1)
            {
                return true;
            }
            //Checks if first and last character are the same
            if (input[0] == input[input.Length-1])
            {
                return IsPalindrome(input.Substring(1, input.Length-2));  //Recursively checks the next characters calling this method with an input that 
                                                                          //now does not include the characters that were just checked
            }

            return false;  //Returns false if any checks failed and input is not a palindrome
        }

        //Radio buttons checkedChanged consolidated event listener
        private void UI_RADIO_CheckedChanged(object sender, EventArgs e)
        {
                //Updates the visible attribute of the controls on screen based on which radio button is selected
                UI_T_LBL1.Visible = !(UI_FILE_RBTN.Checked);
                UI_T_LBL2.Visible = !(UI_FILE_RBTN.Checked);
                UI_T_TBX2.Visible = !(UI_FILE_RBTN.Checked);
                UI_T_TBX1.Visible = !(UI_FILE_RBTN.Checked);
                UI_F_LBL1.Visible = (UI_FILE_RBTN.Checked);
                UI_F_LBL2.Visible = (UI_FILE_RBTN.Checked);
                UI_F_TBX1.Visible = (UI_FILE_RBTN.Checked);
                UI_F_TBX2.Visible = (UI_FILE_RBTN.Checked);
                UI_LPF_LBL.Visible = (UI_FILE_RBTN.Checked);
                UI_LBX.Visible = (UI_FILE_RBTN.Checked);

        }
        //********************************************************************************************
        //Method: private void CheckPaliFromFile(string filename)
        //Purpose: Check a text file for palindromes and add them to listbox
        //Parameters:string filename -- name of file to be checked
        //Returns: void--
        //*********************************************************************************************
        private void CheckPaliFromFile(string fileName)
        {
            //Declares and starts stopwatch 
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            //Count variable for number or palindromes
            int count = 0;
            UI_LBX.Items.Clear(); // Clears listbox from previous check
            //Stores words from file into an array
            string[] words = File.ReadAllLines(fileName);
            //Iterates through array
            foreach (string word in words)
            {
                if (IsPalindrome(word)) //Check if current word is a palindrome
                {   
                    UI_LBX.Items.Add(word); //Adds palindrome to listbox 
                    count++;                //Increments count variable
                }
            }
            sw.Stop(); //Stops stopwatch
            UI_F_TBX1.Text = count.ToString(); //Displays counted value on the firt textbox
            UI_F_TBX2.Text = string.Format("{0:0}", sw.ElapsedMilliseconds); //Displays properly formated milliseconds elapsed on the second textbox
        }
        //Find palindrome button event listener
        private void UI_FIND_BTN_Click(object sender, EventArgs e)
        {
            //If file radio button is checked, opens file dialog and feeds file naem to checkPaliFromFile method
            if (UI_FILE_RBTN.Checked) {

                if (this.UI_OFD.ShowDialog() == DialogResult.OK) //Opens file dialog and proceeds once a file has been selected
                {
                    CheckPaliFromFile(UI_OFD.FileName); //CheckPaliFromFile method with selected file
                }
                
            }//If test value button is checked, call IsPalindrome method on string is inside the textbox
            else{
                if(UI_T_TBX1.Text.Length > 0)
                UI_T_TBX2.Text = $"{IsPalindrome(UI_T_TBX1.Text)}"; //Updates second textbox with result from palindrome checking
            }

        }
    }
}
