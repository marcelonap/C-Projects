//***********************************************************************************
//Program: Timers (ICA03)
//Description: Stopwatch forms application
//Date: Jan. 26/2023
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

namespace ICA03
{
    public partial class Form1 : Form
    {
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); //Initializing stopwatch
        int count; //Count variable used to keep track of split button pressed for each run of the stopwatch
        public Form1()
        {
            InitializeComponent();
            Text = "Timers"; //Setting form title text at the corner to 'Timers'
            sw.Stop();       //Making sure the stopwatch is not running at the program starts
            UI_Timer.Enabled = true; //Enabling the timer
            UI_Timer.Interval = 20;  //Setting tickrate for the timer
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //********************************************************************************************
        //Method: static string DisplayValue()
        //Purpose: Displays our stopwatch time with proper formatting
        //Parameters: --
        //Returns: String with our time properly formatted
        //*********************************************************************************************
        private string DisplayTimer()
        {
            string currTime;  //Declaring empty string
            TimeSpan elapsedTime = sw.Elapsed; //Declaring timespan object with the elapsed time of our stopwatch
            //Formatting the output string and filling the respective places with hours minutes seconds and miliseconds
            currTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds / 10);
            //Returning our stopwatch with the proper format
            return $"({count})  {currTime}";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Displaying our time at the label at every tick of our timer
            UI_SWDisplay.Text =  DisplayTimer();
        }
        //Start stopwatch on click of start button
        private void UI_Btn_Str_Click(object sender, EventArgs e)
        {
            sw.Start();
        }
        //Stop stopwatch on click of stop button
        private void UI_Btn_Stp_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }
        //Reset stopwatch on click of reset button
        private void UI_Btn_Rst_Click(object sender, EventArgs e)
        {
            sw.Reset();
            //Clearing our listbox
            UI_List.Items.Clear();
            //Resetting count variable
            count = 0;
        }
        //Recording time on click of split button
        private void UI_Btn_Spl_Click(object sender, EventArgs e)
        {
            //Checking for duplicates
            if (UI_List.Items.Contains(DisplayTimer()))
                return;
            //Updating count and adding time to our listbox only of there is not duplicates
            count++;
            UI_List.Items.Add( DisplayTimer());
            

        }
    }
}
