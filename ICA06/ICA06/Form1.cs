//***********************************************************************************
//Program: FloodFill
//Description: Allow user to generate random red squares on gdi drawer canvas then fill the gaps with a color of choice
//Date: feb. 09/2023
//Author: Marcelo Napoleao  
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using GDIDrawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA06
{

    public partial class Form1 : Form
    {   
        //Declare 2d array and GDIDrawer canvas
        static CDrawer Canvas = new CDrawer();
        static  Color[,] Painted = new Color[80, 60];
        //Record last index of rows and columns of 2d array
        int XLIMIT = Painted.GetLength(0) - 1;
        int YLIMIT = Painted.GetLength(1) - 1;
        Color Boundary = Color.Red;
        Timer myTimer = new Timer(); //Declare timer

        public Form1()
        {
            InitializeComponent();
            Canvas.Scale = 10; //Scale canvas
            myTimer.Enabled = true; //Enable timer
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Generate button click event listener
        private void UI_GEN_BTN_Click(object sender, EventArgs e)
        {
           //Declare random variable
           Random randCoor = new Random();
            //Clear canvas and reset color array 
           for(int i = 0; i <= XLIMIT; i++)
            {
                for(int j = 0; j <= YLIMIT; j++)
                {
                    Painted[i, j] = Color.Black;
                    Canvas.SetBBScaledPixel(i, j, Color.Black);
                }
            }
            //Colour Borders
            for (int i = 0; i <= XLIMIT; i++) { //Iterate through columns (x-coordinate)
                if (i == 0 || i == XLIMIT ) //when at column 0(first column) or length-1(last column)
                {
                    for (int j = 0; j <= YLIMIT; j++) //Iterate through rows (y-coordinate)
                    {
                        //Color the top and bottom borders
                        Painted[i, j] = Boundary;
                        Canvas.SetBBScaledPixel(i,j, Boundary);
                    }
                }
                //Color first and last row of every column and record it in color array
                Painted[i,0]= Boundary;
                Canvas.SetBBScaledPixel(i , 0, Boundary);
                Painted[i,YLIMIT]= Boundary;
                Canvas.SetBBScaledPixel( i, YLIMIT, Boundary);
            }

            //Generate random blocks
            for(int i = 0; i < UI_TRACKBAR.Value; i++)
            {
                //Generate random x and y coordinate
                int y = randCoor.Next(1, YLIMIT);
                int x = randCoor.Next(1,XLIMIT);

                //If random point is already red, retry
                if (Painted[x,y] == Boundary)
                {
                    i--;
                    continue;
                }

                //Paint random point and record it to color array
                Painted[x,y] = Boundary;
                Canvas.SetBBScaledPixel(x, y, Boundary);
            }
        }
        //FillColor button click event listener
        private void UI_FC_BTN_Click(object sender, EventArgs e)
        {
            if (UI_COLOR.ShowDialog() == DialogResult.OK)//Opens color dialog and checks if a color was selected
            {
                UI_TBX.BackColor = UI_COLOR.Color; //Updates Displayed color to the color that has been picked
            }
        }
        //Fill Button Event Listener
        private void UI_FILL_BTN_Click(object sender, EventArgs e)
        {    
            
            myTimer.Start(); //Start timer
            myTimer.Tick += new EventHandler(timer1_tick); //Adds timertick event listener to timer
            Canvas.GetLastMouseLeftClickScaled(out Point c);//flush out last mouse position recorded by canvas window before fill was clicked

        }
        //TimerTick event 
       private void timer1_tick(object sender, EventArgs e)
        {
            //Check if user clicked a valid position on the canvas
            if(Canvas.GetLastMouseLeftClickScaled(out Point coord) && Painted[coord.X,coord.Y] != Boundary)
            {
                FloodFill(coord.X, coord.Y); //Calls recurssive floodFill method with color chosen by user at position clicked by user
                myTimer.Stop(); //Stops timer
            }
        }

        //********************************************************************************************
        //Method: Private void FloodFill(int x, int y, Color FillColor)
        //Purpose: Recursively fills an area up to its bounds with a given Color starting at a given coordinate
        //Parameters:int y - y coordinate 
        // int x - x coordinate
        //Returns: --
        //*********************************************************************************************
        private void FloodFill(int x, int y)
        {
            //If Location to fill is colored with boundary color, return
            if (Painted[x,y] == Boundary)
                    return;
            //If Location to fill is already filled, return
            if (Painted[x, y] == UI_TBX.BackColor)
                return;

            //Fill location
            Painted[x, y] = UI_TBX.BackColor;
            Canvas.SetBBScaledPixel(x, y, UI_TBX.BackColor);

            //Call FloodFill on the surrounding pixels
            FloodFill(x - 1, y);
            FloodFill(x + 1, y);
            FloodFill(x, y - 1);
            FloodFill(x, y + 1);
            
        }
        
        
    }
}
