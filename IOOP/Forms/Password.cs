using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP.Forms
{
    public partial class Password : Form
    {
        public string password;

        public Password()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPassword.TextLength < 4 || txtPassword.TextLength > 16)
            {
                MessageBox.Show("Please Enter between 4 and 16 characters");
            }
            else
            {
                password = txtPassword.Text;
                this.Close();
            }
        }
    }
}
