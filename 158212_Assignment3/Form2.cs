using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _158212_Assignment3
{
    public partial class Form2 : Form
    {
        private string countryLeft = "";
        private string countryRight = "";
        public string time = "";
        public int min = 0;
        public int sec = 0;
        public int t1_score = 0;
        public int t2_score = 0;
        public int t1_try_num = 0;
        public int t1_conversion_num = 0;
        public int t1_dropkick_num = 0;
        public int t1_penalty_num = 0;
        public int t2_try_num = 0;
        public int t2_conversion_num = 0;
        public int t2_dropkick_num = 0;
        public int t2_penalty_num = 0;

        public Form2(string countryLeft, string countryRight)
        {
            InitializeComponent();
            this.countryLeft = countryLeft;
            this.countryRight = countryRight;
            if (countryLeft=="NZ")
            {
                F2T1_pictureBox.Load("../../images/NZ.jpg");
            }
            if (countryLeft == "USA")
            {
                F2T1_pictureBox.Load("../../images/USA.jpg");
            }
            if (countryLeft == "GB")
            {
                F2T1_pictureBox.Load("../../images/GB.jpg");
            }
            if (countryRight == "NZ")
            {
                F2T2_pictureBox.Load("../../images/NZ.jpg");
            }
            if (countryRight == "USA")
            {
                F2T2_pictureBox.Load("../../images/USA.jpg");
            }
            if (countryRight == "GB")
            {
                F2T2_pictureBox.Load("../../images/GB.jpg");
            }
            match_timer.Enabled = true;
        }


        public void Stop()
        {
            End_button.Enabled = false;
            match_timer.Enabled = false;
            Pause_button.Enabled = false;          
            T1_comboBox.Enabled = false;
            T2_comboBox.Enabled = false;
            MatchResult();
        }

        public void MatchPlayer()
        {
            if (countryLeft == "NZ")
            {
                T1_comboBox.Items.AddRange(new object[] { "Nike Paul", "Adi Nasus", "James York" });
            }
            if (countryLeft == "USA")
            {
                T1_comboBox.Items.AddRange(new object[] { "Bill Hali", "Zak Vafolio", "Keny Lee" });
            }
            if (countryLeft == "GB")
            {
                T1_comboBox.Items.AddRange(new object[] { "William Ford", "Gate Sally", "Larry Johnson" });
            }
            if (countryRight == "NZ")
            {
                T2_comboBox.Items.AddRange(new object[] { "Nike Paul", "Adi Nasus", "James York" });
            }
            if (countryRight == "USA")
            {
                T2_comboBox.Items.AddRange(new object[] { "Bill Hali", "Zak Vafolio", "Keny Lee" });
            }
            if (countryRight == "GB")
            {
                T2_comboBox.Items.AddRange(new object[] { "William Ford", "Gate Sally", "Larry Johnson" });
            }
        }

        public void Timer()
        {
            time = min.ToString("00") + ":" + sec.ToString("00");
            if(sec==59)
            {
                min++;
                sec = 0;
            }
            else
            {
                sec++;
            }
            time_label.Text = time;
        }

        //-------------SCORING SYSTEM-----------------
        public void Team1Try()
        {
            t1_score += 5;
            T1score_label.Text = t1_score.ToString();
            F2_richTextBox.Text += countryLeft + " scored a try at " + time_label.Text + " by " + T1_comboBox.Text + "\n";
            t1_try_num++;
        }
        public void Team1Conversion()
        {
            t1_score += 2;
            T1score_label.Text = t1_score.ToString();
            F2_richTextBox.Text += countryLeft + " converted at " + time_label.Text + " by " + T1_comboBox.Text + "\n";
            t1_conversion_num++;
        }

        public void Team1DropKick()
        {
            t1_score += 3;
            T1score_label.Text = t1_score.ToString();
            F2_richTextBox.Text += countryLeft + " scored a drop-kick at " + time_label.Text + " by " + T1_comboBox.Text + "\n";
            t1_dropkick_num++;
        }

        public void Team1Penalty()
        {
            t1_score += 3;
            T1score_label.Text = t1_score.ToString();
            F2_richTextBox.Text += countryLeft + " scored a penalty at " + time_label.Text + " by " + T1_comboBox.Text + "\n";
            t1_penalty_num++;
        }

        public void Team2Try()
        {
            t2_score += 5;
            T2score_label.Text = t2_score.ToString();
            F2_richTextBox.Text += countryRight + " scored a try at " + time_label.Text + " by " + T2_comboBox.Text + "\n";
            t2_try_num++;
        }
        public void Team2Conversion()
        {
            t2_score += 2;
            T2score_label.Text = t2_score.ToString();
            F2_richTextBox.Text += countryRight + " converted at " + time_label.Text + " by " + T2_comboBox.Text + "\n";
            t2_conversion_num++;
        }

        public void Team2DropKick()
        {
            t2_score += 3;
            T2score_label.Text = t2_score.ToString();
            F2_richTextBox.Text += countryRight + " scored a drop-kick at " + time_label.Text + " by " + T2_comboBox.Text + "\n";
            t2_dropkick_num++;
        }

        public void Team2Penalty()
        {
            t2_score += 3;
            T2score_label.Text = t2_score.ToString();
            F2_richTextBox.Text += countryRight + " scored a penalty at " + time_label.Text + " by " + T2_comboBox.Text + "\n";
            t2_penalty_num++;
        }

        //match result and feedback to richbox
        public void MatchResult()
        {
            F2_richTextBox.Text += "====== MATCH STATS ======\n";
            if(t1_score == t2_score)
            {
                F2_richTextBox.Text += "Match is drawn.\n";
            }
            if(t1_score>t2_score)
            {
                F2_richTextBox.Text += "Winner is " + countryLeft + "\n";
            }
            if(t1_score<t2_score)
            {
                F2_richTextBox.Text += "Winner is " + countryRight + "\n";
            }
            //team 1 match stats
            F2_richTextBox.Text += "======================\n";
            F2_richTextBox.Text += countryLeft + " stats:\n";
            F2_richTextBox.Text += "Tries: " + t1_try_num.ToString() + "\n";
            F2_richTextBox.Text += "Conversions: " + t1_conversion_num.ToString() + "\n";
            F2_richTextBox.Text += "Drop-Kicks: " + t1_dropkick_num.ToString() + "\n";
            F2_richTextBox.Text += "Penalties: " + t1_penalty_num.ToString() + "\n";
            // team 2 match stats
            F2_richTextBox.Text += "======================\n";
            F2_richTextBox.Text += countryRight + " stats:\n";
            F2_richTextBox.Text += "Tries: " + t2_try_num.ToString() + "\n";
            F2_richTextBox.Text += "Conversions: " + t2_conversion_num.ToString() + "\n";
            F2_richTextBox.Text += "Drop-Kicks: " + t2_dropkick_num.ToString() + "\n";
            F2_richTextBox.Text += "Penalties: " + t2_penalty_num.ToString() + "\n";
        }
        
        private void match_timer_Tick(object sender, EventArgs e)
        {
            Timer();
        }
        private void Pause_button_Click(object sender, EventArgs e)
        {
            if (Pause_button.Text == "Pause")
            {
                match_timer.Enabled = false;
                Pause_button.Text = "Continue";
            }
            else
            {
                match_timer.Enabled = true;
                Pause_button.Text = "Pause";
            }
        }

        private void T1try_button_Click(object sender, EventArgs e)
        {
            Team1Try();
        }

        private void T1c_button_Click(object sender, EventArgs e)
        {
            Team1Conversion();
        }

        private void T1p_button_Click(object sender, EventArgs e)
        {
            Team1Penalty();
        }

        private void T1DK_button_Click(object sender, EventArgs e)
        {
            Team1DropKick();
        }

        private void T2t_button_Click(object sender, EventArgs e)
        {
            Team2Try();
        }

        private void T2c_button_Click(object sender, EventArgs e)
        {
            Team2Conversion();
        }

        private void T2p_button_Click(object sender, EventArgs e)
        {
            Team2Penalty();
        }

        private void T2dk_button_Click(object sender, EventArgs e)
        {
            Team2DropKick();
        }

        private void End_button_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void T1_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            T1try_button.Enabled = true;
            T1c_button.Enabled = true;
            T1DK_button.Enabled = true;
            T1p_button.Enabled = true;
            T1_no_player_label.Visible = false;
            if (Pause_button.Text == "Pause")
            {
                T1_score_groupBox.Enabled = true;
            } 
        }
        private void T2_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            T2t_button.Enabled = true;
            T2c_button.Enabled = true;
            T2dk_button.Enabled = true;
            T2p_button.Enabled = true;
            T2_no_player_label.Visible = false;
            if (Pause_button.Text == "Pause")
            {
                T2_score_groupBox.Enabled = true;
            }
        }
    }
}
