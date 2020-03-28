using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class User_Level : Form
    {
        public User_Level()
        {
            InitializeComponent();
            //  Primary hover and onClick functions
            primary_screen.MouseHover += PrimaryBGChange;
            p_btn.MouseHover += PrimaryBGChange;

            primary_screen.MouseLeave += PrimaryBgOriginal;

            //  Secondary hover and onClick functions
            secondary_screen.MouseHover += SecondaryBGChange;
            s_btn.MouseHover += SecondaryBGChange;

            secondary_screen.MouseLeave += SecondaryBgOriginal;
        }
        private void SecondaryBgOriginal(object sender, EventArgs e)
        {
            secondary_screen.BackColor = Color.White;
        }

        private void PrimaryBgOriginal(object sender, EventArgs e)
        {
            primary_screen.BackColor = Color.FromArgb(227, 5, 38);
        }

        private void SecondaryBGChange(object sender, EventArgs e)
        {
            secondary_screen.BackColor = Color.FromArgb(239, 239, 239);
        }

        private void PrimaryBGChange(object sender, EventArgs e)
        {
            primary_screen.BackColor = Color.FromArgb(227, 18, 50);
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowSecondary(object sender, EventArgs e)
        {
            SecondaryGame page2 = new SecondaryGame();
            this.Hide();
            page2.Show();
        }

        private void ShowPrimary(object sender, EventArgs e)
        {
            PrimaryGame page = new PrimaryGame();
            this.Hide();
            page.Show();
        }
        
        private void s_btn_Click(object sender, EventArgs e)
        {
            SecondaryGame page2 = new SecondaryGame();
            this.Hide();
            page2.Show();
        }

        private void p_btn_Click(object sender, EventArgs e)
        {
            PrimaryGame page = new PrimaryGame();
            this.Hide();
            page.Show();
        }

        private void User_Level_Load(object sender, EventArgs e)
        {
            username.Text = "Hello, Hxnain";
        }
    }
}
