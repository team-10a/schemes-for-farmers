using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (Emailidtextbox.Text == "admin" && Passwordtextbox.Text == "admin")
            {
                new Form1().Show;
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Emailid Or Password You entered is incorrect,Please try again");
                Emailidtextbox.Clear();
                Passwordtextbox.Clear();
                Emailidtextbox.Focus();
            }
        }
    }
}
