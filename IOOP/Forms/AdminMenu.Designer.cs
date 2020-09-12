namespace IOOP.Forms
{
    partial class AdminMenu
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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.btnClubReport = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(105, 260);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(132, 43);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyReport.Location = new System.Drawing.Point(22, 180);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(306, 62);
            this.btnWeeklyReport.TabIndex = 6;
            this.btnWeeklyReport.Text = "Weekly Club Activity Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // btnClubReport
            // 
            this.btnClubReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClubReport.Location = new System.Drawing.Point(22, 100);
            this.btnClubReport.Name = "btnClubReport";
            this.btnClubReport.Size = new System.Drawing.Size(306, 62);
            this.btnClubReport.TabIndex = 5;
            this.btnClubReport.Text = "Club Report";
            this.btnClubReport.UseVisualStyleBackColor = true;
            this.btnClubReport.Click += new System.EventHandler(this.btnClubReport_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.Location = new System.Drawing.Point(22, 20);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(306, 62);
            this.btnManagement.TabIndex = 4;
            this.btnManagement.Text = "Club Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 319);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnWeeklyReport);
            this.Controls.Add(this.btnClubReport);
            this.Controls.Add(this.btnManagement);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Button btnClubReport;
        private System.Windows.Forms.Button btnManagement;
    }
}