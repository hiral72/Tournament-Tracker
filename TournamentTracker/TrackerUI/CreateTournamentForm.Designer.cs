namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerlabel = new System.Windows.Forms.Label();
            this.tournamentNameText = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.EntryfeeText = new System.Windows.Forms.TextBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.teamDropdown = new System.Windows.Forms.ComboBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.deletePrizeButton = new System.Windows.Forms.Button();
            this.createTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.createPrizeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addPrizeButton = new System.Windows.Forms.Button();
            this.prizeDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.headerlabel.Location = new System.Drawing.Point(212, 9);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(337, 47);
            this.headerlabel.TabIndex = 1;
            this.headerlabel.Text = "Create Tournament";
            // 
            // tournamentNameText
            // 
            this.tournamentNameText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameText.Location = new System.Drawing.Point(31, 114);
            this.tournamentNameText.Name = "tournamentNameText";
            this.tournamentNameText.Size = new System.Drawing.Size(260, 33);
            this.tournamentNameText.TabIndex = 11;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(24, 74);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(248, 37);
            this.tournamentNameLabel.TabIndex = 10;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.feeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.feeLabel.Location = new System.Drawing.Point(24, 171);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(129, 37);
            this.feeLabel.TabIndex = 12;
            this.feeLabel.Text = "Entry Fee";
            // 
            // EntryfeeText
            // 
            this.EntryfeeText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryfeeText.Location = new System.Drawing.Point(176, 175);
            this.EntryfeeText.Name = "EntryfeeText";
            this.EntryfeeText.Size = new System.Drawing.Size(115, 33);
            this.EntryfeeText.TabIndex = 13;
            this.EntryfeeText.Text = "0";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamLabel.Location = new System.Drawing.Point(24, 230);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(163, 37);
            this.selectTeamLabel.TabIndex = 14;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // teamDropdown
            // 
            this.teamDropdown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDropdown.FormattingEnabled = true;
            this.teamDropdown.Location = new System.Drawing.Point(31, 270);
            this.teamDropdown.Name = "teamDropdown";
            this.teamDropdown.Size = new System.Drawing.Size(260, 33);
            this.teamDropdown.TabIndex = 15;
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addTeamButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addTeamButton.Location = new System.Drawing.Point(68, 309);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(160, 41);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.SlateBlue;
            this.createTournamentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createTournamentButton.Location = new System.Drawing.Point(341, 456);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(294, 50);
            this.createTournamentButton.TabIndex = 18;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoName.Location = new System.Drawing.Point(334, 263);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(89, 37);
            this.teamTwoName.TabIndex = 20;
            this.teamTwoName.Text = "Prizes";
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneName.Location = new System.Drawing.Point(334, 74);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(202, 37);
            this.teamOneName.TabIndex = 19;
            this.teamOneName.Text = "Teams/ Players";
            // 
            // teamsListBox
            // 
            this.teamsListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 21;
            this.teamsListBox.Location = new System.Drawing.Point(341, 114);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(307, 130);
            this.teamsListBox.TabIndex = 21;
            // 
            // prizesListBox
            // 
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 21;
            this.prizesListBox.Location = new System.Drawing.Point(341, 306);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(307, 130);
            this.prizesListBox.TabIndex = 22;
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.deleteTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteTeamButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteTeamButton.Location = new System.Drawing.Point(654, 152);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(132, 56);
            this.deleteTeamButton.TabIndex = 23;
            this.deleteTeamButton.Text = "Delete Selected";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // deletePrizeButton
            // 
            this.deletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.deletePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deletePrizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletePrizeButton.Location = new System.Drawing.Point(654, 332);
            this.deletePrizeButton.Name = "deletePrizeButton";
            this.deletePrizeButton.Size = new System.Drawing.Size(132, 56);
            this.deletePrizeButton.TabIndex = 24;
            this.deletePrizeButton.Text = "Delete Selected";
            this.deletePrizeButton.UseVisualStyleBackColor = true;
            this.deletePrizeButton.Click += new System.EventHandler(this.deletePrizeButton_Click);
            // 
            // createTeamLinkLabel
            // 
            this.createTeamLinkLabel.AutoSize = true;
            this.createTeamLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.createTeamLinkLabel.Location = new System.Drawing.Point(193, 243);
            this.createTeamLinkLabel.Name = "createTeamLinkLabel";
            this.createTeamLinkLabel.Size = new System.Drawing.Size(96, 23);
            this.createTeamLinkLabel.TabIndex = 25;
            this.createTeamLinkLabel.TabStop = true;
            this.createTeamLinkLabel.Text = "Create new";
            this.createTeamLinkLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.createTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createTeamLinkLabel_LinkClicked);
            // 
            // createPrizeLinkLabel
            // 
            this.createPrizeLinkLabel.AutoSize = true;
            this.createPrizeLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.createPrizeLinkLabel.Location = new System.Drawing.Point(193, 379);
            this.createPrizeLinkLabel.Name = "createPrizeLinkLabel";
            this.createPrizeLinkLabel.Size = new System.Drawing.Size(96, 23);
            this.createPrizeLinkLabel.TabIndex = 29;
            this.createPrizeLinkLabel.TabStop = true;
            this.createPrizeLinkLabel.Text = "Create new";
            this.createPrizeLinkLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.createPrizeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createPrizeLinkLabel_LinkClicked);
            // 
            // addPrizeButton
            // 
            this.addPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.addPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addPrizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPrizeButton.Location = new System.Drawing.Point(68, 445);
            this.addPrizeButton.Name = "addPrizeButton";
            this.addPrizeButton.Size = new System.Drawing.Size(160, 41);
            this.addPrizeButton.TabIndex = 28;
            this.addPrizeButton.Text = "Add Prize";
            this.addPrizeButton.UseVisualStyleBackColor = true;
            this.addPrizeButton.Click += new System.EventHandler(this.addPrizeButton_Click);
            // 
            // prizeDropdown
            // 
            this.prizeDropdown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeDropdown.FormattingEnabled = true;
            this.prizeDropdown.Location = new System.Drawing.Point(31, 406);
            this.prizeDropdown.Name = "prizeDropdown";
            this.prizeDropdown.Size = new System.Drawing.Size(260, 33);
            this.prizeDropdown.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(24, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Select Prize";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(807, 527);
            this.Controls.Add(this.createPrizeLinkLabel);
            this.Controls.Add(this.addPrizeButton);
            this.Controls.Add(this.prizeDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createTeamLinkLabel);
            this.Controls.Add(this.deletePrizeButton);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.teamDropdown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.EntryfeeText);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.tournamentNameText);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournamentForm";
            this.RightToLeftLayout = true;
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.TextBox tournamentNameText;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.TextBox EntryfeeText;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox teamDropdown;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Button deletePrizeButton;
        private System.Windows.Forms.LinkLabel createTeamLinkLabel;
        private System.Windows.Forms.LinkLabel createPrizeLinkLabel;
        private System.Windows.Forms.Button addPrizeButton;
        private System.Windows.Forms.ComboBox prizeDropdown;
        private System.Windows.Forms.Label label1;
    }
}