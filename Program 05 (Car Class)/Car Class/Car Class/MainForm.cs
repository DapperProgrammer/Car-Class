// Calvin Tracy
// CS 313 01
// Program Assignment 05
// 20200401
// Program to accelerate and deceletate the spd of a car

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Class
{
    public partial class MainForm : Form
    {
        // Create a Car object.
        Car myCar = new Car();
        int result = 0;
        int brkResult;

        public MainForm()
        {
            InitializeComponent();
        }

        // Sets the values of the fields for the Car Class
        private void GetCarData()
        {
            try
            {
                myCar.GetYear = txtYear.Text; 
                myCar.GetMake = txtMake.Text;
                myCar.GetSpeed = 0;
            }
            catch
            {
                MessageBox.Show("Please enter a valid year and model.");
            }
            //lbCar.Items.Add(specs.GetYear);
            //lbCar.Items.Add(specs.GetMake);
        }

        private void btnAccel_Click(object sender, EventArgs e)
        {

            GetCarData();
            // Passes in "result" to the accelerate method. 
            myCar.Accelerate(result);
            txtSpeed.Text = myCar.GetSpeed.ToString();
            result = myCar.GetSpeed;

            if (result == 100)
            {
                MessageBox.Show("Woah to fast!");
                btnAccel.Enabled = false;
            }
            
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            GetCarData();
            myCar.Break(result);
            txtSpeed.Text = myCar.GetSpeed.ToString();
            brkResult = myCar.GetSpeed;

            if (brkResult <= 0)
            {
                MessageBox.Show("Your car isn't moving!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
