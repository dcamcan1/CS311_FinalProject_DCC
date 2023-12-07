using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_FinalProject_DCC
{
    public partial class Form1 : Form
    {
        float input = 0;
        float output = 0;
        String fromTag = "";
        String toTag = "";
        

        public Form1()
        {
            InitializeComponent();
            rdoMeters.Checked = false;
        }

        private void calculate()    
        {
            textboxEmptyCheck();

            //From meters
            if (rdoMeters.Checked)
            {
                fromTag = " m";
                if (rdoFeet2.Checked)
                {
                    output = metersToFeet();
                    toTag = " ft";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }//end meters

            //From feet
            else if (rdoFeet.Checked)
            {
                fromTag = " ft";
                if (rdoMeters2.Checked)
                {
                    output = feetToMeters();
                    toTag = " m";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }//end feet

            //From kilometers
            else if (rdoKilometers.Checked)
            {
                fromTag = " km";
                if (rdoMiles2.Checked)
                {
                    output = kilometersToMiles();
                    toTag = " mi";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }//end kilometers

            //From miles
            else if (rdoMiles.Checked)
            {
                fromTag = " mi";
                if (rdoKilometers2.Checked)
                {
                    output = milesToKilometers();
                    toTag = " km";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }//end miles

            //From celsius
            else if (rdoCelsius.Checked)
            {
                fromTag = " °C";
                if (rdoFarenheit2.Checked)
                {
                    output = celsiusToFarenheit();
                    toTag = " °F";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }//end celsius

            //From farenheit
            else if (rdoFarenheit.Checked)
            {
                fromTag = " °F";
                if (rdoCelsius2.Checked)
                {
                    output = farenheitToCelsius();
                    toTag = " °C";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }//end farenheit

            //From kilograms
            else if (rdoKilograms.Checked)
            {
                fromTag = " kg";
                if (rdoPounds2.Checked)
                {
                    output = kilogramsToPounds();
                    toTag = " lb";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }//end kilograms

            //From pounds
            else if (rdoPounds.Checked)
            {
                fromTag = " lb";
                if (rdoKilograms2.Checked)
                {
                    output = poundsToKilograms();
                    toTag = " kg";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }//end pounds

            //From grams
            else if (rdoGrams.Checked)
            {
                fromTag = " g";
                if (rdoOunces2.Checked)
                {
                    output = gramsToOunces();
                    toTag = " oz";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }

            else if (rdoOunces.Checked)
            {
                fromTag = " oz";
                if (rdoGrams2.Checked)
                {
                    output = ouncesToGrams();
                    toTag = " g";
                }
                else
                {
                    MessageBox.Show("This is not a valid conversion.");
                    return;
                }
            }

            //Default
            else
            {
                MessageBox.Show("You must select the appropriate units.");
                return;
            }

            //Final Result
            lblResult.Text = input.ToString("0.00") + fromTag + " = " + output.ToString("0.00") + toTag;
        }

        private float metersToFeet()
        {
            float feet = input * (float)3.28084;
            return feet;
        }

        private float feetToMeters()
        {
            float meters = input * (float)0.3048;
            return meters;
        }

        private float kilometersToMiles()
        {
            float miles = input * (float)0.621371;
            return miles;
        }

        private float milesToKilometers()
        {
            float kilometers = input * (float)1.6;
            return kilometers;
        }

        private float celsiusToFarenheit()
        {
            float farenheit = input * (9 / 5) + 32;
            return farenheit;
        }

        private float farenheitToCelsius()
        {
            float celsius = (input - 32) * (5 / 9);
            return celsius;
        }

        private float kilogramsToPounds()
        {
            float pounds = input * (float)2.2;
            return pounds;
        }

        private float poundsToKilograms()
        {
            float kilograms = input * (float)0.45359237;
            return kilograms;
        }

        private float gramsToOunces()
        {
            float ounces = input * (float)0.035274;
            return ounces;
        }

        private float ouncesToGrams()
        {
            float grams = input * (float)28.34952;
            return grams;
        }

        private void textboxEmptyCheck()
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("You must enter a numerical value.");
            }
            else
            {
                input = float.Parse(txtInput.Text);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            rdoCelsius.Checked = false;
            rdoCelsius2.Checked = false;
            rdoFarenheit.Checked = false;
            rdoFarenheit2.Checked = false;
            rdoFeet.Checked = false;
            rdoFeet2.Checked = false;
            rdoGrams.Checked = false;
            rdoGrams2.Checked = false;
            rdoKilograms.Checked = false;
            rdoKilograms2.Checked = false;
            rdoKilometers.Checked = false;
            rdoKilometers2.Checked = false;
            rdoMeters.Checked = false;
            rdoMeters2.Checked = false;
            rdoMiles.Checked = false;
            rdoMiles2.Checked = false;
            rdoOunces.Checked = false;
            rdoOunces2.Checked = false;
            rdoPounds.Checked = false;
            rdoPounds2.Checked = false;
            txtInput.Text = "";
        }
    }
}
