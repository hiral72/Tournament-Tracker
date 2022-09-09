using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumberText.Text,
                    placeNameText.Text,
                    prizeAmtText.Text,
                    prizePercentageText.Text);
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                placeNumberText.Text = "";
                 placeNameText.Text="";
                 prizeAmtText.Text="0";
                 prizePercentageText.Text="0";
            }
            else {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool isPlaceNumberValid= int.TryParse(placeNumberText.Text,out placeNumber);
            if (!isPlaceNumberValid)
            {
                output = false;
            }

            if (placeNumber < 1) 
            {
                output = false;
            }

            if (placeNameText.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmt = 0;
            double prizePercentage = 0;
            bool isPrizeAmtValid = decimal.TryParse(prizeAmtText.Text, out prizeAmt);
            bool isPrizePercentageValid = double.TryParse(prizePercentageText.Text, out prizePercentage);
            if (isPrizeAmtValid==false || isPrizePercentageValid==false)
            {
                output = false;
            }
            if (prizeAmt <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
   

            return output;
        }

        private void prizeAmtText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
