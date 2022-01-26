using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace joc_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            over.Visible = false;
            label1.Visible = false;
            play.Visible = false;

            //dispare tot pana dai playy
            pause.Visible = false;
            player.Visible = false;
            e_1.Visible = false;
            e_2.Visible = false;
            e_3.Visible = false;
            e_1_poc.Visible = false;
            e_2_poc.Visible = false;
            e_3_poc.Visible = false;
            timer1.Stop();
        }

        int score, count_kill, viteza = 0;
        string nick="";

        void verific()
        {
            if (score == 100)
            {
                viteza += 1;
            }

            if (score == 200)
            {
                viteza += 1;
            }
        }

        void rezultate()
        {
            foreach(Control j in this.Controls)
            {
                if(j is PictureBox && j.Tag=="enemy")
                {
                    //puncte daca omor chestii
                    if(bullett.Bounds.IntersectsWith(j.Bounds))
                    {
                        score += 5;
                        count_kill++;
                        scor_count.Text = "SCOR:" + score;
                        kill.Text = "Kill:" + count_kill;
                        j.Left = 1500;
                        bullett.Image = Properties.Resources.explosion;
                    }

                    if (player.Bounds.IntersectsWith(j.Bounds))
                    {
                        System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Necazu\source\repos\joc v2\joc v2\Resources\Game Over Sound Effect.wav");
                        sound.Play();
                        over.Visible = true;
                        label1.Visible = true;
                        player.Image = Properties.Resources.explosion;
                        timer1.Stop();
                        e_1.Left = 700;
                        e_2.Left = 700;
                        e_3.Left = 700;
                        e_1_poc.Left = 650;
                        e_2_poc.Left = 650;
                        e_3_poc.Left = 650;
                        astero1.Left = 400;
                        astero2.Left = 500;
                    }
                }
            }
        }

        void Bullett()
        {
            //jucator
            bullett.Left += 100;
            if (bullett.Left > 600)
            {
                bullett.Invalidate();
                bullett.Image = Properties.Resources.bullett;
                bullett.Left = player.Left;
                bullett.Top = player.Top + 30;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Necazu\source\repos\joc v2\joc v2\Resources\pewpew.wav");
                sound.Play();
               
            }

            //adversari
            int vit2;
            vit2 = 20 + viteza;
            e_1_poc.Left -= vit2;
            if (e_1_poc.Left < 0)
            {
                e_1_poc.Invalidate();
                e_1_poc.Left = e_1.Left;
                e_1_poc.Top = e_1.Top + 30;
            }

            e_2_poc.Left -= vit2;
            if (e_2_poc.Left < 0)
            {
                e_2_poc.Invalidate();
                e_2_poc.Left = e_2.Left;
                e_2_poc.Top = e_2.Top + 30;
            }

            e_3_poc.Left -= vit2;
            if (e_3_poc.Left < 0)
            {
                e_3_poc.Invalidate();
                e_3_poc.Left = e_3.Left;
                e_3_poc.Top = e_3.Top + 25;
            }


        }
        void Stars()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "star")
                {
                    x.Left -= 5;
                    if(x.Left<0)
                    {
                        x.Left = 800;
                    }
                }
            }
        }

        void Asteroizi()
        {
            Random rnd = new Random();
            int x, y,vit2;
            vit2 = 2+viteza;
            astero1.Left -= vit2;
            if(astero1.Left<0)
            {
                astero1.Invalidate();
                x = rnd.Next(0, 400);
                astero1.Invalidate();
                astero1.Location = new Point(800, x);
            }

            astero2.Left -= vit2;
            if (astero2.Left < 0)
            {
                astero2.Invalidate();
                y = rnd.Next(0, 500);
                astero2.Invalidate();
                astero2.Location = new Point(800, y);
            }
        }

        void enemy()
        {
            Random rnd = new Random();
            int a, b, c,vit2;
            vit2 = viteza + 10;
            e_1.Left -= vit2;
            if(e_1.Left<0)
            {
                a = rnd.Next(0,200);
                e_1.Invalidate();
                e_1.Location = new Point(800, a);
            }
            e_2.Left -= vit2;
            if (e_2.Left < 0)
            {
                b = rnd.Next(0, 200);
                e_2.Invalidate();
                e_2.Location = new Point(800, b);
            }
            e_3.Left -= vit2;
            if (e_3.Left < 0)
            {
                c = rnd.Next(0, 500);
                e_3.Invalidate();
                e_3.Location = new Point(800, c);
            }
        }

        void update_scor()
        {
            SqlCommand cmd;
            SqlConnection con;
            SqlDataAdapter da;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Necazu\Documents\joc.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            cmd = new SqlCommand("Update scoruri set scor=@scor Where name=@name", con);
            cmd.Parameters.Add("name", nick);
            cmd.Parameters.Add("scor", score);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        void clasament()
        {
            SqlCommand cmd;
            SqlConnection con;
            SqlDataAdapter sda;
            DataTable dt;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Necazu\Documents\joc.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            cmd= new SqlCommand("select * from scoruri order by scor desc",con);
  
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            n1.Text = reader["name"].ToString();
            s1.Text = reader["scor"].ToString();
            reader.Read();
            n2.Text = reader["name"].ToString();
            s2.Text = reader["scor"].ToString();
            reader.Read();
            n3.Text = reader["name"].ToString();
            s3.Text = reader["scor"].ToString();
            reader.Read();
            n4.Text = reader["name"].ToString();
            s4.Text = reader["scor"].ToString();
            reader.Read();
            n5.Text = reader["name"].ToString();
            s5.Text = reader["scor"].ToString();
            reader.Close();
            reader.Close();
            reader.Close();
            reader.Close();
            reader.Close();

            con.Close();

            //sda.Fill(dt);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (player.Top > 20)
                {
                    player.Invalidate();
                    player.Top -= 5;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (player.Top < 350)
                {
                    player.Invalidate();
                    player.Top += 5;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bullett();
            Stars();
            Asteroizi();
            enemy();
            rezultate();
            verific();
            update_scor();
            clasament();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            player.Image = Properties.Resources.player;
            score -=score;
            count_kill -= count_kill;
            over.Visible = false;
            label1.Visible = false;
            viteza = 0;

        }

        private void pause_Click(object sender, EventArgs e)
        {
            pause.Visible = false;
            timer1.Stop();
            play.Visible = true;
 
        }

        private void play_Click(object sender, EventArgs e)
        {
            pause.Visible = true;
            play.Visible = false;
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection con;
            SqlDataAdapter sda;
            DataTable dt;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Necazu\Documents\joc.mdf;Integrated Security=True;Connect Timeout=30;");
            sda = new SqlDataAdapter("select Count(*) from scoruri where name ='" + textBox1.Text +"'", con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                nick = textBox1.Text;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Dispose();
                pause.Visible = true;
                player.Visible = true;
                e_1.Visible = true;
                e_2.Visible = true;
                e_3.Visible = true;
                e_1_poc.Visible = true;
                e_2_poc.Visible = true;
                e_3_poc.Visible = true;
                timer1.Start();
            }
            else
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Necazu\Documents\joc.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                cmd = new SqlCommand("insert into scoruri (name, scor) values (@name,@scor)", con);
                cmd.Parameters.Add("@name", textBox1.Text);
                cmd.Parameters.Add("@scor", "0");
                cmd.ExecuteNonQuery();
                con.Close();
                nick = textBox1.Text;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Dispose();
                pause.Visible = true;
                player.Visible = true;
                e_1.Visible = true;
                e_2.Visible = true;
                e_3.Visible = true;
                e_1_poc.Visible = true;
                e_2_poc.Visible = true;
                e_3_poc.Visible = true;
                timer1.Start();
                
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
