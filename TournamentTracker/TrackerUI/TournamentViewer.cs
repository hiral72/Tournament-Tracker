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
    public partial class TournamentViewer : Form
    {
        private TournamentModel tournament;
        List<int> rounds=new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();

        public TournamentViewer(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            LoadFormData();
            LoadRounds();

        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpMatchupsList()
        {
            MatchupListBox.DataSource = null;
            MatchupListBox.DataSource = selectedMatchups;
            MatchupListBox.DisplayMember = "DisplayName";
        }

        private void WireUpRoundsList()
        {
            roundDropdown.DataSource = null;
            roundDropdown.DataSource = rounds; 
        }

        private void LoadRounds()
        {
            rounds.Add(1);
            int currRound = 1;
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound=matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            WireUpRoundsList();

        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            teamOneName.Visible = isVisible;
            teamTwoName.Visible = isVisible;
            teamOneScoreLable.Visible = isVisible;
            teamTwoScoreLable.Visible = isVisible;
            teamOneScoreValue.Visible = isVisible;
            teamTwoScoreValue.Visible = isVisible;
            scoreButton.Visible = isVisible;
            vsLabel.Visible = isVisible;
            
            
        }

        private void LoadMatchups()
        {
            int round = (int)roundDropdown.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound ==round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedOnlyCheckbox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                   

                }
            }
            WireUpMatchupsList();
            DisplayMatchupInfo();
        }


        private void roundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;

            for (int i = 0; m!=null && i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValue.Text=m.Entries[0].Score.ToString();

                        teamTwoName.Text = "<bye>";
                        teamTwoScoreValue.Text = "";
                    }
                    else {
                        teamOneName.Text = "Not Yet Set";
                        teamOneScoreValue.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoName.Text = "Not Yet Set";
                        teamTwoScoreValue.Text = "";
                    }
                }

            }
        }

        private void MatchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; m != null && i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamOneScoreValue.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else { MessageBox.Show("Please enter a valid score for team 1.");
                        return;
                        }
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {

                        bool scoreValid = double.TryParse(teamTwoScoreValue.Text, out teamTwoScore);
                        if (scoreValid)
                        {
                            m.Entries[1].Score =teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }
                    }
                }

            }
            if (teamOneScore > teamTwoScore)
            { 
                //Team one wins
                m.Winner = m.Entries[0].TeamCompeting;
                m.WinnerId = m.Winner.TeamId;
            }
            else if (teamOneScore < teamTwoScore)
            {
                //Team two wins
                m.Winner = m.Entries[1].TeamCompeting;
                m.WinnerId = m.Winner.TeamId;

            }
            else {
                MessageBox.Show("I don't handle tie games");
            }
            foreach (List<MatchupModel> round in tournament.Rounds)
            {
                foreach(MatchupModel rm in round)
                {
                    foreach(MatchupEntryModel me in rm.Entries)
                    {
                        if (me.ParentMatchup!=null)
                        {
                            if (me.ParentMatchupId == m.MatchupId)
                            {
                                me.TeamCompeting = m.Winner;
                                me.TeamCompetingId = m.WinnerId;
                                GlobalConfig.Connections.UpdateMatchup(rm);
                            }
                        }
                    }
                }
            }
            LoadMatchups();
            GlobalConfig.Connections.UpdateMatchup(m);

        }

        private void unplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();

        }
        


    }
}