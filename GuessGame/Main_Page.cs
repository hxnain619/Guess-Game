using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }
        String user_name = "hxan619";
        String user_password = "hxan619";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            error.Text = String.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            error.Text = String.Empty;
        }

      

        private void proceed_Click(object sender, EventArgs e)
        {
            User_Level seconds_page = new User_Level();

            if(email.Text == user_name && password.Text == user_password)
            {
            this.Hide();
            seconds_page.Show();
            error.Text = String.Empty;
            }else
            {
                error.Text = "Email or Password is incorrect.";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            email.Text = String.Empty;
            password.Text = String.Empty;
        }
    }
}
