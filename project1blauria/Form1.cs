using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Brandi Lauria
//COP 2010 - Project 1
//Make a Program that allows an input of Feet. Program should also compute Feet's conversion to Kilometers and Meters and Output for user to see.
//Window should also allow the user to input a Weight in Pounds.
//The programs should convert the Pounds input to Kilograms and Grams and show user via Output.
//Program should clear distances when user is inputing weight and clear weight when user is inputing distance.
//January 26, 2017


namespace project1blauria
{
    public partial class lblMetricConversionTool : Form
    {
        public lblMetricConversionTool()
        {
            InitializeComponent();
        }
        //Declare Variables
        double feet;
        double Kilometers, Meters;

        private void btnCalculateLength_Click(object sender, EventArgs e)

        {
            try
            {



                //Get input data from textbox
                feet = double.Parse(txtFeet.Text);
                //Compute results
                Kilometers = feet * .0003048;
                //Display Results
                txtKilometers.Text = Kilometers.ToString("N4");

                //Get input data from textbox
                feet = double.Parse(txtFeet.Text);
                //Compute results
                Meters = feet * .3048;
                //Display Results
                txtMeters.Text = Meters.ToString("N4");

                //Clear Weight Fields when Calculating Distance
                txtPounds.Clear();
                txtKilograms.Clear();
                txtGrams.Clear();
            }

            catch
            {
                MessageBox.Show("Input a number");
            }//Error Message

        }//End Method


        //Declare Variables
        double Pounds;
        double Kilograms, Grams;

        private void btnCalculateWeight_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    //Get input data from textbox
                    Pounds = double.Parse(txtPounds.Text);
                    //Compute results
                    Kilograms = Pounds / 2.2046886218;
                    //Display Results
                    txtKilograms.Text = Kilograms.ToString("N4");

                    //Get input data from textbox
                    Pounds = double.Parse(txtPounds.Text);
                    //Compute results
                    Grams = Pounds * 453.592;
                    //Display Results
                    txtGrams.Text = Grams.ToString("N4");

                    //Clear Distance Fields when Calculating Weight
                    txtFeet.Clear();
                    txtKilometers.Clear();
                    txtMeters.Clear();
                }

                catch
                {
                    MessageBox.Show("Input a number");
                }
            }//Error Message
        }//End Method
    }//End Class
} //End Namespace
