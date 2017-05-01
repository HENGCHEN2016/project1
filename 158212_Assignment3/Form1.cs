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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string countryLeft = "";
        public string countryRight = "";
        // validate if same team are selected maybe in form1
        public void SameTeam()
        {
            if (countryLeft == countryRight)
            {
                F1toF2_button.Enabled = false;
                sameteam_warning.Visible = true;
            }
            else if ((countryLeft != "") && (countryRight != ""))
            {
                F1toF2_button.Enabled = true;
                sameteam_warning.Visible = false;
            }
        }
        private void F1toF2_button_Click(object sender, EventArgs e)
        {
            if(countryLeft==""&&countryRight=="")
            {
                F1toF2_button.Enabled = false;
            }
             else
            {
            Form2 form2 = new Form2(this.countryLeft, this.countryRight);
            form2.Show();
            form2.MatchPlayer();
            this.Hide();
             }
        }
        private void T1_pictureBox_Click(object sender, EventArgs e)
        {
            T1_pictureBox.InitialImage = null;
        }
        private void T2_pictureBox_Click(object sender, EventArgs e)
        {
            T2_pictureBox.InitialImage = null;
        }
        private void NZ_RB1_CheckedChanged(object sender, EventArgs e)
        {
            T1_pictureBox.Load("../../images/NZ.jpg");
            countryLeft = "NZ";
            SameTeam();
        }
        private void USA_RB1_CheckedChanged(object sender, EventArgs e)
        {
            T1_pictureBox.Load("../../images/USA.jpg");
            countryLeft = "USA";
            SameTeam();
        }
        private void GB_RB1_CheckedChanged(object sender, EventArgs e)
        {
            T1_pictureBox.Load("../../images/GB.jpg");
            countryLeft = "GB";
            SameTeam();
        }
        private void NZ_RB2_CheckedChanged_1(object sender, EventArgs e)
        {
            T2_pictureBox.Load("../../images/NZ.jpg");
            countryRight = "NZ";
            SameTeam();
        }

        private void USA_RB2_CheckedChanged_1(object sender, EventArgs e)
        {
            T2_pictureBox.Load("../../images/USA.jpg");
            countryRight = "USA";
            SameTeam();
        }

        private void GB_RB2_CheckedChanged_1(object sender, EventArgs e)
        {
            T2_pictureBox.Load("../../images/GB.jpg");
            countryRight = "GB";
            SameTeam();
        }       
    }
}
