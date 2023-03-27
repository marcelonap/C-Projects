//***********************************************************************************
//Program: Line Drawing (ICA10)
//Description: Application that draws lines from 2 clicks and can change colors randomly
//Date: Mar. 13/03
//Author: Marcelo Sampaio
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
namespace ICA10
{
    public partial class Form1 : Form
    {
        //Creating canvas
        static CDrawer Canvas = new CDrawer(800, 800, false);
        //Declaring struct anD startPointVariable
        eState state = new eState();
        Point start;
        //Declaring randomizer
        Random r = new Random();
        //Dedlaring lists of lines
        static List <SLine> lines;
        static List <SLine> Modlines;      
        private enum eState { Idle, Armed }; //Defining Enum
        //********************************************************************************************
        //Struct: SLine
        //Purpose: Store a line's start and end point, its color and thicness.
        //Member variables:  public Point start;  public Point end;      public Color color;     public byte thickness;
        //Constructor: SLine(Point,Point,Color,byte) -- assigns paramaters to member variables
        //*********************************************************************************************
        public struct SLine
        {
           public Point start;
           public Point end;
           public Color color;
           public byte thickness;
            public  SLine(Point startp, Point endp, Color col, byte thick)
            {         
                start = startp;
                end = endp;
                color = col;
                thickness = thick;
            }
        }
        public Form1()
        {
            InitializeComponent();
            //Initializing lists, flag variable and enabling timer
            lines = new List<SLine>();
            Modlines= new List<SLine>();
            UI_TIMER.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Opening canvas, Setting state and lable.
            Canvas.Render();
            state = eState.Idle;
            UI_LBL.Text = state.ToString();
        }
        //********************************************************************************************
        //Method: static void Render(SLine line)
        //Purpose: Renders a Line to the canvas from an SLine struct passed into it as an argument
        //Parameters: SLine line -- SLine Struct to be displayed
        //Returns: --
        //*********************************************************************************************
        static void Render(SLine line)
        {   
            //Adding line to canvas 
            Canvas.AddLine(line.start.X, line.start.Y, line.end.X, line.end.Y, line.color, line.thickness);
            //Re-rendering canvas
            Canvas.Render();
        }
        //********************************************************************************************
        //Method: static void Render()
        //Purpose: Renders Lines to the canvas from a list of SLines
        //Parameters: --
        //Returns: --
        //*********************************************************************************************
        static void Render()
        {
            //Clearing canvas
            Canvas.Clear();
            Canvas.Render();
            //Redraw all lines with modifies attributes
            foreach (SLine line in Modlines)
            {
                Render(line);
            }
        }
        //Timer tick Event Listener
        private void UI_TIMER_Tick(object sender, EventArgs e)
        {   //Declaring point placeholders
            Point clicked;
            Point garbage;
            //Checking if a left click occured and storing it's coordinates
            if(Canvas.GetLastMouseLeftClick(out clicked))
            {   //Checking if state is idle
                if (state == eState.Idle)
                {    
                    start = clicked;     //Recording starting point
                    state = eState.Armed;//Updating state
                }
                else //If state is not idle
                {   //Storing current line to be drawn and added to list                
                    SLine currLine = new SLine(start, clicked, Color.Red, 5);
                    lines.Add(currLine);  //Adding line to list of lines
                    Render(currLine);     //Rendering current line
                    state = eState.Idle;  //Updating state
                }               
                UI_LBL.Text = state.ToString();//Updating UI
            }
            //Checking if a right click occured regardless of coordinates
            if(Canvas.GetLastMouseRightClick(out garbage))
            {   //Clearing list of modified lines
                Modlines.Clear();
                //Iterating through list of stored lines
                foreach (SLine line in lines)
                {   //Adding a modified line to list of modified lines                
                    Modlines.Add(new SLine(line.start, line.end, RandColor.GetColor() , (byte)r.Next(1, 16)));
                }
                Render();  //Rendering list of modified lines         
            }
        }
        //Button event listener
        private void UI_BTN_Click(object sender, EventArgs e)
        { //Clearing canvas and lists
            Canvas.Clear();
            Canvas.Render();
            Modlines.Clear();
            lines.Clear();  
        }
    }
}
