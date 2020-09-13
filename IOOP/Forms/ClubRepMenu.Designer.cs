namespace IOOP.Forms
{
    partial class ClubRepMenu
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
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpActivityLog = new System.Windows.Forms.GroupBox();
            this.lstBoxClubAct = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblClubName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.grpDetails.SuspendLayout();
            this.grpActivityLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtDetails);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(12, 78);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(404, 176);
            this.grpDetails.TabIndex = 10;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Club Description";
            // 
            // txtDetails
            // 
            this.txtDetails.AllowDrop = true;
            this.txtDetails.BackColor = System.Drawing.Color.White;
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(6, 21);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(390, 149);
            this.txtDetails.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(141, 20);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "est. DD/MM/YYYY";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpActivityLog
            // 
            this.grpActivityLog.Controls.Add(this.lstBoxClubAct);
            this.grpActivityLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActivityLog.Location = new System.Drawing.Point(12, 307);
            this.grpActivityLog.Name = "grpActivityLog";
            this.grpActivityLog.Size = new System.Drawing.Size(404, 198);
            this.grpActivityLog.TabIndex = 12;
            this.grpActivityLog.TabStop = false;
            this.grpActivityLog.Text = "Club Activity Log";
            // 
            // lstBoxClubAct
            // 
            this.lstBoxClubAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxClubAct.FormattingEnabled = true;
            this.lstBoxClubAct.HorizontalScrollbar = true;
            this.lstBoxClubAct.ItemHeight = 24;
            this.lstBoxClubAct.Location = new System.Drawing.Point(6, 25);
            this.lstBoxClubAct.Name = "lstBoxClubAct";
            this.lstBoxClubAct.Size = new System.Drawing.Size(390, 172);
            this.lstBoxClubAct.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(88, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(244, 32);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Description";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubName.Location = new System.Drawing.Point(12, 9);
            this.lblClubName.MaximumSize = new System.Drawing.Size(390, 0);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(195, 25);
            this.lblClubName.TabIndex = 8;
            this.lblClubName.Text = "Exmple Club Name";
            this.lblClubName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(87, 510);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(244, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add A Log Entry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(132, 551);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(149, 35);
            this.btnSignOut.TabIndex = 14;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // ClubRepMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 598);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grpActivityLog);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSignOut);
            this.Name = "ClubRepMenu";
            this.Text = "ClubRepMenu";
            this.Load += new System.EventHandler(this.ClubRepMenu_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpActivityLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpActivityLog;
        private System.Windows.Forms.ListBox lstBoxClubAct;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSignOut;
    }
}