
namespace joc_v2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bullett = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.astero1 = new System.Windows.Forms.PictureBox();
            this.astero2 = new System.Windows.Forms.PictureBox();
            this.e_1 = new System.Windows.Forms.PictureBox();
            this.e_2 = new System.Windows.Forms.PictureBox();
            this.e_3 = new System.Windows.Forms.PictureBox();
            this.e_1_poc = new System.Windows.Forms.PictureBox();
            this.e_2_poc = new System.Windows.Forms.PictureBox();
            this.e_3_poc = new System.Windows.Forms.PictureBox();
            this.kill = new System.Windows.Forms.Label();
            this.scor_count = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.s3 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.s4 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.s5 = new System.Windows.Forms.Label();
            this.n5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullett)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1_poc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2_poc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3_poc)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::joc_v2.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(12, 191);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(104, 93);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bullett
            // 
            this.bullett.BackColor = System.Drawing.Color.Transparent;
            this.bullett.Image = global::joc_v2.Properties.Resources.bullett;
            this.bullett.Location = new System.Drawing.Point(122, 220);
            this.bullett.Name = "bullett";
            this.bullett.Size = new System.Drawing.Size(58, 44);
            this.bullett.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullett.TabIndex = 1;
            this.bullett.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox1.Location = new System.Drawing.Point(491, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "star";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox2.Location = new System.Drawing.Point(245, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "star";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox3.Location = new System.Drawing.Point(292, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "star";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox4.Location = new System.Drawing.Point(536, 346);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "star";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox5.Location = new System.Drawing.Point(79, 346);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "star";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox6.Location = new System.Drawing.Point(79, 113);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "star";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox7.Location = new System.Drawing.Point(560, 155);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "star";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox8.Location = new System.Drawing.Point(320, 364);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 34);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "star";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox9.Location = new System.Drawing.Point(692, 75);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(37, 34);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "star";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox10.Location = new System.Drawing.Point(703, 284);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(26, 28);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "star";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox11.Location = new System.Drawing.Point(226, 310);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(27, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 12;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "star";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::joc_v2.Properties.Resources.star;
            this.pictureBox12.Location = new System.Drawing.Point(663, 430);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(34, 35);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 13;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "star";
            // 
            // astero1
            // 
            this.astero1.BackColor = System.Drawing.Color.Transparent;
            this.astero1.Image = global::joc_v2.Properties.Resources.asteroied1;
            this.astero1.Location = new System.Drawing.Point(373, 333);
            this.astero1.Name = "astero1";
            this.astero1.Size = new System.Drawing.Size(125, 116);
            this.astero1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.astero1.TabIndex = 14;
            this.astero1.TabStop = false;
            this.astero1.Tag = "enemy";
            // 
            // astero2
            // 
            this.astero2.BackColor = System.Drawing.Color.Transparent;
            this.astero2.Image = global::joc_v2.Properties.Resources.asteroid2;
            this.astero2.Location = new System.Drawing.Point(515, 57);
            this.astero2.Name = "astero2";
            this.astero2.Size = new System.Drawing.Size(147, 101);
            this.astero2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.astero2.TabIndex = 15;
            this.astero2.TabStop = false;
            this.astero2.Tag = "enemy";
            // 
            // e_1
            // 
            this.e_1.BackColor = System.Drawing.Color.Transparent;
            this.e_1.Image = global::joc_v2.Properties.Resources.e1;
            this.e_1.Location = new System.Drawing.Point(703, -2);
            this.e_1.Name = "e_1";
            this.e_1.Size = new System.Drawing.Size(86, 81);
            this.e_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_1.TabIndex = 16;
            this.e_1.TabStop = false;
            this.e_1.Tag = "enemy";
            // 
            // e_2
            // 
            this.e_2.BackColor = System.Drawing.Color.Transparent;
            this.e_2.Image = global::joc_v2.Properties.Resources.e2;
            this.e_2.Location = new System.Drawing.Point(703, 171);
            this.e_2.Name = "e_2";
            this.e_2.Size = new System.Drawing.Size(86, 74);
            this.e_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_2.TabIndex = 17;
            this.e_2.TabStop = false;
            this.e_2.Tag = "enemy";
            // 
            // e_3
            // 
            this.e_3.BackColor = System.Drawing.Color.Transparent;
            this.e_3.Image = global::joc_v2.Properties.Resources.e3;
            this.e_3.Location = new System.Drawing.Point(703, 346);
            this.e_3.Name = "e_3";
            this.e_3.Size = new System.Drawing.Size(86, 77);
            this.e_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_3.TabIndex = 18;
            this.e_3.TabStop = false;
            this.e_3.Tag = "enemy";
            // 
            // e_1_poc
            // 
            this.e_1_poc.BackColor = System.Drawing.Color.Transparent;
            this.e_1_poc.Image = global::joc_v2.Properties.Resources.e1bullet;
            this.e_1_poc.Location = new System.Drawing.Point(644, 35);
            this.e_1_poc.Name = "e_1_poc";
            this.e_1_poc.Size = new System.Drawing.Size(71, 34);
            this.e_1_poc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_1_poc.TabIndex = 19;
            this.e_1_poc.TabStop = false;
            this.e_1_poc.Tag = "enemy";
            // 
            // e_2_poc
            // 
            this.e_2_poc.BackColor = System.Drawing.Color.Transparent;
            this.e_2_poc.Image = global::joc_v2.Properties.Resources.e2bullet;
            this.e_2_poc.Location = new System.Drawing.Point(626, 189);
            this.e_2_poc.Name = "e_2_poc";
            this.e_2_poc.Size = new System.Drawing.Size(62, 56);
            this.e_2_poc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_2_poc.TabIndex = 20;
            this.e_2_poc.TabStop = false;
            this.e_2_poc.Tag = "enemy";
            // 
            // e_3_poc
            // 
            this.e_3_poc.BackColor = System.Drawing.Color.Transparent;
            this.e_3_poc.Image = global::joc_v2.Properties.Resources.e3bullet;
            this.e_3_poc.Location = new System.Drawing.Point(626, 374);
            this.e_3_poc.Name = "e_3_poc";
            this.e_3_poc.Size = new System.Drawing.Size(71, 34);
            this.e_3_poc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_3_poc.TabIndex = 21;
            this.e_3_poc.TabStop = false;
            this.e_3_poc.Tag = "enemy";
            // 
            // kill
            // 
            this.kill.AutoSize = true;
            this.kill.BackColor = System.Drawing.Color.Transparent;
            this.kill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kill.ForeColor = System.Drawing.Color.Red;
            this.kill.Location = new System.Drawing.Point(108, 9);
            this.kill.Name = "kill";
            this.kill.Size = new System.Drawing.Size(72, 29);
            this.kill.TabIndex = 22;
            this.kill.Text = "Kill:0";
            // 
            // scor_count
            // 
            this.scor_count.AutoSize = true;
            this.scor_count.BackColor = System.Drawing.Color.Transparent;
            this.scor_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scor_count.ForeColor = System.Drawing.Color.White;
            this.scor_count.Location = new System.Drawing.Point(298, 9);
            this.scor_count.Name = "scor_count";
            this.scor_count.Size = new System.Drawing.Size(107, 29);
            this.scor_count.TabIndex = 23;
            this.scor_count.Text = "SCOR:0";
            this.scor_count.Click += new System.EventHandler(this.label2_Click);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Transparent;
            this.over.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Gold;
            this.over.Location = new System.Drawing.Point(213, 161);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(394, 73);
            this.over.TabIndex = 24;
            this.over.Tag = "enemy";
            this.over.Text = "Game-Over ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(290, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 73);
            this.label1.TabIndex = 25;
            this.label1.Tag = "enemy";
            this.label1.Text = "Replay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.ForeColor = System.Drawing.Color.White;
            this.pause.Location = new System.Drawing.Point(7, 9);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(34, 29);
            this.pause.TabIndex = 26;
            this.pause.Text = "| |";
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(7, 9);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(28, 29);
            this.play.TabIndex = 27;
            this.play.Text = ">";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(320, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 44);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(317, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 42);
            this.label2.TabIndex = 29;
            this.label2.Tag = "enemy";
            this.label2.Text = "Nickname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(337, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 73);
            this.label3.TabIndex = 30;
            this.label3.Tag = "enemy";
            this.label3.Text = "Play";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.BackColor = System.Drawing.Color.Transparent;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.ForeColor = System.Drawing.Color.Red;
            this.n1.Location = new System.Drawing.Point(795, 96);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(90, 31);
            this.n1.TabIndex = 31;
            this.n1.Text = "Nume";
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.BackColor = System.Drawing.Color.Transparent;
            this.s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1.ForeColor = System.Drawing.Color.Red;
            this.s1.Location = new System.Drawing.Point(901, 96);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(70, 31);
            this.s1.TabIndex = 32;
            this.s1.Text = "scor";
            this.s1.Click += new System.EventHandler(this.label5_Click);
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.BackColor = System.Drawing.Color.Transparent;
            this.s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2.ForeColor = System.Drawing.Color.Coral;
            this.s2.Location = new System.Drawing.Point(905, 154);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(66, 31);
            this.s2.TabIndex = 34;
            this.s2.Text = "scor";
            this.s2.Click += new System.EventHandler(this.label6_Click);
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.BackColor = System.Drawing.Color.Transparent;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.ForeColor = System.Drawing.Color.Coral;
            this.n2.Location = new System.Drawing.Point(795, 154);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(86, 31);
            this.n2.TabIndex = 33;
            this.n2.Text = "Nume";
            // 
            // s3
            // 
            this.s3.AutoSize = true;
            this.s3.BackColor = System.Drawing.Color.Transparent;
            this.s3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s3.ForeColor = System.Drawing.Color.Gold;
            this.s3.Location = new System.Drawing.Point(905, 217);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(66, 31);
            this.s3.TabIndex = 36;
            this.s3.Text = "scor";
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.BackColor = System.Drawing.Color.Transparent;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.ForeColor = System.Drawing.Color.Gold;
            this.n3.Location = new System.Drawing.Point(795, 217);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(86, 31);
            this.n3.TabIndex = 35;
            this.n3.Text = "Nume";
            // 
            // s4
            // 
            this.s4.AutoSize = true;
            this.s4.BackColor = System.Drawing.Color.Transparent;
            this.s4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.s4.Location = new System.Drawing.Point(905, 282);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(66, 31);
            this.s4.TabIndex = 38;
            this.s4.Text = "scor";
            // 
            // n4
            // 
            this.n4.AutoSize = true;
            this.n4.BackColor = System.Drawing.Color.Transparent;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.n4.Location = new System.Drawing.Point(795, 282);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(86, 31);
            this.n4.TabIndex = 37;
            this.n4.Text = "Nume";
            // 
            // s5
            // 
            this.s5.AutoSize = true;
            this.s5.BackColor = System.Drawing.Color.Transparent;
            this.s5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s5.ForeColor = System.Drawing.Color.White;
            this.s5.Location = new System.Drawing.Point(905, 354);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(66, 31);
            this.s5.TabIndex = 40;
            this.s5.Text = "scor";
            // 
            // n5
            // 
            this.n5.AutoSize = true;
            this.n5.BackColor = System.Drawing.Color.Transparent;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.ForeColor = System.Drawing.Color.White;
            this.n5.Location = new System.Drawing.Point(795, 354);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(86, 31);
            this.n5.TabIndex = 39;
            this.n5.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(812, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 42);
            this.label4.TabIndex = 41;
            this.label4.Tag = "";
            this.label4.Text = "Leader:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::joc_v2.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(965, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s5);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.over);
            this.Controls.Add(this.scor_count);
            this.Controls.Add(this.kill);
            this.Controls.Add(this.astero2);
            this.Controls.Add(this.astero1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.e_3);
            this.Controls.Add(this.bullett);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.e_1);
            this.Controls.Add(this.e_2);
            this.Controls.Add(this.e_2_poc);
            this.Controls.Add(this.e_1_poc);
            this.Controls.Add(this.e_3_poc);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox11);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullett)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1_poc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2_poc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3_poc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bullett;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox astero1;
        private System.Windows.Forms.PictureBox astero2;
        private System.Windows.Forms.PictureBox e_1;
        private System.Windows.Forms.PictureBox e_2;
        private System.Windows.Forms.PictureBox e_3;
        private System.Windows.Forms.PictureBox e_1_poc;
        private System.Windows.Forms.PictureBox e_2_poc;
        private System.Windows.Forms.PictureBox e_3_poc;
        private System.Windows.Forms.Label kill;
        private System.Windows.Forms.Label scor_count;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pause;
        private System.Windows.Forms.Label play;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label s1;
        private System.Windows.Forms.Label s2;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label s3;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label s4;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label s5;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label label4;
    }
}

