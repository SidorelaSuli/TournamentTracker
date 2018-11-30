namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentDashboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AccessibleName = "headerLabel";
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(308, 37);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(627, 74);
            this.tournamentDashboardLabel.TabIndex = 13;
            this.tournamentDashboardLabel.Text = "Tourmnament Dashboard";
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AccessibleName = "selectTeamMemberLabel";
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(47, 138);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(332, 54);
            this.loadExistingTournamentLabel.TabIndex = 21;
            this.loadExistingTournamentLabel.Text = "Load Tournament";
            // 
            // loadExistingTournamentDropdown
            // 
            this.loadExistingTournamentDropdown.AccessibleName = "selectTeamMemberDropdown";
            this.loadExistingTournamentDropdown.FormattingEnabled = true;
            this.loadExistingTournamentDropdown.Location = new System.Drawing.Point(47, 195);
            this.loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            this.loadExistingTournamentDropdown.Size = new System.Drawing.Size(342, 33);
            this.loadExistingTournamentDropdown.TabIndex = 20;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.AccessibleName = "addTeamButton";
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadTournamentButton.Location = new System.Drawing.Point(123, 276);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(151, 64);
            this.loadTournamentButton.TabIndex = 22;
            this.loadTournamentButton.Text = "Load";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentDashboardButton
            // 
            this.createTournamentDashboardButton.AccessibleName = "createTournamentButton";
            this.createTournamentDashboardButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentDashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentDashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentDashboardButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTournamentDashboardButton.Location = new System.Drawing.Point(123, 410);
            this.createTournamentDashboardButton.Name = "createTournamentDashboardButton";
            this.createTournamentDashboardButton.Size = new System.Drawing.Size(151, 64);
            this.createTournamentDashboardButton.TabIndex = 25;
            this.createTournamentDashboardButton.Text = "Create Tournament";
            this.createTournamentDashboardButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 866);
            this.Controls.Add(this.createTournamentDashboardButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.loadExistingTournamentDropdown);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropdown;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentDashboardButton;
    }
}