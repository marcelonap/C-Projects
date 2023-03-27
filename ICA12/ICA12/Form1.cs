
//***********************************************************************************
//Program: String Bender (ICA12)
//Description: Application that allows user to modify a string using different methods
//Date: Mar. 15/03
//Author: Marcelo Sampaio
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ICA12
{
    public partial class Form1 : Form
    {
        //Declaring delegate and setting it to null
        delegate string delFunc(string input);
        delFunc myDel = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Consolidated evend listener for radio button changes and textbox changes
        private void UI_RADIO_CheckedChanged(object sender, EventArgs e)
        {
            update();
            
        }
        //********************************************************************************************
        //Method: private void update()
        //Purpose: Updates delegate with appropriate function then calls delegate function on input string 
        //displaying output on output box
        //Parameters: --
        //Returns: --
        //*********************************************************************************************
        private void update()
        {   //Properly assigning function to delegate
            if (UI_RBTN_LOWER.Checked == true)
            {
                myDel = new delFunc(Lower);
            }
            if (UI_RBTN_FLIP.Checked == true)
            {
                myDel = new delFunc(Flip);
            }
            if (UI_RADIO.Checked == true)
            {
                myDel = new delFunc(Upper);
            }
            //Checking if delegate is not null then calling it on input string displaying it on output box
            if (myDel != null)
                UI_TBX_OUT.Text = myDel(UI_TBX_IN.Text);
        }
        //********************************************************************************************
        //Method: private string Lower(string input)
        //Purpose: returns the lower case representation of the string inputed
        //Parameters: string input -- input string
        //Returns: string output -- converted string
        //*********************************************************************************************
        private string Lower(string input)
        {
            return input.ToLower();
        }

        //********************************************************************************************
        //Method: private string Upper(string input)
        //Purpose: returns the upper case representation of the string inputed
        //Parameters: string input -- input string
        //Returns: string output -- converted string
        //*********************************************************************************************
        private string Upper(string input)
        {
            return input.ToUpper();
        }
        //********************************************************************************************
        //Method: private string Flip(string input)
        //Purpose: returns the flipped case representation of the string inputed
        //Parameters: string input -- input string
        //Returns: string output -- converted string
        //*********************************************************************************************
        private string Flip(string input)
        {   //Variable to store converted string
            string output ="";
            //Iterating through string and convertin each character appropriately
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    output += char.ToLower(c);
                }
                else
                {
                    output += char.ToUpper(c);
                }
            }

            return output;
        }
    }
}
