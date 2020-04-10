using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int o = 1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void Player_Click(object sender, EventArgs e)
        {
            PlayerVsPlayer a;
            a = new PlayerVsPlayer();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (o == 1)
            {
                this.BackColor = Color.SpringGreen;
                o= 0;
            }
            else
            {
                this.BackColor = Color.Cyan;
                o = 1;
            }
        }
    }
}
