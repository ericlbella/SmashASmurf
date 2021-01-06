using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashASmurf
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        int locationNumber = 0;
        int score = 0;
        int misses = 0;
        bool isHit = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gotSmurf(object sender, EventArgs e)
        {
            score++;
            Smurf.Image = Properties.Resources.GrouchySmurf;
            isHit = true;
            Smurf.Enabled = false;
        }
        
        private void moveSmurf()
        {
            isHit = false;
            Smurf.Enabled = true;
            Smurf.Image = Properties.Resources.Smurf;
            Smurf.BackColor = System.Drawing.Color.Transparent;

            locationNumber = random.Next(1, 7);
            
            switch(locationNumber)
            {
                case 1:
                    Smurf.Left = 434;
                    Smurf.Top = 249;
                    break;
                case 2:
                    Smurf.Left = 257;
                    Smurf.Top = 211;
                    break;
                case 3:
                    Smurf.Left = 58;
                    Smurf.Top = 240;
                    break;
                case 4:
                    Smurf.Left = 85;
                    Smurf.Top = 318;
                    break;
                case 5:
                    Smurf.Left = 254;
                    Smurf.Top = 364;
                    break;
                case 6:
                    Smurf.Left = 416;
                    Smurf.Top = 323;
                    break;
                default:
                    break;

            }

        }
        private void moveSmurf(object sender, EventArgs e)
        {
            lblHit.Text = "Hit: " + score;
            lblMiss.Text = "Miss: " + misses;

            if (isHit == false)
            {
                misses++;
            }
            if (score > 9)
            {
                timer1.Stop();
                Smurf.Enabled = false;
                MessageBox.Show("You Win");
            }
            else if (misses > 5)
            {
                timer1.Stop();
                Smurf.Enabled = false;
                MessageBox.Show("You Lose");
            }
            moveSmurf();
        }
    }
}
