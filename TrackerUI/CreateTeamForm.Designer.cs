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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.AddNewMember = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.TeamMembersList = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.AddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.AccessibleName = "teamNameValue";
            this.teamNameValue.Location = new System.Drawing.Point(45, 165);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(342, 26);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AccessibleName = "teamNameLabel";
            this.teamNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamNameLabel.Location = new System.Drawing.Point(36, 94);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(231, 54);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            this.teamNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AccessibleName = "headerLabel";
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTeamLabel.Location = new System.Drawing.Point(12, 9);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(334, 74);
            this.createTeamLabel.TabIndex = 11;
            this.createTeamLabel.Text = "Create Team:";
            // 
            // addMemberButton
            // 
            this.addMemberButton.AccessibleName = "addMemberButton";
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addMemberButton.Location = new System.Drawing.Point(45, 320);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(151, 64);
            this.addMemberButton.TabIndex = 18;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.AccessibleName = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(45, 270);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(342, 28);
            this.selectTeamMemberDropdown.TabIndex = 17;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AccessibleName = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(45, 213);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(392, 54);
            this.selectTeamMemberLabel.TabIndex = 19;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // AddNewMember
            // 
            this.AddNewMember.Controls.Add(this.createMemberButton);
            this.AddNewMember.Controls.Add(this.cellphoneValue);
            this.AddNewMember.Controls.Add(this.cellphoneLabel);
            this.AddNewMember.Controls.Add(this.emailValue);
            this.AddNewMember.Controls.Add(this.emailLabel);
            this.AddNewMember.Controls.Add(this.lastNameValue);
            this.AddNewMember.Controls.Add(this.lastNameLabel);
            this.AddNewMember.Controls.Add(this.firstNameValue);
            this.AddNewMember.Controls.Add(this.firstNameLabel);
            this.AddNewMember.Location = new System.Drawing.Point(45, 390);
            this.AddNewMember.Name = "AddNewMember";
            this.AddNewMember.Size = new System.Drawing.Size(478, 320);
            this.AddNewMember.TabIndex = 20;
            this.AddNewMember.TabStop = false;
            this.AddNewMember.Text = "groupBox1";
            // 
            // createMemberButton
            // 
            this.createMemberButton.AccessibleName = "createMemberButton";
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createMemberButton.Location = new System.Drawing.Point(140, 256);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(151, 64);
            this.createMemberButton.TabIndex = 19;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.AccessibleName = "cellphoneValue";
            this.cellphoneValue.Location = new System.Drawing.Point(228, 215);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(221, 26);
            this.cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AccessibleName = "cellphoneLabel";
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellphoneLabel.Location = new System.Drawing.Point(8, 200);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(203, 54);
            this.cellphoneLabel.TabIndex = 15;
            this.cellphoneLabel.Text = "Cellphone";
            this.cellphoneLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailValue
            // 
            this.emailValue.AccessibleName = "emailValue";
            this.emailValue.Location = new System.Drawing.Point(228, 159);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(221, 26);
            this.emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AccessibleName = "emailLabel";
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.emailLabel.Location = new System.Drawing.Point(8, 144);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(117, 54);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastNameValue
            // 
            this.lastNameValue.AccessibleName = "lastNameValue";
            this.lastNameValue.Location = new System.Drawing.Point(228, 105);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(221, 26);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AccessibleName = "lastNameLabel";
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lastNameLabel.Location = new System.Drawing.Point(8, 90);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(209, 54);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstNameValue
            // 
            this.firstNameValue.AccessibleName = "firstNameValue";
            this.firstNameValue.Location = new System.Drawing.Point(226, 51);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(221, 26);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AccessibleName = "firstNameLabel";
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 36);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(214, 54);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TeamMembersList
            // 
            this.TeamMembersList.AccessibleName = "teamMemberListbox";
            this.TeamMembersList.FormattingEnabled = true;
            this.TeamMembersList.ItemHeight = 20;
            this.TeamMembersList.Location = new System.Drawing.Point(551, 80);
            this.TeamMembersList.Name = "TeamMembersList";
            this.TeamMembersList.Size = new System.Drawing.Size(348, 564);
            this.TeamMembersList.TabIndex = 21;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.AccessibleName = "deelteSelectedMemberButton";
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(928, 331);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(102, 64);
            this.deleteSelectedMemberButton.TabIndex = 22;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.AccessibleName = "createTeamButton";
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTeamButton.Location = new System.Drawing.Point(653, 650);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(151, 64);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 722);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.TeamMembersList);
            this.Controls.Add(this.AddNewMember);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeam";
            this.AddNewMember.ResumeLayout(false);
            this.AddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox AddNewMember;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox TeamMembersList;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}