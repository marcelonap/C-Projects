//***********************************************************************************
//Program: Fontify (ICA11)
//Description: Application that allows user to pick font and color for label control using modal dialogs
//Date: Mar. 14/03
//Author: Marcelo Sampaio
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.CodeDom;
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
    public partial class ModalDialogForm : Form
    {
        //color get/set property
        public Color diaColor
        {
            get
            {   //returns color as a color value              
                return UI_CD.Color;
            }
            set
            { 
                //sets color value for color dialog and displays it on textbox
                UI_CD.Color = value;
                UI_TBX_C.Text = UI_CD.Color.ToString();
            }
        }
        //font get/set property
        public Font diaFont
        {
            get
            {   //returns font as a font value
                return UI_FD.Font;
            }
            set
            {   //sets font value for font dialog and displays it on textbox
                UI_FD.Font = value;
                UI_TBX_F.Text = UI_FD.Font.ToString();
            }
        }

        public ModalDialogForm()
        {
            InitializeComponent();
        }

        private void ModalDialogForm_Load(object sender, EventArgs e)
        {
           
        }
        //ok button event listener
        private void UI_BTN_OK_Click(object sender, EventArgs e)
        {   //Sets dialogresult to ok, exiting dialog with ok result
            DialogResult = DialogResult.OK;
        }
        //Set font button event listener
        private void UI_BTN_SF_Click(object sender, EventArgs e)
        {
            //Checks if ok button was pressed
            if (UI_FD.ShowDialog() == DialogResult.OK)
            {   //Displays selected font on textbox
                diaFont= UI_FD.Font;              
            }
        }
        //set color button event listener
        private void UI_BTN_SC_Click(object sender, EventArgs e)
        {   //Checks if ok button was pressed    
            if (UI_CD.ShowDialog() == DialogResult.OK)
            {   //Displays selected color on textbox
                diaColor = UI_CD.Color;              
            }
        }
    }
}
