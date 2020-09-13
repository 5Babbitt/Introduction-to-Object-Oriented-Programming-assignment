namespace IOOP.Forms
{
    partial class StudentMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblPresident = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClubName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lstClubs = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpDetails);
            this.panel1.Controls.Add(this.lblPresident);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblClubName);
            this.panel1.Location = new System.Drawing.Point(321, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 422);
            this.panel1.TabIndex = 11;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtDetails);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(7, 147);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(316, 272);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Club Description";
            // 
            // txtDetails
            // 
            this.txtDetails.AllowDrop = true;
            this.txtDetails.BackColor = System.Drawing.Color.White;
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(7, 21);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(304, 242);
            this.txtDetails.TabIndex = 0;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // lblPresident
            // 
            this.lblPresident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresident.Location = new System.Drawing.Point(3, 113);
            this.lblPresident.Name = "lblPresident";
            this.lblPresident.Size = new System.Drawing.Size(323, 27);
            this.lblPresident.TabIndex = 2;
            this.lblPresident.Text = "Club President:";
            this.lblPresident.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(110, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "est. DD/MM/YYYY";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClubName
            // 
            this.lblClubName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubName.Location = new System.Drawing.Point(3, 10);
            this.lblClubName.MaximumSize = new System.Drawing.Size(324, 90);
            this.lblClubName.MinimumSize = new System.Drawing.Size(324, 90);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(324, 90);
            this.lblClubName.TabIndex = 0;
            this.lblClubName.Text = "Example Club Name";
            this.lblClubName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(93, 383);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(135, 40);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // lstClubs
            // 
            this.lstClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClubs.FormattingEnabled = true;
            this.lstClubs.ItemHeight = 24;
            this.lstClubs.Location = new System.Drawing.Point(23, 29);
            this.lstClubs.Name = "lstClubs";
            this.lstClubs.Size = new System.Drawing.Size(279, 340);
            this.lstClubs.TabIndex = 9;
            this.lstClubs.SelectedIndexChanged += new System.EventHandler(this.lstClubs_SelectedIndexChanged);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lstClubs);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblPresident;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.ListBox lstClubs;
    }
}