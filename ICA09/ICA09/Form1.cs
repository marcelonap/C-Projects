

//***********************************************************************************
//Program: Sorting Structs (ICA09)
//Description: Application that sorts through as struct of employees
//Date: Mar. 06/03
//Author: Marcelo Sampaio
//Course: CMPE1666
//Class: CNTA02
//***********************************************************************************
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace ICA09
{
    public partial class Form1 : Form
    {
        //Declaring lits of employees
        List<employee> listGiven;
        List<employee> listFile;
        List<employee> SortedList;
        //Storing given values in arrays
        int[] ids = { 28, 53, 12, 18, 8, 2, 19, 57, 62, 34, 23, 14, 48, 35, 55, 22, 26, 15, 7, 9, 32, 43, 41, 51 };
        int[] salaries = { 4500, 2800, 1900, 3100, 7000, 3500, 2200, 2800, 2850, 3150, 4000, 4500, 6000, 7200, 3700, 2100, 2450, 2500, 3250, 3700, 3800, 4200, 4100, 3900 };
        //Declaring lists to store information from files
        List<string> file_ids ;
        List <string> file_salaries;
        //Declaring Stopwatch
        Stopwatch sw;

        //********************************************************************************************
        //Struct: employees
        //Purpose: Store employee_id and salary for employee
        //Member variables: int employee_id, int employee_salary
        //Constructor: employee(int,int) -- assigns paramaters to member variables
        //*********************************************************************************************
        public struct employee
        {
           public int employee_id;
           public int employee_salary;

            public employee(int id, int salary)
            {
                employee_id = id;

                employee_salary = salary;   


            }

        }
        //Form1 constructor
        public Form1()
        {
            InitializeComponent();
            //Initializing lists and stopwatch
            listGiven= new List<employee>();
            listFile = new List<employee>();
            file_ids = new List<string>();
            file_salaries = new List<string>();
            sw = new Stopwatch();

        }
        //Load event
        private void Form1_Load(object sender, EventArgs e)
        {
            //Populating ListGiven with given values from recorded arrays
            for (int i = 0; i < ids.Length; i++)
            {
                listGiven.Add(new employee(ids[i], salaries[i]));
            }
        }
        //Display unordered list button event listener
        private void UI_BTN_DUL_Click(object sender, EventArgs e)
        {
            UI_LBX_UD.Items.Clear();//Clearin list
            //Checking which radio button is pressed
            if (UI_RBTN_PL.Checked == true)
            {     
                //Displaying employee list in listbox
                foreach ( employee item in listGiven)
                {  
                    UI_LBX_UD.Items.Add($"{item.employee_id}: \t {item.employee_salary}");
                }
            }
            else
            {
                //Displaying employee list in listbox
                foreach (employee item in listFile)
                {
                    UI_LBX_UD.Items.Add($"{item.employee_id}: \t {item.employee_salary}");
                }
            }
        }

        //Load File button event listener
        private void UI_BTN_LF_Click(object sender, EventArgs e)
        {      
            //Opening file dialog for employeeID file
                UI_OFD.Title = "EmployeeID";
                if (UI_OFD.ShowDialog() == DialogResult.OK)
                {
                //Storing ids in a list
                    file_ids = new List<string>(File.ReadAllLines(UI_OFD.FileName));
                }

            //Opening file dialog for salaries file
                 UI_OFD.Title = "Salaries";
                if (UI_OFD.ShowDialog() == DialogResult.OK)
                {
                //Storing salaries in a list
                    file_salaries = new List<string>(File.ReadAllLines(UI_OFD.FileName));
                }
            
            //Checking if values from both files were recorded
            if (file_ids.Count != 0 && file_salaries.Count != 0) {
                //Populating listFile from files loaded
                for (int i = 0; i < file_ids.Count; i++)
                {
                    int id;
                    int salary;
                    int.TryParse(file_ids[i], out id);
                    int.TryParse(file_salaries[i], out salary);
                    listFile.Add(new employee(id, salary));
                }
                //Disabling Load File button
                UI_BTN_LF.Enabled = false;
            }

        }
        //Clear unsorted list button event listener
        private void UI_BTN_CUL_Click(object sender, EventArgs e)
        {
            //Clearing lisbox
            UI_LBX_UD.Items.Clear();
        }
        //Clear sorted list button event listener
        private void UI_BTN_CSL_Click(object sender, EventArgs e)
        {
            //Clearing listbox
            UI_LBX_SD.Items.Clear();
        }

        //********************************************************************************************
        //Method: private void SelectionSort(List <employee> list)
        //Purpose:  Sorts list of employees by employee_id Selection sort algorithm
        //Parameters: List <employee> list -- List to be sorted 
        //Returns: --
        //*********************************************************************************************
        private void SelectionSort(List<employee> list)
        {
            employee temp; //Variable to hold temporary value

            //Iterating through list
            for (int i = 0; i < list.Count - 1; i++)
            {
                //Iterating through unsorted part of list
                for (int j = i + 1; j < list.Count; j++)
                {
                    //Swapping values when current value is smaller than value at unsorted part of list
                    if (list[j].employee_id < list[i].employee_id)
                    {
                        temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }

        }

        //********************************************************************************************
        //Method: private void QuickSort(List<employee> list, int min, int max)
        //Purpose: Sorts list of employees by employee_id using Quick sort algorithm
        //Parameters: List <employee> list -- List to be sorted 
        //int min -- minimum boundary
        //int max -- maximum boundary
        //Returns: --
        //*********************************************************************************************
        private void QuickSort(List<employee> list, int min, int max)
        {
            //Variables to store pivot value, left and right pointers and temporary value
            int pivot = list[(max + min) / 2].employee_id;
            int right = max;
            int left = min;
            employee temp;
            //Looping while left pointer is less than or the same as right pointer
            do
            {
                //Updating left pointer based on pivot
                while (list[left].employee_id < pivot)
                    left++;
                //Updating right pointer based on pivot
                while (pivot < list[right].employee_id)
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

            if (left < max)
                QuickSort(list, left, max);

            return;
        }
        //N^2 button event listener
        private void UI_BTN_N2_Click(object sender, EventArgs e)
        {
            //Clearing sorted  listbox
            UI_LBX_SD.Items.Clear();
            //Checking which radio button is pressed
            if (UI_RBTN_FD.Checked == true)
                SortedList = new List<employee>(listFile);
            else
                SortedList = new List<employee>(listGiven);
            
            sw.Start();//Starting stopwatch
           //Sorting list using selectionSort N^2 method
            SelectionSort(SortedList);
            sw.Stop(); //Stoping stopwatch
            //Displaying sorted list
            foreach (employee item in SortedList)
            {
                UI_LBX_SD.Items.Add($"{item.employee_id}: \t {item.employee_salary}");
            }
            

            //Displaying sorted values and time elapsed in ticks
            UI_TBX_TT.Text = $"{sw.ElapsedTicks}";
            //Resetting stopwatch
            sw.Reset();

        }

        private void UI_BTN_QS_Click(object sender, EventArgs e)
        {
            //Clearing sorted  listbox
            UI_LBX_SD.Items.Clear();
            //Checking which radio button is pressed
            if (UI_RBTN_FD.Checked== true)
                SortedList = new List<employee>(listFile);
            else
                SortedList = new List<employee>(listGiven);
            
            sw.Start();//Starting stopwatch
            //Sorting list using quicksort method
            QuickSort(SortedList,0,SortedList.Count-1);
            sw.Stop(); //Stoping stopwatch
                       //Displaying sorted list
            foreach (employee item in SortedList)
            {
                UI_LBX_SD.Items.Add($"{item.employee_id}: \t {item.employee_salary}");
            }          
            //Displaying sorted values and time elapsed in ticks
            UI_TBX_TT.Text = $"{sw.ElapsedTicks}";
            //Resetting stopwatch
            sw.Reset();
                  

        }
    }
}
