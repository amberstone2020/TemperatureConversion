// Amber Holcomb-Stone
// CITC 2311: Lab 1 Part A
// Description: This program takes user input for a temperature and converts it to Celsius or Fahrenheit per form specs provided. 
// Includes error handling. 
// Code modified from: Murach solutions, https://www.youtube.com/watch?v=JZah3G6sImw and 
// https://www.rapidtables.com/convert/temperature/celsius-to-fahrenheit.html

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Converts user input to Celsius and completes exception handling as needed
        private void btnCelsius_Click(object sender, EventArgs e)
        {
            try
            {
                conversionBox.Text = Convert.ToString((Convert.ToDouble(tempBox.Text) - 32) * 5 / 9);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid numeric format. Please check your entry.",
                    "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString());
            }
        }

        // Converts user input to Fahrenheit and completes exception handling as needed
        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                conversionBox.Text = Convert.ToString((Convert.ToDouble(tempBox.Text) * 9 / 5 + 32));
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid numeric format. Please check your entry.",
                    "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString());
            }

        }
                private void tempBox_TextChanged(object sender, EventArgs e)
                {

                }
    }
        }
    