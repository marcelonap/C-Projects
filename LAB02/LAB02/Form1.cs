//***********************************************************************************
//Program: PicBender LAB02
//Description: Program allows user to load a picture file and apply filters to it with different
//intensities
//Author: Marcelo Napoleao  
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LAB02
{
    public partial class Form1 : Form
    {
        System.Drawing.Image file; //Declaring variable to hold original image loaded
        int progressBound;
        
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Setting middle lable value
            UI_LBL_MID.Text = $"{UI_TRB.Value} ";
            
        }

        //Consolidated event listener for TrackBar value changed and 
        //Radio buttons checked changed
        private void UI_TRB_ValueChanged(object sender, EventArgs e)
        {
            //Resets progress bar
            UI_PRBAR.Value = 0;
           
            //Checking if tint radio button is checked
            if (UI_RBTN_T.Checked == true)
            {
                //Updating UI for tint filter
                UI_LBL_LEFT.Text = "Red";
                UI_LBL_RIGHT.Text = "Green";
                if (UI_TRB.Value > 50)
                    UI_LBL_MID.Text = $" To green: {UI_TRB.Value - 50} ";
                else
                    UI_LBL_MID.Text = $"To red: {50 - UI_TRB.Value} ";
                if(UI_TRB.Value == 50)
                {
                    UI_LBL_MID.Text = "No change";
                }
            }

            //If any other radio button is checked
            else
            {
                //Updates UI with information for other 3 filters
                UI_LBL_LEFT.Text = "Less";
                UI_LBL_RIGHT.Text = "More";
                UI_LBL_MID.Text = $"{UI_TRB.Value} ";
            }
        }
        //Load Picture button click event listener
        private void UI_BTN_LP_Click(object sender, EventArgs e)
        {   
            //Open file dialog which is filtered to image files
            //and if a file was chosen, store it in file variable and set it as
            //PictureBox image
            if(UI_OFD.ShowDialog() == DialogResult.OK)
            {
                UI_PBOX.Image = System.Drawing.Image.FromFile(UI_OFD.FileName);
                file = System.Drawing.Image.FromFile(UI_OFD.FileName);
                progressBound = file.Width * file.Height;
                UI_PRBAR.Maximum = progressBound;
                UI_BTN_TR.Enabled = true;

            }
            
        }

        //********************************************************************************************
        //Method: private void Contrast(int ratio, Bitmap img)
        //Purpose: Applies Contrast filter to a bitmap image
        //Parameters: int ratio -- rate of intensity for filter to be applied with
        //Bitmap img -- Bitmap object containing the image for the filter to be applied to
        //Returns: --
        //*********************************************************************************************
        private void Contrast(int ratio, Bitmap img)
        {
            
            //Looping through all the pixels in the bitmap
            for (int x = 0; x < img.Width; x++)
            {
               
                
                for (int y = 0; y < img.Height; y++)
                {
                    //Updating progress bar
                  
                        UI_PRBAR.PerformStep();
                    //Storing the color at the current pixel
                    Color Current = img.GetPixel(x, y);
                    
                    //Stornig the R,G and B values at the current pixel
                    int r =Current.R;
                    int g =Current.G;
                    int b =Current.B;

                   
                    //Checking each Color component for whether it is bigger than 128 or
                    //Smaller, and updating component value appropriately. Nothing is done to
                    //Components that are 128 exactly
                    if (Current.R > 128)
                    {
                        r = Current.R + (ratio / 5);
                    }
                    else if (Current.R < 128)
                    {
                       r = Current.R - (ratio / 5);
                    }

                    if (Current.G > 128)
                    {
                        g = Current.G + (ratio / 5);
                    }
                    else if (Current.G < 128)
                    {
                        g = Current.G - (ratio / 5);
                    }

                    if (Current.B > 128)
                    {
                        b = Current.B + (ratio / 5);
                    }
                    else if (Current.B < 128)
                    {
                        b = Current.B - (ratio / 5);
                    }
                        //Making sure no component goes over 255
                        if (b>255) b = 255; if (r>255) r = 255; if (g>255) g = 255;
                        //Making sure no component goes under 0
                        if(b<0) b = 0; if (r < 0)r = 0; if (g<0) g = 0;
                    //Recording updated color and setting pixel to updated color
                    Color newColor = Color.FromArgb( r, g, b);
                    img.SetPixel(x, y, newColor);
                }
            }
        }

        //********************************************************************************************
        //Method: private void BlackWhite(int ratio, Bitmap img)
        //Purpose: Applies BlackWhite filter to a bitmap image
        //Parameters: int ratio -- rate of intensity for filter to be applied with
        //Bitmap img -- Bitmap object containing the image for the filter to be applied to
        //Returns: --
        //*********************************************************************************************
        private void BlackWhite(int ratio, Bitmap img)
        {
            //Looping through all pixels in Bitmap Image
            for (int x = 0; x < img.Width; x++)
            {
                
                for (int y = 0; y < img.Height; y++)
                {
                    //Updating progress bar
                   
                        UI_PRBAR.PerformStep();
                    //Recording current color at pixel
                    Color current = img.GetPixel(x, y);
                    //Calculatint average of components
                    int avg = ( current.B + current.R + current.G) / 3;  
                    //Reording new Color with filter applied to each component base on average
                    //that was calculated
                    Color newColor = Color.FromArgb(current.R + (avg - current.R) * ratio / 100,
                                                    current.G + (avg - current.G) * ratio / 100,
                                                    current.B + (avg - current.B) * ratio / 100);
                    //Setting current pixel to updated color
                    img.SetPixel(x, y, newColor);
                }
            }
        }
        //********************************************************************************************
        //Method: private void Tint(int ratio, Bitmap img)
        //Purpose: Applies Contrast filter to a bitmap image
        //Parameters: int ratio -- rate of intensity for filter to be applied with
        //Bitmap img -- Bitmap object containing the image for the filter to be applied to
        //Returns: --
        //*********************************************************************************************
        private void Tint(int ratio, Bitmap img)
        {
            //Looping through all pixels in Bitmap Image
            for (int x = 0; x < img.Width; x++)
            {
               
                for (int y = 0; y < img.Height; y++)
                {
                    //Updating progress bar
                   
                        UI_PRBAR.PerformStep();
                    //Recording current color at pixel
                    Color current = img.GetPixel(x, y);
                    
                    //Checking position of trackbar to apply filter accordingly
                    if (UI_TRB.Value < 50)
                    {
                        //Applying filter to Red component
                        int r = current.R + (50 - UI_TRB.Value);
                        if (r > 255) r = 255;
                        Color newColor = Color.FromArgb(r, current.G, current.B);           
                        img.SetPixel(x, y, newColor);
                    }

                    if(UI_TRB.Value > 50)
                    {
                        //Applying filter to green component
                        int g = current.G + ( UI_TRB.Value -50);
                        if (g > 255) g = 255;
                        Color newColor = Color.FromArgb(current.R, g, current.B);
                        img.SetPixel(x, y, newColor);
                    }

                }
            }

            

        }
        //********************************************************************************************
        //Method: private void Noise(int ratio, Bitmap img)
        //Purpose: Applies Contrast filter to a bitmap image
        //Parameters: int ratio -- rate of intensity for filter to be applied with
        //Bitmap img -- Bitmap object containing the image for the filter to be applied to
        //Returns: --
        //*********************************************************************************************
        private void Noise(int ratio, Bitmap img)
        {
            //Initializing random variable
            Random rand = new Random(); 
            //Iterating through every pixel in Bitmap Image
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    //Updating progress bar
                  
                        UI_PRBAR.PerformStep();

                    Color current = img.GetPixel(x, y); //Recording current color
                    //Recording updated color components with noise filtering
                    int r = current.R + (rand.Next((ratio+ 1) * 2) ); 
                    int g = current.G + (rand.Next((ratio + 1) * 2));
                    int b = current.B + (rand.Next((ratio + 1) * 2));
                    //Making sure values don't exceed 255 limit
                    if (b > 255) b = 255; if (r > 255) r = 255; if (g > 255) g = 255;
                    //Setting Pixels to updated color with filter applied
                    Color newColor = Color.FromArgb(r, g, b);
                    img.SetPixel(x, y, newColor);
                }
            }

        }
        //Transform button Event listener
        private void UI_BTN_TR_Click(object sender, EventArgs e)
        {
             //Checking if picture box contains an image
            if (UI_PBOX.Image != null)
            {
                //Storing loaded image as a Bitmap Object
                Bitmap bm = new Bitmap(file);
                //Checking for which filtering is checked and applying filter
                if (UI_RBTN_C.Checked == true)
                {
                    Contrast(UI_TRB.Value, bm);
                    UI_PBOX.Image = bm;                                      
                }

                if(UI_RBTN_BW.Checked == true)
                {
                    BlackWhite(UI_TRB.Value, bm);
                    UI_PBOX.Image = bm;                    
                }

                if (UI_RBTN_T.Checked == true)
                {
                    Tint(UI_TRB.Value, bm);
                    UI_PBOX.Image = bm;
                }

                if (UI_RBTN_N.Checked == true)
                {
                    Noise(UI_TRB.Value, bm);
                    UI_PBOX.Image = bm;              
                }  
            }
        }

    }
}
