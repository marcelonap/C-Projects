using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ICA14
{
    public partial class Form1 : Form
    {
        Thread Thread1 = null;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        List<string> lines;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        static bool IsPalindrome(string input)
        {
            //input = input.ToLower(); //Converts all characters to lowercase to avoid bugs

            //Checks if the input is at its last letter or has no letters left meaning it is a palindrome
            if (input.Length <= 1)
            {
                return true;
            }
            //Checks if first and last character are the same
            if (input[0] == input[input.Length - 1])
            {
                return IsPalindrome(input.Substring(1, input.Length - 2));  //Recursively checks the next characters calling this method with an input that 
                                                                            //now does not include the characters that were just checked
            }

            return false;  //Returns false if any checks failed and input is not a palindrome
        }

        private void UI_St_Btn_Click(object sender, EventArgs e)
        {
            if (UI_St_Tbx.Text != "") {
                string test = UI_St_Tbx.Text;

                if (IsPalindrome(test))
                {
                    UI_St_Tbx.Text = $" \'{test}\' is a Palindrome!";

                }
                else
                {
                    UI_St_Tbx.Text = $" \'{test}\' is not a Palindrome!";
                }
            }
        }

        private void UI_Lf_Btn_Click(object sender, EventArgs e)
        {
            if (this.UI_Ofd.ShowDialog() == DialogResult.OK) //Opens file dialog and proceeds once a file has been selected
            {
                UI_Find_Btn.Enabled = true;
                UI_Result_Tbx.Text = $"Loaded {File.ReadAllLines(UI_Ofd.FileName).Length} words!";
                lines = new List<string>( File.ReadAllLines(UI_Ofd.FileName));

            }
        }

        //********************************************************************************************
        //Method: private void CheckPaliFromFile(string filename)
        //Purpose: Check a text file for palindromes and add them to listbox
        //Parameters:string filename -- name of file to be checked
        //Returns: void--
        //*********************************************************************************************
        public void CheckPaliFromFile()
        {
            //Declares and starts stopwatch 
          
            sw.Start();
            //Count variable for number or palindromes
            int count = 0;
            UI_Result_Tbx.Text = ""; // Clears listbox from previous check
            //Stores words from file into an array
         
            //Iterates through array
            foreach (string word in lines)
            {
                if (IsPalindrome(word)) //Check if current word is a palindrome
                {
                    UI_Result_Tbx.Text += $"{word}, "; //Adds palindrome to listbox 
                    count++;                //Increments count variable               
                }
            }
            sw.Stop(); //Stops stopwatch
            UI_Result_Tbx.Text += $"---- Found {count} palindromes in {sw.ElapsedMilliseconds}ms!";
            /*UI_F_TBX1.Text = count.ToString(); //Displays counted value on the firt textbox
            UI_F_TBX2.Text = string.Format("{0:0}", sw.ElapsedMilliseconds); //Displays properly formated milliseconds elapsed on the second textbox*/
        }

        private void UI_Find_Btn_Click(object sender, EventArgs e)
        {   
            //CheckPaliFromFile(UI_Ofd.FileName); //CheckPaliFromFile method with selected file
            Thread1 = new Thread(CheckPaliFromFile);
            Thread1.Start();
        }
    }
}
