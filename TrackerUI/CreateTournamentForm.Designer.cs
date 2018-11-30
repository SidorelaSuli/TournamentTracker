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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TournamentPlayersListbox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.prizesListbox = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "headerLabel";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Tournament:";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "tournamentNameValue";
            this.textBox1.Location = new System.Drawing.Point(45, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 26);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AccessibleName = "tournamentNameLabel";
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(36, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 54);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tournament Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "entryFeeLabel";
            this.textBox2.Location = new System.Drawing.Point(244, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "0";
            // 
            // label2
            // 
            this.label2.AccessibleName = "entryFeeLabel";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(52, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 54);
            this.label2.TabIndex = 11;
            this.label2.Text = "Entry Fee";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "selectTeamDropdown";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(342, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AccessibleName = "selectTeamLabel";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(36, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 54);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Team";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleName = "createNewTeamLink";
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(289, 319);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "create new";
            // 
            // addTeamButton
            // 
            this.addTeamButton.AccessibleName = "addTeamButton";
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addTeamButton.Location = new System.Drawing.Point(132, 404);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(151, 64);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AccessibleName = "createPrizeButton";
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(132, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 64);
            this.button2.TabIndex = 17;
            this.button2.Text = "Create Prize";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListbox
            // 
            this.TournamentPlayersListbox.AccessibleName = "matchupListbox";
            this.TournamentPlayersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListbox.FormattingEnabled = true;
            this.TournamentPlayersListbox.ItemHeight = 20;
            this.TournamentPlayersListbox.Location = new System.Drawing.Point(443, 174);
            this.TournamentPlayersListbox.Name = "TournamentPlayersListbox";
            this.TournamentPlayersListbox.Size = new System.Drawing.Size(401, 142);
            this.TournamentPlayersListbox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AccessibleName = "tournamentPlayersLabel";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(451, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 54);
            this.label4.TabIndex = 19;
            this.label4.Text = "Team / Players";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "deelteSelectedPlayersButton";
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(854, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 64);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete Selected";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AccessibleName = "prizesLabel";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(451, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 54);
            this.label6.TabIndex = 22;
            this.label6.Text = "Team / Players";
            // 
            // prizesListbox
            // 
            this.prizesListbox.AccessibleName = "prizesListbox";
            this.prizesListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListbox.FormattingEnabled = true;
            this.prizesListbox.ItemHeight = 20;
            this.prizesListbox.Location = new System.Drawing.Point(443, 404);
            this.prizesListbox.Name = "prizesListbox";
            this.prizesListbox.Size = new System.Drawing.Size(401, 142);
            this.prizesListbox.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.AccessibleName = "deelteSelectedPrizesButton";
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(854, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 64);
            this.button4.TabIndex = 23;
            this.button4.Text = "Delete Selected";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AccessibleName = "createTournamentButton";
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(378, 584);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 64);
            this.button5.TabIndex = 24;
            this.button5.Text = "Create Tournament";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 660);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prizesListbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TournamentPlayersListbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox TournamentPlayersListbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox prizesListbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}