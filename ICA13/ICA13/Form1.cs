
//***********************************************************************************
//Program: Color This(ICA13)
//Description: Application that allows user to change the color of the form
//Date: Mar. 23/03
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

namespace ICA13
{
    public partial class Form1 : Form
    {
        //Declaring my modeless dialog variable
        myForm dlg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //Initializing my modeless dialog with the info needed
            dlg = new myForm
            {
                colDel = new ColorChange(ColChange),
                back = Color.FromArgb((int)(Opacity * 100), BackColor.R, BackColor.G, BackColor.B)
            };
        }
        //********************************************************************************************
        //Method: static void ColChange(Color col)
        //Purpose: Callback method for delegate in modelessdialog that updates background color of form
        //Parameters: Color col -- new color for background color
        //Returns: --
        //*********************************************************************************************
        void ColChange(Color col)
        {   //Recording only RGB components into a new color for BackColor
            Color newColor = Color.FromArgb(col.R, col.G, col.B);
            BackColor = newColor; //Assinging new BackColor
            Opacity = col.A/100.0;//Assigning new opacity
        }
        private void Form1_Click(object sender, EventArgs e)
        {   //Showing dialog
            dlg.Show(); 
         }
    }
}
