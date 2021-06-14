using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace License_Login_Register_Auth.gg
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Username: " + User.Username;
            label2.Text = "Email: " + User.Email;
            label3.Text = "User Variable: " + User.UserVariable;
            label4.Text = "HWID: " + User.HWID;
            label5.Text = "IP: " + User.IP;
            label6.Text = "Rank: " + User.Rank;
            label7.Text = "Expiry: " + User.Expiry;
            label8.Text = "Last Login: " + User.LastLogin;
            label9.Text = "Register Date: " + User.RegisterDate;
            pnlogin.Text = User.Username;
        }

        private void validapi_Click(object sender, EventArgs e)
        {
            if (API.ExtendSubscription(pnlogin.Text, passapi.Text, apiadd.Text))
            {
                MessageBox.Show("License Valid !");
                API.Log(pnlogin.Text, "Extend Subscription");
            }
            else
            {
                //Message Error API.cs
                MessageBox.Show("Error");
            }
        }

        private void convalid_Click(object sender, EventArgs e)
        {
            if (API.Login(pnlogin.Text, conlogin.Text))
            {
                passapi.Text = conlogin.Text;
                panelpass.Visible = false;
                panelinfos.Visible = true;
                MessageBox.Show("Password Correct !");
            }
            else
            {

            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (API.Login(pnlogin.Text, passapi.Text))
            {
                MessageBox.Show("Refresh All Information !");
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
