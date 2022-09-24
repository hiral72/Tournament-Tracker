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
    public partial class TournamentDashboardForm : Form
    {
         private List<TournamentModel> tournaments = GlobalConfig.Connections.GetTournament_All();
       
        private void WireUpLists()
        {
            loadExistingTournamentDropdown.DataSource = null;
            loadExistingTournamentDropdown.DataSource = tournaments;
            loadExistingTournamentDropdown.DisplayMember = "TournamentName";
        }
        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm() ;
            frm.Show(); 

        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)loadExistingTournamentDropdown.SelectedItem;
            TournamentViewer frm = new TournamentViewer(tm);
            frm.Show();
            //this.Close();
        }
    }
}
