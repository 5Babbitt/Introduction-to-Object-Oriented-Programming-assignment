﻿namespace IOOP.Forms
{
    partial class AdminActivityReport
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lstActivity = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(121, 406);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(207, 41);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lstActivity
            // 
            this.lstActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActivity.FormattingEnabled = true;
            this.lstActivity.ItemHeight = 20;
            this.lstActivity.Location = new System.Drawing.Point(12, 12);
            this.lstActivity.Name = "lstActivity";
            this.lstActivity.ScrollAlwaysVisible = true;
            this.lstActivity.Size = new System.Drawing.Size(422, 384);
            this.lstActivity.TabIndex = 2;
            // 
            // AdminActivityReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 457);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lstActivity);
            this.Name = "AdminActivityReport";
            this.Text = "AdminActivityReport";
            this.Load += new System.EventHandler(this.AdminActivityReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox lstActivity;
    }
}