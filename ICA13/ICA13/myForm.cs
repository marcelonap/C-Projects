
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
{   //Declaring Delegate type
    public delegate void ColorChange(Color col);
    public partial class myForm : Form
    {   //Declaring delegate variable    
        public ColorChange colDel = null;
        public myForm()
        {
            InitializeComponent();
        }
        //BackGround color property
        public Color back
        {
            get//Getter
            {
                return Color.FromArgb( UI_Tbar_A.Value,UI_Tbar_R.Value, UI_Tbar_G.Value, UI_Tbar_B.Value);
            }
            set {//Setter
                UI_Tbar_R.Value = value.R;
                UI_Tbar_G.Value = value.G;
                UI_Tbar_B.Value = value.B;
                UI_Tbar_A.Value = value.A;
            }
        }
        private void ModelessDialog_Load(object sender, EventArgs e)
        {
           
        }
        //Consolidated Event listener for trackbar changes
        private void UI_Tbar_R_ValueChanged(object sender, EventArgs e)
        {   //Calling callback method
            colDel(back);
        }
        
        private void myForm_FormClosing(object sender, FormClosingEventArgs e)
        {   //Cancelling close event
            e.Cancel = true;
            //Hiding Form
            this.Hide();
           
        }
    }
}
