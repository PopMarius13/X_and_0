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
    public partial class PlayerVsPlayer : Form
    {
        int p1 = 0, p2 = 0,p=0;
        public int[][] a = new int[4][];
        evaluare b ;
        public PlayerVsPlayer()
        {
            InitializeComponent();
            a[1] = new int[4];
            a[2] = new int[4];
            a[3] = new int[4];
        }
        public void viz1 ()
        {
            a11.Visible = false;
            a12.Visible = false;
            a13.Visible = false;
            a21.Visible = false;
            a22.Visible = false;
            a23.Visible = false;
            a31.Visible = false;
            a32.Visible = false;
            a33.Visible = false;
            Turn.Visible = false;
            label1.Visible = false;
            Exit1.Visible = false;
        }
        public void viz2()
        {
            a11.Visible = true;
            a12.Visible = true;
            a13.Visible = true;
            a21.Visible = true;
            a22.Visible = true;
            a23.Visible = true;
            a31.Visible = true;
            a32.Visible = true;
            a33.Visible = true;
            Turn.Visible = true;
            label1.Visible = true;
            Exit1.Visible = true;
        }
        private void a11_Click(object sender, EventArgs e)
        {
            if (a11.Text == "")
            {
                if (p == 0)
                {
                    a11.Text = "X";
                    a[1][1] = 1;
                    p = 1;
                    Turn.Text = "Player2";
                    b = new evaluare(a);
                    if(b.ras()==1)
                    {
                        p1++;
                        NewGame.Visible = true;
                        Rematch.Visible = true;
                        Exit2.Visible = true;
                        Player1.Text = Convert.ToString(p1);
                        viz1();
                        p1w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                        NewGame.Visible = true;
                        Rematch.Visible = true;
                        Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }

                }
                else
                {
                    a11.Text = "O";
                    a[1][1] = 2;
                    Turn.Text = "Player1";
                    p = 0;
                    b = new evaluare(a);
                    if (b.ras() == 1)
                    {
                        p2++;
                        NewGame.Visible = true;
                        Rematch.Visible = true;
                        Exit2.Visible = true;
                        Player2.Text = Convert.ToString(p2);
                        viz1();
                        p2w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                        NewGame.Visible = true;
                        Rematch.Visible = true;
                        Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }
                }
                
            }
        }

        private void a12_Click(object sender, EventArgs e)
        {
            if (a12.Text == "")
                if (p == 0)
                {
                    a12.Text = "X";
                    a[1][2] = 1;
                    p = 1;
                    Turn.Text = "Player2";
                    b = new evaluare(a);
                    if (b.ras() == 1)
                    {
                        p1++;
                        NewGame.Visible = true;
                        Rematch.Visible = true;
                        Exit2.Visible = true;
                        Player1.Text = Convert.ToString(p1);
                        viz1();
                        p1w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                        NewGame.Visible = true;
                        Rematch.Visible = true;
                        Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }

                }
                else
                {
                    a12.Text = "O";
                    a[1][2] = 2;
                    Turn.Text = "Player1";
                    p = 0;
                    b = new evaluare(a);
                    if (b.ras() == 1)
                    {
                        p2++;
                        NewGame.Visible = true;
                        Rematch.Visible = true;
                        Exit2.Visible = true;
                        Player2.Text = Convert.ToString(p2);
                        viz1();
                        p2w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                        NewGame.Visible = true;
                        Rematch.Visible = true;
                        Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }
                } 
        }

        private void a13_Click(object sender, EventArgs e)
        {
            if (a13.Text == "")
                if (p == 0)
            {
                a13.Text = "X";
                a[1][3] = 1;
                p = 1;
                Turn.Text = "Player2";
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p1++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player1.Text = Convert.ToString(p1);
                        viz1();
                        p1w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }

            }
            else
            {
                a13.Text = "O";
                a[1][3] = 2;
                Turn.Text = "Player1";
                p = 0;
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p2++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player2.Text = Convert.ToString(p2);
                        viz1();
                        p2w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }
            }
        }

        private void a21_Click(object sender, EventArgs e)
        {
            if (a21.Text == "")
                if (p == 0)
            {
                a21.Text = "X";
                a[2][1] = 1;
                p = 1;
                Turn.Text = "Player2";
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p1++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player1.Text = Convert.ToString(p1);
                        viz1();
                        p1w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }

            }
            else
            {
                a21.Text = "O";
                a[2][1] = 2;
                Turn.Text = "Player1";
                p = 0;
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p2++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player2.Text = Convert.ToString(p2);
                        viz1();
                        p2w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }
            }
        }

        private void a22_Click(object sender, EventArgs e)
        {
            if (a22.Text == "")
                if (p == 0)
            {
                a22.Text = "X";
                a[2][2] = 1;
                p = 1;
                Turn.Text = "Player2";
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p1++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player1.Text = Convert.ToString(p1);
                        viz1();
                        p1w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }

            }
            else
            {
                a22.Text = "O";
                a[2][2] = 2;
                Turn.Text = "Player1";
                p = 0;
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p2++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player2.Text = Convert.ToString(p2);
                        viz1();
                        p2w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }
            }
        }

        private void a23_Click(object sender, EventArgs e)
        {
            if (a23.Text == "")
                if (p == 0)
            {
                a23.Text = "X";
                a[2][3] = 1;
                p = 1;
                Turn.Text = "Player2";
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p1++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player1.Text = Convert.ToString(p1);
                        viz1();
                        p1w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }

            }
            else
            {
                a23.Text = "O";
                a[2][3] = 2;
                Turn.Text = "Player1";
                p = 0;
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p2++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player2.Text = Convert.ToString(p2);
                        viz1();
                        p2w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }
            }
        }
        
        private void a31_Click(object sender, EventArgs e)
        {
            if (a31.Text == "")
                if (p == 0)
            {
                a31.Text = "X";
                a[3][1] = 1;
                p = 1;
                Turn.Text = "Player2";
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p1++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player1.Text = Convert.ToString(p1);
                        viz1();
                        p1w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }

            }
            else
            {
                a31.Text = "O";
                a[3][1] = 2;
                Turn.Text = "Player1";
                p = 0;
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p2++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player2.Text = Convert.ToString(p2);
                        viz1();
                        p2w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }
            }
        }

        private void a32_Click(object sender, EventArgs e)
        {
            if (a32.Text == "")
                if (p == 0)
            {
                a32.Text = "X";
                a[3][2] = 1;
                p = 1;
                Turn.Text = "Player2";
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p1++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player1.Text = Convert.ToString(p1);
                        viz1();
                        p1w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }

            }
            else
            {
                a32.Text = "O";
                a[3][2] = 2;
                Turn.Text = "Player1";
                p = 0;
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p2++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player2.Text = Convert.ToString(p2);
                        viz1();
                        p2w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }
            }
        }

        private void a33_Click(object sender, EventArgs e)
        {
            if (a33.Text == "")
                if (p == 0)
            {
                a33.Text = "X";
                a[3][3] = 1;
                p = 1;
                Turn.Text = "Player2";
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p1++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player1.Text = Convert.ToString(p1);
                        viz1();
                        p1w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }

            }
            else
            {
                a33.Text = "O";
                a[3][3] = 2;
                Turn.Text = "Player1";
                p = 0;
                b = new evaluare(a);
                if (b.ras() == 1)
                {
                    p2++;
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                    Player2.Text = Convert.ToString(p2);
                        viz1();
                        p2w.Visible = true;
                    }
                    else
                    if (b.ras() == 2)
                    {
                    NewGame.Visible = true;
                    Rematch.Visible = true;
                    Exit2.Visible = true;
                        viz1();
                        draw.Visible = true;
                    }
            }
        }

        private void Turn_Click(object sender, EventArgs e)
        {

        }

        private void Player1_Click(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            NewGame.Visible = false;
            Rematch.Visible = false;
            Exit2.Visible = false;
            a11.Text = "";
            a12.Text = "";
            a13.Text = "";
            a21.Text = "";
            a22.Text = "";
            a23.Text = "";
            a31.Text = "";
            a32.Text = "";
            a33.Text = "";
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                    a[i][j] = 0;
            p1 = p2 = 0;
            Player1.Text = Convert.ToString(p1);
            Player2.Text = Convert.ToString(p2);
            viz2();
            p = 0;
            Turn.Text = "Player1";
            p1w.Visible = false;
            p2w.Visible = false;
            draw.Visible = false;
        }

        private void Rematch_Click(object sender, EventArgs e)
        {
            NewGame.Visible = false;
            Rematch.Visible = false;
            Exit2.Visible = false;
            a11.Text = "";
            a12.Text = "";
            a13.Text = "";
            a21.Text = "";
            a22.Text = "";
            a23.Text = "";
            a31.Text = "";
            a32.Text = "";
            a33.Text = "";
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                    a[i][j] = 0;
            viz2();
            p = 0;
            Turn.Text = "Player1";
            p1w.Visible = false;
            p2w.Visible = false;
            draw.Visible = false;
        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PlayerVsPlayer_Load(object sender, EventArgs e)
        {

        }

        private void Player2_Click(object sender, EventArgs e)
        {

        }

        private void Exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
