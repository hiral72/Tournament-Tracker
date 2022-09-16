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
    public partial class CreateTournamentForm : Form, IPrizeRequester,ITeamRequester
    {
        private List<TeamModel> availTeams = GlobalConfig.Connections.GetTeam_All();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        private List<PrizeModel> availPrizes = GlobalConfig.Connections.GetPrize_All();
        private List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            teamDropdown.DataSource = null;
            teamDropdown.DataSource = availTeams;
            teamDropdown.DisplayMember = "TeamName";

            teamsListBox.DataSource = null;
            teamsListBox.DataSource = selectedTeams;
            teamsListBox.DisplayMember = "TeamName";

            prizeDropdown.DataSource = null;
            prizeDropdown.DataSource = availPrizes;
            prizeDropdown.DisplayMember = "PlaceName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)teamDropdown.SelectedItem;
            availTeams.Remove(t);
            selectedTeams.Add(t);
            WireUpLists();
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)teamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availTeams.Add(t);
                // TODO- good method to update list
                WireUpLists();
            }
        }
        private void createPrizeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //call the create prize form
            // this keyword represnts createtournamentform instanace
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show(); 

        }

        public void PrizeComplete(PrizeModel model)
        {
            //get back a prizemodel from the form
            //take model prize and put it into a list of selected prize
            selectedPrizes.Add(model);
            WireUpLists();
        }
    
        private void createTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void deletePrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel t = (PrizeModel)prizesListBox.SelectedItem;
            if (t != null)
            {
                selectedPrizes.Remove(t);
                availPrizes.Add(t);
                // TODO- good method to update list
                WireUpLists();
            }
        }

        private void addPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p= (PrizeModel)prizeDropdown.SelectedItem;
            if (p != null)
            {
                availPrizes.Remove(p);
                selectedPrizes.Add(p);
                WireUpLists();
            }
           
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //validate data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(EntryfeeText.Text, out fee); 
            TournamentModel tm = new TournamentModel();
            // TODO - validate form
            tm.TournamentName = tournamentNameText.Text;
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry fee.",
                    "Invalid Fee", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            tm.EntryFee = fee ;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
            // TODO- wireup our matchups
         
            TournamentLogic.CreateRounds(tm);
            // create tournament entry

            GlobalConfig.Connections.CreateTournament(tm);
            
        }
    }
}