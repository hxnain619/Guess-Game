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
    public partial class SecondaryGame : Form
    {
        public SecondaryGame()
        {
            InitializeComponent();
        }
        public int rand_num, lives = 3;
        public WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void label2_Click(object sender, EventArgs e)
        {
            User_Level back = new User_Level();
            this.Hide();
            back.Show();
            
        }

        private void SecondaryGame_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            GenerateNumber();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateNumber();
        }

        private void GenerateNumber()
        {
            Random num = new Random();
            rand_num = num.Next(1, 9);
            lives = 3;
            life.Text = lives.ToString();
            EnableAllButtons();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CheckTheNumber(Int16.Parse(btn1.Text));
        }

        private void CheckTheNumber(short v)
        {
            
            --lives;
            if (lives != 0 )
            {
                if (v == rand_num)
                {
                    // success
                    alert.Visible = true;
                    alert_message.Text = "Hooray!!, you guessed it right.";
                    DisableAllButtons();
                    wplayer.URL = @"C:\Users\Perfect\Desktop\success.mp3";
                    wplayer.controls.play();
                    SetTimeout(3000, () =>
                    {
                        alert.Visible = false;
                        alert_message.Text = String.Empty;
                        button1.Enabled = true;
                        wplayer.controls.stop();
                    });
                }
                else
                {
                    alert.Visible = true;
                    alert_message.Text = "You just guessed it wrong.";
                    DisableAllButtons();
                    SetTimeout(500, () =>
                    {
                        alert.Visible = false;
                        alert_message.Text = String.Empty;
                        EnableAllButtons();
                    });
                }
            }else
            {
                // failed
                alert.Visible = true;
                alert_message.Text = "You just lost it.";
                wplayer.URL = @"C:\Users\Perfect\Desktop\failure.mp3";
                wplayer.controls.play();
                SetTimeout(3000, () =>
                {
                    alert.Visible = false;
                    alert_message.Text = String.Empty;
                    wplayer.controls.stop();
                });
                button1.Enabled = true;
                DisableAllButtons();
            }
            life.Text = lives.ToString();

        }

        private void DisableAllButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        private void EnableAllButtons()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private Timer[] timerList = new Timer[100];
        private int timerMaxIndex = -1;
        public int SetTimeout(int time, Action function)
        {
            Timer tmr = new Timer();
            tmr.Interval = time;
            tmr.Tick += new EventHandler(delegate (object s, EventArgs ev)
            {
                function();
                tmr.Stop();
            });
            tmr.Start();

            timerMaxIndex++;
            var index = timerMaxIndex;
            timerList[timerMaxIndex] = tmr;
            return index;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            CheckTheNumber(Int16.Parse(btn2.Text));
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CheckTheNumber(Int16.Parse(btn3.Text));
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CheckTheNumber(Int16.Parse(btn4.Text));
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CheckTheNumber(Int16.Parse(btn5.Text));
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CheckTheNumber(Int16.Parse(btn6.Text));
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CheckTheNumber(Int16.Parse(btn7.Text));
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CheckTheNumber(Int16.Parse(btn8.Text));
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            CheckTheNumber(Int16.Parse(btn9.Text));
        }
    }
}
