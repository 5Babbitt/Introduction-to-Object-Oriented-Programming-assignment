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
            this.lblPreisdent = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClubName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lstClubs = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpDetails);
            this.panel1.Controls.Add(this.lblPreisdent);
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
            // 
            // lblPreisdent
            // 
            this.lblPreisdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreisdent.Location = new System.Drawing.Point(3, 113);
            this.lblPreisdent.Name = "lblPreisdent";
            this.lblPreisdent.Size = new System.Drawing.Size(323, 27);
            this.lblPreisdent.TabIndex = 2;
            this.lblPreisdent.Text = "Club President:";
            this.lblPreisdent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lstClubs.Location = new System.Drawing.Point(27, 133);
            this.lstClubs.Name = "lstClubs";
            this.lstClubs.Size = new System.Drawing.Size(276, 244);
            this.lstClubs.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(27, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(276, 40);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(27, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 31);
            this.txtSearch.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Club Name";
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lstClubs);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblPreisdent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.ListBox lstClubs;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}