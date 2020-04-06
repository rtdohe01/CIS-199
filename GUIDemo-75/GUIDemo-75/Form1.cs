//Lab2
//CIS 199-75
//By: Ross Doherty (N7701)
//Due Date: 2/4/2019
// This program prompts the user for the price of a meal
// and then calculates 3 different tip amounts, 15%,
// 18%, and 20%

//This solution leaves the tip rates hard coded on the form in the labels, so if change 
// the constants below, be sure to update the form's labels.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDemo_75
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Calculate and display tips
        private void calcBtn_Click(object sender, EventArgs e)

            
        {
            double priceOfMeal; //price of meal
            double TIPRATE1; //tip rate 1
            double TIPRATE2; //tip rate 2
            double TIPRATE3; //tip rate 3

            //converts input into decimal 
            priceOfMeal = double.Parse(priceOfMealTxt.Text);

            //calculates tip rate
            TIPRATE1 = priceOfMeal * 0.15;
            TIPRATE2 = priceOfMeal * 0.18;
            TIPRATE3 = priceOfMeal * 0.20;

            //display tip amount
            TIPRATE_LOW.Text = $"{TIPRATE1}";
            TIPRATE_MEDIUM.Text = $"{TIPRATE2}";
            TIPRATE_HIGH.Text = $"{TIPRATE3}";

            

        }
    }
}
