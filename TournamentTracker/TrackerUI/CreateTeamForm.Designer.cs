namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.headerlabel = new System.Windows.Forms.Label();
            this.teamNameText = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.teamPlayersListBox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroup = new System.Windows.Forms.GroupBox();
            this.removeSelectedMemberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.headerlabel.Location = new System.Drawing.Point(262, -9);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(225, 47);
            this.headerlabel.TabIndex = 2;
            this.headerlabel.Text = "Create Team";
            // 
            // teamNameText
            // 
            this.teamNameText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameText.Location = new System.Drawing.Point(41, 79);
            this.teamNameText.Name = "teamNameText";
            this.teamNameText.Size = new System.Drawing.Size(367, 33);
            this.teamNameText.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamNameLabel.Location = new System.Drawing.Point(34, 39);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(166, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // teamDropdown
            // 
            this.teamDropdown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDropdown.FormattingEnabled = true;
            this.teamDropdown.Location = new System.Drawing.Point(44, 159);
            this.teamDropdown.Name = "teamDropdown";
            this.teamDropdown.Size = new System.Drawing.Size(364, 33);
            this.teamDropdown.TabIndex = 17;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(37, 119);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(270, 37);
            this.selectTeamMemberLabel.TabIndex = 16;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addMemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addMemberButton.Location = new System.Drawing.Point(98, 198);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(160, 41);
            this.addMemberButton.TabIndex = 18;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(51, 290);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(93, 23);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(51, 319);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(91, 23);
            this.lastNameLabel.TabIndex = 22;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.emailLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.emailLabel.Location = new System.Drawing.Point(51, 353);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 23);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.phoneLabel.Location = new System.Drawing.Point(51, 388);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(117, 23);
            this.phoneLabel.TabIndex = 24;
            this.phoneLabel.Text = "Mobile Phone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.createMemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createMemberButton.Location = new System.Drawing.Point(125, 423);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(181, 42);
            this.createMemberButton.TabIndex = 25;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.firstNameText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.firstNameText.Location = new System.Drawing.Point(188, 288);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(197, 27);
            this.firstNameText.TabIndex = 26;
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lastNameText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lastNameText.Location = new System.Drawing.Point(188, 320);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(197, 27);
            this.lastNameText.TabIndex = 27;
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.emailText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.emailText.Location = new System.Drawing.Point(188, 353);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(197, 27);
            this.emailText.TabIndex = 28;
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.phoneText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.phoneText.Location = new System.Drawing.Point(188, 386);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(197, 27);
            this.phoneText.TabIndex = 29;
            // 
            // teamPlayersListBox
            // 
            this.teamPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamPlayersListBox.FormattingEnabled = true;
            this.teamPlayersListBox.ItemHeight = 21;
            this.teamPlayersListBox.Location = new System.Drawing.Point(450, 58);
            this.teamPlayersListBox.Name = "teamPlayersListBox";
            this.teamPlayersListBox.Size = new System.Drawing.Size(345, 361);
            this.teamPlayersListBox.TabIndex = 30;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.SlateBlue;
            this.createTeamButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createTeamButton.Location = new System.Drawing.Point(292, 479);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(277, 49);
            this.createTeamButton.TabIndex = 31;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // addNewMemberGroup
            // 
            this.addNewMemberGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addNewMemberGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addNewMemberGroup.Location = new System.Drawing.Point(41, 246);
            this.addNewMemberGroup.Name = "addNewMemberGroup";
            this.addNewMemberGroup.Size = new System.Drawing.Size(367, 227);
            this.addNewMemberGroup.TabIndex = 32;
            this.addNewMemberGroup.TabStop = false;
            this.addNewMemberGroup.Text = "Add New Member";
            // 
            // removeSelectedMemberButton
            // 
            this.removeSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.removeSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.removeSelectedMemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeSelectedMemberButton.Location = new System.Drawing.Point(520, 431);
            this.removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            this.removeSelectedMemberButton.Size = new System.Drawing.Size(175, 42);
            this.removeSelectedMemberButton.TabIndex = 33;
            this.removeSelectedMemberButton.Text = "Remove Selected";
            this.removeSelectedMemberButton.UseVisualStyleBackColor = true;
            this.removeSelectedMemberButton.Click += new System.EventHandler(this.removeSelectedMemberButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(807, 527);
            this.Controls.Add(this.removeSelectedMemberButton);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.teamPlayersListBox);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.createMemberButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.teamDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameText);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerlabel);
            this.Controls.Add(this.addNewMemberGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.TextBox teamNameText;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.ComboBox teamDropdown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.ListBox teamPlayersListBox;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.GroupBox addNewMemberGroup;
        private System.Windows.Forms.Button removeSelectedMemberButton;
    }
}