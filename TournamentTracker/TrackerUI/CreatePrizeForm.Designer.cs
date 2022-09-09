namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.headerlabel = new System.Windows.Forms.Label();
            this.placeNumberText = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameText = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmtText = new System.Windows.Forms.TextBox();
            this.prizeAmtlabel = new System.Windows.Forms.Label();
            this.prizePercentageText = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.orLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.headerlabel.Location = new System.Drawing.Point(265, 20);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(219, 47);
            this.headerlabel.TabIndex = 3;
            this.headerlabel.Text = "Create Prize";
            // 
            // placeNumberText
            // 
            this.placeNumberText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberText.Location = new System.Drawing.Point(381, 113);
            this.placeNumberText.Name = "placeNumberText";
            this.placeNumberText.Size = new System.Drawing.Size(251, 33);
            this.placeNumberText.TabIndex = 15;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNumberLabel.Location = new System.Drawing.Point(101, 113);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(189, 37);
            this.placeNumberLabel.TabIndex = 14;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // placeNameText
            // 
            this.placeNameText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameText.Location = new System.Drawing.Point(381, 175);
            this.placeNameText.Name = "placeNameText";
            this.placeNameText.Size = new System.Drawing.Size(251, 33);
            this.placeNameText.TabIndex = 17;
            this.placeNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNameLabel.Location = new System.Drawing.Point(101, 175);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(163, 37);
            this.placeNameLabel.TabIndex = 16;
            this.placeNameLabel.Text = "Place Name";
            this.placeNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // prizeAmtText
            // 
            this.prizeAmtText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmtText.Location = new System.Drawing.Point(381, 236);
            this.prizeAmtText.Name = "prizeAmtText";
            this.prizeAmtText.Size = new System.Drawing.Size(251, 33);
            this.prizeAmtText.TabIndex = 19;
            this.prizeAmtText.Text = "0";
            this.prizeAmtText.TextChanged += new System.EventHandler(this.prizeAmtText_TextChanged);
            // 
            // prizeAmtlabel
            // 
            this.prizeAmtlabel.AutoSize = true;
            this.prizeAmtlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.prizeAmtlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeAmtlabel.Location = new System.Drawing.Point(101, 236);
            this.prizeAmtlabel.Name = "prizeAmtlabel";
            this.prizeAmtlabel.Size = new System.Drawing.Size(183, 37);
            this.prizeAmtlabel.TabIndex = 18;
            this.prizeAmtlabel.Text = "Prize Amount";
            // 
            // prizePercentageText
            // 
            this.prizePercentageText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageText.Location = new System.Drawing.Point(381, 345);
            this.prizePercentageText.Name = "prizePercentageText";
            this.prizePercentageText.Size = new System.Drawing.Size(251, 33);
            this.prizePercentageText.TabIndex = 21;
            this.prizePercentageText.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizePercentageLabel.Location = new System.Drawing.Point(101, 345);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(220, 37);
            this.prizePercentageLabel.TabIndex = 20;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.SlateBlue;
            this.createPrizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createPrizeButton.Location = new System.Drawing.Point(255, 427);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(294, 50);
            this.createPrizeButton.TabIndex = 22;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.orLabel.Location = new System.Drawing.Point(319, 290);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(81, 32);
            this.orLabel.TabIndex = 23;
            this.orLabel.Text = "- OR -";
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(807, 527);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizePercentageText);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmtText);
            this.Controls.Add(this.prizeAmtlabel);
            this.Controls.Add(this.placeNameText);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberText);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.TextBox placeNumberText;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNameText;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmtText;
        private System.Windows.Forms.Label prizeAmtlabel;
        private System.Windows.Forms.TextBox prizePercentageText;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label orLabel;
    }
}