namespace IOOP.Forms
{
    partial class AdminClubsReport
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
            this.lstClubs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(93, 406);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(178, 41);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lstClubs
            // 
            this.lstClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClubs.FormattingEnabled = true;
            this.lstClubs.ItemHeight = 16;
            this.lstClubs.Location = new System.Drawing.Point(12, 12);
            this.lstClubs.Name = "lstClubs";
            this.lstClubs.ScrollAlwaysVisible = true;
            this.lstClubs.Size = new System.Drawing.Size(341, 388);
            this.lstClubs.TabIndex = 4;
            // 
            // AdminClubsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 453);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lstClubs);
            this.Name = "AdminClubsReport";
            this.Text = "AdminClubsReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox lstClubs;
    }
}