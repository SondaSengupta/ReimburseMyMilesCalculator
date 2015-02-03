using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4MileageCalculator
{
    public partial class MileageCalculator : Form  
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate;
        double amountOwed;
        public MileageCalculator()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void MileageCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       startingMileage = (int)numericUpDown1.Value;
       endingMileage = (int)numericUpDown2.Value;
       reimburseRate = (double)numericUpDown3.Value;
            if(startingMileage < endingMileage){
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label3.Text = "$" + amountOwed;
                label4.Text = "You have driven " + milesTraveled + " miles with a total reimbursement of $" + amountOwed + ".";
            }
            else{
                MessageBox.Show(
                    "The starting mileage must be less than the ending mileage", 
                    "Cannot Calculate Mileage");
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + "miles", "Miles Traveled");
        }

        }
    }

