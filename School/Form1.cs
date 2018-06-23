using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {

        Admin admin = new Admin();
        public Form1()
        {
            InitializeComponent();
            this.Width = 488;
            this.Height = 270;
        }

        

        private void login_Click(object sender, EventArgs e)
        {
            var adminUsName = admin.UserN;
            var adminUsPass = admin.UserP;
            var istifadeciAd = username.Text;
            var istifadeciParol = password.Text;


            if (adminUsName == istifadeciAd && adminUsPass == istifadeciParol)
            {
                Choose choose = new Choose();
                this.Hide();
                choose.Show();
            }
            else
            {
                MessageBox.Show("You are not Admin");
                username.Text = string.Empty;
                password.Text = string.Empty;
            }
        }
    }
}
