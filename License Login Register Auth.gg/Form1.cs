using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace License_Login_Register_Auth.gg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                Application.Exit();
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panellogin.BringToFront();
            guna2Transition1.Hide(panellogin);
        }

        private void gologin_Click(object sender, EventArgs e)
        {
            panellogin.BringToFront();
            guna2Transition1.Show(panellogin);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/3t2568W");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/3t2568W");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the administrator of the application");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the administrator of the application");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (API.Login(pnlogin.Text, pnpass.Text))
            {
                timer2.Start();
                //MessageBox.Show("Login Success !");
            }
            else
            {
                //Never
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                base.Hide();
                new home().Show();
                timer2.Stop();
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (API.Register(reuser.Text, repass.Text, remail.Text, rekey.Text))
            {
                MessageBox.Show("Success Register !");
                panellogin.BringToFront();
                guna2Transition1.Show(panellogin);
            }
        }

        private void pnlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.PerformClick();
                e.Handled = true;
            }
        }

        private void pnpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.PerformClick();
                e.Handled = true;
            }
        }

        private void remail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register.PerformClick();
                e.Handled = true;
            }
        }

        private void repass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register.PerformClick();
                e.Handled = true;
            }
        }

        private void reuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register.PerformClick();
                e.Handled = true;
            }
        }

        private void rekey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register.PerformClick();
                e.Handled = true;
            }
        }
    }
}
