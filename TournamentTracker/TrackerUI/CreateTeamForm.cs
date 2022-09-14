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

        private List<PersonModel> availTeamMembers = GlobalConfig.Connections.GetPerson_All();
        private List<PersonModel> selectedTeamMembers= new List<PersonModel>();
        ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
           // CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "C" });
            availTeamMembers.Add(new PersonModel { FirstName = "Tedim", LastName = "C" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Hiral", LastName = "Sheth" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Hetvi", LastName = "Sheth" });
        }

       

        private void WireUpLists()
        {
            teamDropdown.DataSource = null;
            teamDropdown.DataSource = availTeamMembers;
            teamDropdown.DisplayMember = "FullName";

            teamPlayersListBox.DataSource = null;
            teamPlayersListBox.DataSource = selectedTeamMembers;
            teamPlayersListBox.DisplayMember = "FullName";
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
                selectedTeamMembers.Add(p);
                WireUpLists();

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

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamDropdown.SelectedItem;
            availTeamMembers.Remove(p);            
            selectedTeamMembers.Add(p);
            // TODO- good method to update list
            WireUpLists();
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamPlayersListBox.SelectedItem;
            if (p!=null)
            {
                selectedTeamMembers.Remove(p);
                availTeamMembers.Add(p);
                // TODO- good method to update list
                WireUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameText.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connections.CreateTeam(t);
            // TODO- validate form
            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}
