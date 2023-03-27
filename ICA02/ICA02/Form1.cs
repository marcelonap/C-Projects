//***********************************************************************************
//Program: ICA02
//Description: Displays order of event listeners for a form app
//Date: Jan. 23/2023
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

namespace ICA02
{
    public partial class Form1 : Form
    {
        //Default Constructor
        public Form1()
        {
            InitializeComponent();
            // Console write text when constructor event occurs
           Console.WriteLine("Constructor event");
        }
        //Load event listener
        private void Form1_Load(object sender, EventArgs e)
        {   
            // Console write text when Load event occurs
          Console.WriteLine("Form Load event");
        }
        //Closed event listener
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
             // Console write text when Closed event occurs
          Console.WriteLine("Form Closed event");
        }
        //Paint event listener
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
             // Console write text when Paint event occurs
          Console.WriteLine("Form Paint event");
        }
        //Closing event listener
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
             // Console write text when Closing event occurs
          Console.WriteLine("Form Closing event");
        }
        //Shown event listener
        private void Form1_Shown(object sender, EventArgs e)
        {
             // Console write text when Shown event occurs
          Console.WriteLine("Form Shown event");
        }
        //Deactivated event listener
        private void Form1_Deactivate(object sender, EventArgs e)
        {
             // Console write text when Deactivated event occurs
          Console.WriteLine("Form Deactivate event");
        }
        //Activated event listener
        private void Form1_Activated(object sender, EventArgs e)
        {
             // Console write text when Activated event occurs
          Console.WriteLine("Form Activated event");
        }
    }
}
