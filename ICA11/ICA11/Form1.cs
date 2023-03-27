//***********************************************************************************
//Program: Fontify (ICA11)
//Description: Application that allows user to pick font and color for label control using modal dialogs
//Date: Mar. 14/03
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

namespace ICA11
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
        //Lable click event lisitener
        private void UI_LBL_Click(object sender, EventArgs e)
        {   //Instantiates modal dialog
            ModalDialogForm dialog = new ModalDialogForm();
            //Updates values for txtboxes
            dialog.diaFont = UI_LBL.Font;
            dialog.diaColor = UI_LBL.ForeColor;
            //Checks if ok button was pressed
            if (dialog.ShowDialog() == DialogResult.OK)
            {  //Updates font and color for label control
               UI_LBL.ForeColor = dialog.diaColor; 
               UI_LBL.Font = dialog.diaFont;    
            }
        }
    }
}
