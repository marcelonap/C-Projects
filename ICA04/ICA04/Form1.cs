
//***********************************************************************************
//Program: Speed Conversion (ICA04)
//Description: Speed conversion forms aplication
//Date: Jan. 29/2023
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

namespace ICA04
{
    public partial class Form1 : Form
    {
        //Declaring global variables and constants used to store and convert speeds
        const double KMTOM = 3.6;
        const double MPHTOM = 2.237;
        bool kmChecked = true;
        string input = "";
        double num;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //********************************************************************************************
        //Method: private void ConvertSpeed()
        //Purpose: Converts our input number while also checking for input validity and maintaining ui design
        //Parameters: --
        //Returns: --
        //*********************************************************************************************
        private void ConvertSpeed()
        {
            //Storing text contained in textbox
            input = UI_IN_TXB.Text;
           
            
            //Checking for validity of input
            if(!double.TryParse(input, out num) && input != "")
            {
                UI_OUT_TBX.Text = " Please enter a valid input.";
                return;
            }
            //Checking for empty or 0 text on input textbox and maintaining design of the UI
            if (input == "" || num == 0)
            {
                UI_OUT_TBX.Text = "0";
                return;
            }
            //Convertig speed based on which radio button is pressed
            if (kmChecked)
            {
                //Formatting and displaying converted number
                UI_OUT_TBX.Text = string.Format("{0:0.00}", num / KMTOM);
            }
            else
            {
                //Formatting and displaying converted number
                UI_OUT_TBX.Text = string.Format("{0:0.00}", num / MPHTOM);
            }
        }
 
        //Event listener consolidation for checked change on both radio buttons and text changed on input text box
        private void UI_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            //Checks which radio button is pressed then updates the control variable and calls the conversion method
            if (UI_RBTN_KMH.Checked)
            {
                kmChecked = true;
                ConvertSpeed();
            }
            else
            {
                kmChecked = false;
                ConvertSpeed();
            }
        }
    }
}
