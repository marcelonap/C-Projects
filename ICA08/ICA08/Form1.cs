
//***********************************************************************************
//Program: Sorting Methods ICA08
//Description: Program allows user to generate random integers then sort them using 4 different sorting methods
//Date: feb. 26/2023
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

namespace ICA08
{
    public partial class Form1 : Form
    {
        //Declaring lists and stopwatch
        List<int> list;
        List<int> SortedList;
        Stopwatch sw; 
        public Form1()
        {
            InitializeComponent();
            //Initializing lists and stopwatch
            sw = new Stopwatch();
            list = new List<int>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Generate values button event listener
        private void UI_BTN_GEN_Click(object sender, EventArgs e)
        {
            //Declaring variables to store the information about numbers to be generated
            int num;
            int min;
            int max;            
            Random r = new Random();//Initializing randomizer
            //Clearing textboxes
            list.Clear();   
            UI_TBX_GEN.Text = null;
            UI_TBX_SORT.Text = null;
            //Validating user input
            if (int.TryParse(UI_TBX_NUM.Text, out num) && int.TryParse(UI_TBX_MIN.Text, out min) && int.TryParse(UI_TBX_MAX.Text, out max))
            {
                if(num >= 10 && max > min)
                {
                    //Generating random values, populating textbox and lists
                    for(int i = 0; i < num; i++)
                    {
                        int value = r.Next(min, max + 1);
                        list.Add(value);                    
                        UI_TBX_GEN.Text += $"{value} ";
                    }
                }
                else
                {
         //Displaying error message in case Input validation fails
                    MessageBox.Show("Invalid values! Please enter a valid set of values", "Error!", MessageBoxButtons.OK);
                }

            }else
            {
                MessageBox.Show("Invalid values! Please enter a valid set of values", "Error!", MessageBoxButtons.OK);
            }
        }

        //Clear raw button event listener
        private void UI_BTN_CR_Click(object sender, EventArgs e)
        {
            UI_TBX_GEN.Text = null; //Clearing generated values Textbox
        }

        //Re display button event listener
        private void UI_BTN_RD_Click(object sender, EventArgs e)
        {
            //Checking if texbox is empty
            if (UI_TBX_GEN.Text == "")
            {
                //Re displaying values
                foreach (int item in list)
                {
                    UI_TBX_GEN.Text += $"{item} ";
                }
            }
        }

        //********************************************************************************************
        //Method: private void BubbleSort(List<int> list)
        //Purpose: Sorts list using Bubble sort algorithm
        //Parameters: List <int> list -- List to be sorted 
        //Returns: --
        //*********************************************************************************************
        private void BubbleSort(List<int> list)
        {
            int temp; //Variable to hold temporary value
            //Passing through list n-1 times where n is the size of the list
            for(int i = 0; i < list.Count-1; i++)
            {
                //Iterating through list on each pass
                for(int j = 0; j < list.Count-1; j++)
                {
                    //Comparing current and next value
                    if (list[j] > list[j + 1])
                    {
                        //Swapping values if conditions met
                        temp = list[j + 1];
                        list[j+1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        //********************************************************************************************
        //Method: private void InsertionSort(List<int> list)
        //Purpose: Sorts list using Insertion sort algorithm
        //Parameters: List <int> list -- List to be sorted 
        //Returns: --
        //*********************************************************************************************
        private void InsertionSort(List<int> list)
        {   //Variables to hold temporary value and position
            int temp;
            int pos;
            //Iterating through list starting at second position
            for(int i = 1; i < list.Count; i++)
            {

                temp = list[i]; //Storing current value
                pos = i - 1; //Storing previous position
                //while previous position greater than or equal to 0 and current value smaller than value at position
                while(pos >=0 && temp < list[pos])
                {
                    //Shifting smaller value to proper position until it is greater than the one before it
                    //and updating position of item that should be before current item
                    list[pos + 1] = list[pos];
                    pos--;
                }
                //Storing current value at the proper position
                list[pos+1] = temp;
            }
        }

        //********************************************************************************************
        //Method: private void SelectionSort(List <int> list)
        //Purpose: Sorts list using Selection sort algorithm
        //Parameters: List <int> list -- List to be sorted 
        //Returns: --
        //*********************************************************************************************
        private void SelectionSort(List <int> list)
        {
            int temp; //Variable to hold temporary value

            //Iterating through list
            for(int i = 0; i < list.Count-1; i++)
            {
                //Iterating through unsorted part of list
                for(int j = i+1; j<list.Count; j++)
                {   
                    //Swapping values when current value is smaller than value at unsorted part of list
                    if (list[j] < list[i])
                    {
                        temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }               
            }

        }
        //********************************************************************************************
        //Method: private void QuickSort(List<int> list, int min, int max)
        //Purpose: Sorts list using Quick sort algorithm
        //Parameters: List <int> list -- List to be sorted 
        //int min -- minimum boundary
        //int max -- maximum boundary
        //Returns: --
        //*********************************************************************************************
        private void QuickSort(List<int> list, int min, int max)
        {
            //Variables to store pivot value, left and right pointers and temporary value
            int pivot = list[(max + min) / 2];
            int right = max;
            int left = min;
            int temp;
            //Looping while left pointer is less than or the same as right pointer
            do
            {
                //Updating left pointer based on pivot
                while (list[left] < pivot)
                    left++;
                //Updating right pointer based on pivot
                while (pivot < list[right])
                    right--;

                //Checking if left pointer still smaller or equal right pointer
                if (left <= right)
                {
                    //Sorting sides of the list based pointers found by comparing values
                    //on either side to pivot value
                    temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;
                    left++;
                    right--;
                }

            } while (left <= right);

            //Recursively calling the method on smaller splits of the list
            if (min < right)
                QuickSort(list, min, right);

            if(left < max)
                QuickSort(list, left, max);

            return;
        }

        //Sort button event listener
        private void UI_BTN_SORT_Click(object sender, EventArgs e)
        {
            UI_TBX_SORT.Text = null; //Clearing Sort Textbox
          
            sw.Start();//Starting stopwatch

            SortedList =new List<int>( list);
            //Checking which sorting method is selected
            if (UI_RBTN_BBL.Checked == true)
            {
                BubbleSort(SortedList);
            }

            if (UI_RBTN_SEL.Checked == true)
            {
                SelectionSort(SortedList);
            }


            if (UI_RBTN_INS.Checked == true)
            {
                InsertionSort(SortedList);
            }

            if (UI_RBTN_QCK.Checked == true)
            {
                QuickSort(SortedList, 0, SortedList.Count -1);
            }
            
            sw.Stop(); //Stoping stopwatch
            
            //Displaying sorted values and time elapsed in ticks
            UI_TBX_ST.Text = $"{sw.ElapsedTicks}";
            foreach (int item in SortedList)
            {
                UI_TBX_SORT.Text += $"{item} ";
            }
           
            sw.Reset(); //Resetting stopwatch
        }
        //Clear sorted button event listener
        private void UI_BTN_CLR_Click(object sender, EventArgs e)
        {
            //Clearing sorted textbox and time elapsed textbox
            UI_TBX_SORT.Text = null;
            UI_TBX_ST.Text = null;
        }
    }
}

