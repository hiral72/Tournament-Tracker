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
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameText.Text;
                p.LastName = lastNameText.Text;
                p.EmailAddress = emailText.Text;
                p.PhoneNumber = phoneText.Text;

                GlobalConfig.Connections.CreatePerson(p);
                firstNameText.Text ="";
                lastNameText.Text="";
                emailText.Text = "";
                phoneText.Text = "";


              
            }
            else {
                MessageBox.Show("You need to fill all of the fields");
            }

        }

        private bool ValidateForm()
        {
            //Todo- Add validation to the form
            bool output = true;
            if (firstNameText.Text.Length == 0 || lastNameText.Text.Length == 0 || emailText.Text.Length == 0  || phoneText.Text.Length==0)
            {
                output = false;
            }


            


            return output;
        }
    }
}
