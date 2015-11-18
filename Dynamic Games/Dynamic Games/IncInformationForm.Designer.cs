using System.Collections.Generic;
using System.Windows.Forms;

namespace Dynamic_Games
{
    partial class IncInformationForm
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
            this.TablePicture = new System.Windows.Forms.PictureBox();
            this.ComboPlayerCount = new System.Windows.Forms.ComboBox();
            this.P1C1 = new System.Windows.Forms.PictureBox();
            this.P1C2 = new System.Windows.Forms.PictureBox();
            this.P2C2 = new System.Windows.Forms.PictureBox();
            this.P2C1 = new System.Windows.Forms.PictureBox();
            this.P3C2 = new System.Windows.Forms.PictureBox();
            this.P3C1 = new System.Windows.Forms.PictureBox();
            this.P4C2 = new System.Windows.Forms.PictureBox();
            this.P4C1 = new System.Windows.Forms.PictureBox();
            this.P5C2 = new System.Windows.Forms.PictureBox();
            this.P5C1 = new System.Windows.Forms.PictureBox();
            this.P6C2 = new System.Windows.Forms.PictureBox();
            this.P6C1 = new System.Windows.Forms.PictureBox();
            this.P7C2 = new System.Windows.Forms.PictureBox();
            this.P7C1 = new System.Windows.Forms.PictureBox();
            this.P8C2 = new System.Windows.Forms.PictureBox();
            this.P8C1 = new System.Windows.Forms.PictureBox();
            this.PlayerNrLabel = new System.Windows.Forms.Label();
            this.P1Label = new System.Windows.Forms.Label();
            this.Flop1 = new System.Windows.Forms.PictureBox();
            this.Flop2 = new System.Windows.Forms.PictureBox();
            this.Flop3 = new System.Windows.Forms.PictureBox();
            this.River = new System.Windows.Forms.PictureBox();
            this.Turn = new System.Windows.Forms.PictureBox();
            this.P1ComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.P2Label = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.P3Label = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.P4Label = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.P5Label = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.P6Label = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.P7Label = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.P8Label = new System.Windows.Forms.Label();
            this.P1Cash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P5C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P5C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P6C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P6C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P7C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P7C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P8C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P8C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.River)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turn)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePicture
            // 
            this.TablePicture.Image = global::Dynamic_Games.Properties.Resources.greentop;
            this.TablePicture.Location = new System.Drawing.Point(12, 2);
            this.TablePicture.Name = "TablePicture";
            this.TablePicture.Size = new System.Drawing.Size(792, 554);
            this.TablePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TablePicture.TabIndex = 1;
            this.TablePicture.TabStop = false;
            // 
            // ComboPlayerCount
            // 
            this.ComboPlayerCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPlayerCount.Location = new System.Drawing.Point(946, 23);
            this.ComboPlayerCount.Name = "ComboPlayerCount";
            this.ComboPlayerCount.Size = new System.Drawing.Size(121, 21);
            this.ComboPlayerCount.TabIndex = 2;
            this.ComboPlayerCount.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // P1C1
            // 
            this.P1C1.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P1C1.Location = new System.Drawing.Point(80, 98);
            this.P1C1.Name = "P1C1";
            this.P1C1.Size = new System.Drawing.Size(54, 80);
            this.P1C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P1C1.TabIndex = 3;
            this.P1C1.TabStop = false;
            // 
            // P1C2
            // 
            this.P1C2.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P1C2.Location = new System.Drawing.Point(109, 82);
            this.P1C2.Name = "P1C2";
            this.P1C2.Size = new System.Drawing.Size(54, 80);
            this.P1C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P1C2.TabIndex = 4;
            this.P1C2.TabStop = false;
            // 
            // P2C2
            // 
            this.P2C2.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P2C2.Location = new System.Drawing.Point(305, 12);
            this.P2C2.Name = "P2C2";
            this.P2C2.Size = new System.Drawing.Size(54, 80);
            this.P2C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P2C2.TabIndex = 6;
            this.P2C2.TabStop = false;
            // 
            // P2C1
            // 
            this.P2C1.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P2C1.Location = new System.Drawing.Point(272, 26);
            this.P2C1.Name = "P2C1";
            this.P2C1.Size = new System.Drawing.Size(54, 80);
            this.P2C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P2C1.TabIndex = 5;
            this.P2C1.TabStop = false;
            // 
            // P3C2
            // 
            this.P3C2.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P3C2.Location = new System.Drawing.Point(532, 12);
            this.P3C2.Name = "P3C2";
            this.P3C2.Size = new System.Drawing.Size(54, 80);
            this.P3C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P3C2.TabIndex = 8;
            this.P3C2.TabStop = false;
            // 
            // P3C1
            // 
            this.P3C1.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P3C1.Location = new System.Drawing.Point(499, 26);
            this.P3C1.Name = "P3C1";
            this.P3C1.Size = new System.Drawing.Size(54, 80);
            this.P3C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P3C1.TabIndex = 7;
            this.P3C1.TabStop = false;
            // 
            // P4C2
            // 
            this.P4C2.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P4C2.Location = new System.Drawing.Point(666, 82);
            this.P4C2.Name = "P4C2";
            this.P4C2.Size = new System.Drawing.Size(54, 80);
            this.P4C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P4C2.TabIndex = 10;
            this.P4C2.TabStop = false;
            // 
            // P4C1
            // 
            this.P4C1.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P4C1.Location = new System.Drawing.Point(633, 96);
            this.P4C1.Name = "P4C1";
            this.P4C1.Size = new System.Drawing.Size(54, 80);
            this.P4C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P4C1.TabIndex = 9;
            this.P4C1.TabStop = false;
            // 
            // P5C2
            // 
            this.P5C2.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P5C2.Location = new System.Drawing.Point(666, 259);
            this.P5C2.Name = "P5C2";
            this.P5C2.Size = new System.Drawing.Size(54, 80);
            this.P5C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P5C2.TabIndex = 12;
            this.P5C2.TabStop = false;
            // 
            // P5C1
            // 
            this.P5C1.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P5C1.Location = new System.Drawing.Point(633, 273);
            this.P5C1.Name = "P5C1";
            this.P5C1.Size = new System.Drawing.Size(54, 80);
            this.P5C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P5C1.TabIndex = 11;
            this.P5C1.TabStop = false;
            // 
            // P6C2
            // 
            this.P6C2.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P6C2.Location = new System.Drawing.Point(532, 350);
            this.P6C2.Name = "P6C2";
            this.P6C2.Size = new System.Drawing.Size(54, 80);
            this.P6C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P6C2.TabIndex = 14;
            this.P6C2.TabStop = false;
            // 
            // P6C1
            // 
            this.P6C1.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P6C1.Location = new System.Drawing.Point(499, 364);
            this.P6C1.Name = "P6C1";
            this.P6C1.Size = new System.Drawing.Size(54, 80);
            this.P6C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P6C1.TabIndex = 13;
            this.P6C1.TabStop = false;
            // 
            // P7C2
            // 
            this.P7C2.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P7C2.Location = new System.Drawing.Point(305, 350);
            this.P7C2.Name = "P7C2";
            this.P7C2.Size = new System.Drawing.Size(54, 80);
            this.P7C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P7C2.TabIndex = 16;
            this.P7C2.TabStop = false;
            // 
            // P7C1
            // 
            this.P7C1.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P7C1.Location = new System.Drawing.Point(272, 364);
            this.P7C1.Name = "P7C1";
            this.P7C1.Size = new System.Drawing.Size(54, 80);
            this.P7C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P7C1.TabIndex = 15;
            this.P7C1.TabStop = false;
            // 
            // P8C2
            // 
            this.P8C2.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P8C2.Location = new System.Drawing.Point(109, 259);
            this.P8C2.Name = "P8C2";
            this.P8C2.Size = new System.Drawing.Size(54, 80);
            this.P8C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P8C2.TabIndex = 18;
            this.P8C2.TabStop = false;
            // 
            // P8C1
            // 
            this.P8C1.Image = global::Dynamic_Games.Properties.Resources.back;
            this.P8C1.Location = new System.Drawing.Point(76, 273);
            this.P8C1.Name = "P8C1";
            this.P8C1.Size = new System.Drawing.Size(54, 80);
            this.P8C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P8C1.TabIndex = 17;
            this.P8C1.TabStop = false;
            // 
            // PlayerNrLabel
            // 
            this.PlayerNrLabel.AutoSize = true;
            this.PlayerNrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNrLabel.Location = new System.Drawing.Point(810, 24);
            this.PlayerNrLabel.Name = "PlayerNrLabel";
            this.PlayerNrLabel.Size = new System.Drawing.Size(130, 20);
            this.PlayerNrLabel.TabIndex = 19;
            this.PlayerNrLabel.Text = "Player Number:";
            // 
            // P1Label
            // 
            this.P1Label.AutoSize = true;
            this.P1Label.Location = new System.Drawing.Point(823, 82);
            this.P1Label.Name = "P1Label";
            this.P1Label.Size = new System.Drawing.Size(48, 13);
            this.P1Label.TabIndex = 20;
            this.P1Label.Text = "Player 1:";
            // 
            // Flop1
            // 
            this.Flop1.Image = global::Dynamic_Games.Properties.Resources.back;
            this.Flop1.Location = new System.Drawing.Point(232, 148);
            this.Flop1.Name = "Flop1";
            this.Flop1.Size = new System.Drawing.Size(54, 80);
            this.Flop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flop1.TabIndex = 21;
            this.Flop1.TabStop = false;
            // 
            // Flop2
            // 
            this.Flop2.Image = global::Dynamic_Games.Properties.Resources.back;
            this.Flop2.Location = new System.Drawing.Point(292, 148);
            this.Flop2.Name = "Flop2";
            this.Flop2.Size = new System.Drawing.Size(54, 80);
            this.Flop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flop2.TabIndex = 22;
            this.Flop2.TabStop = false;
            // 
            // Flop3
            // 
            this.Flop3.Image = global::Dynamic_Games.Properties.Resources.back;
            this.Flop3.Location = new System.Drawing.Point(352, 148);
            this.Flop3.Name = "Flop3";
            this.Flop3.Size = new System.Drawing.Size(54, 80);
            this.Flop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flop3.TabIndex = 23;
            this.Flop3.TabStop = false;
            // 
            // River
            // 
            this.River.Image = global::Dynamic_Games.Properties.Resources.back;
            this.River.Location = new System.Drawing.Point(429, 148);
            this.River.Name = "River";
            this.River.Size = new System.Drawing.Size(54, 80);
            this.River.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.River.TabIndex = 24;
            this.River.TabStop = false;
            // 
            // Turn
            // 
            this.Turn.Image = global::Dynamic_Games.Properties.Resources.back;
            this.Turn.Location = new System.Drawing.Point(510, 148);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(54, 80);
            this.Turn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Turn.TabIndex = 25;
            this.Turn.TabStop = false;
            // 
            // P1ComboBox
            // 
            this.P1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P1ComboBox.FormattingEnabled = true;
            this.P1ComboBox.Location = new System.Drawing.Point(887, 79);
            this.P1ComboBox.Name = "P1ComboBox";
            this.P1ComboBox.Size = new System.Drawing.Size(95, 21);
            this.P1ComboBox.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(887, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // P2Label
            // 
            this.P2Label.AutoSize = true;
            this.P2Label.Location = new System.Drawing.Point(823, 109);
            this.P2Label.Name = "P2Label";
            this.P2Label.Size = new System.Drawing.Size(48, 13);
            this.P2Label.TabIndex = 27;
            this.P2Label.Text = "Player 2:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(887, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // P3Label
            // 
            this.P3Label.AutoSize = true;
            this.P3Label.Location = new System.Drawing.Point(823, 136);
            this.P3Label.Name = "P3Label";
            this.P3Label.Size = new System.Drawing.Size(48, 13);
            this.P3Label.TabIndex = 29;
            this.P3Label.Text = "Player 3:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(887, 160);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(95, 21);
            this.comboBox3.TabIndex = 32;
            // 
            // P4Label
            // 
            this.P4Label.AutoSize = true;
            this.P4Label.Location = new System.Drawing.Point(823, 163);
            this.P4Label.Name = "P4Label";
            this.P4Label.Size = new System.Drawing.Size(48, 13);
            this.P4Label.TabIndex = 31;
            this.P4Label.Text = "Player 4:";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(887, 187);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(95, 21);
            this.comboBox4.TabIndex = 34;
            // 
            // P5Label
            // 
            this.P5Label.AutoSize = true;
            this.P5Label.Location = new System.Drawing.Point(823, 190);
            this.P5Label.Name = "P5Label";
            this.P5Label.Size = new System.Drawing.Size(48, 13);
            this.P5Label.TabIndex = 33;
            this.P5Label.Text = "Player 5:";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(887, 214);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(95, 21);
            this.comboBox5.TabIndex = 36;
            // 
            // P6Label
            // 
            this.P6Label.AutoSize = true;
            this.P6Label.Location = new System.Drawing.Point(823, 217);
            this.P6Label.Name = "P6Label";
            this.P6Label.Size = new System.Drawing.Size(48, 13);
            this.P6Label.TabIndex = 35;
            this.P6Label.Text = "Player 6:";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(887, 241);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(95, 21);
            this.comboBox6.TabIndex = 38;
            // 
            // P7Label
            // 
            this.P7Label.AutoSize = true;
            this.P7Label.Location = new System.Drawing.Point(823, 244);
            this.P7Label.Name = "P7Label";
            this.P7Label.Size = new System.Drawing.Size(48, 13);
            this.P7Label.TabIndex = 37;
            this.P7Label.Text = "Player 7:";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(887, 268);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(95, 21);
            this.comboBox7.TabIndex = 40;
            // 
            // P8Label
            // 
            this.P8Label.AutoSize = true;
            this.P8Label.Location = new System.Drawing.Point(823, 271);
            this.P8Label.Name = "P8Label";
            this.P8Label.Size = new System.Drawing.Size(48, 13);
            this.P8Label.TabIndex = 39;
            this.P8Label.Text = "Player 8:";
            // 
            // P1Cash
            // 
            this.P1Cash.AutoSize = true;
            this.P1Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Cash.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.P1Cash.Location = new System.Drawing.Point(106, 191);
            this.P1Cash.Name = "P1Cash";
            this.P1Cash.Size = new System.Drawing.Size(49, 15);
            this.P1Cash.TabIndex = 41;
            this.P1Cash.Text = "Money";
            // 
            // IncInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 577);
            this.Controls.Add(this.P1Cash);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.P8Label);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.P7Label);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.P6Label);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.P5Label);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.P4Label);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.P3Label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.P2Label);
            this.Controls.Add(this.P1ComboBox);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.River);
            this.Controls.Add(this.Flop3);
            this.Controls.Add(this.Flop2);
            this.Controls.Add(this.Flop1);
            this.Controls.Add(this.P1Label);
            this.Controls.Add(this.PlayerNrLabel);
            this.Controls.Add(this.P8C2);
            this.Controls.Add(this.P8C1);
            this.Controls.Add(this.P7C2);
            this.Controls.Add(this.P7C1);
            this.Controls.Add(this.P6C2);
            this.Controls.Add(this.P6C1);
            this.Controls.Add(this.P5C2);
            this.Controls.Add(this.P5C1);
            this.Controls.Add(this.P4C2);
            this.Controls.Add(this.P4C1);
            this.Controls.Add(this.P3C2);
            this.Controls.Add(this.P3C1);
            this.Controls.Add(this.P2C2);
            this.Controls.Add(this.P2C1);
            this.Controls.Add(this.P1C2);
            this.Controls.Add(this.P1C1);
            this.Controls.Add(this.ComboPlayerCount);
            this.Controls.Add(this.TablePicture);
            this.Name = "IncInformationForm";
            this.Text = "IncompleteInformationForm";
            this.Load += new System.EventHandler(this.IncInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P5C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P5C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P6C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P6C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P7C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P7C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P8C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P8C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.River)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TablePicture;
        private ComboBox ComboPlayerCount;
        private PictureBox P1C1;
        private PictureBox P1C2;
        private PictureBox P2C2;
        private PictureBox P2C1;
        private PictureBox P3C2;
        private PictureBox P3C1;
        private PictureBox P4C2;
        private PictureBox P4C1;
        private PictureBox P5C2;
        private PictureBox P5C1;
        private PictureBox P6C2;
        private PictureBox P6C1;
        private PictureBox P7C2;
        private PictureBox P7C1;
        private PictureBox P8C2;
        private PictureBox P8C1;
        private Label PlayerNrLabel;
        private Label P1Label;
        private PictureBox Flop1;
        private PictureBox Flop2;
        private PictureBox Flop3;
        private PictureBox River;
        private PictureBox Turn;
        private ComboBox P1ComboBox;
        private ComboBox comboBox1;
        private Label P2Label;
        private ComboBox comboBox2;
        private Label P3Label;
        private ComboBox comboBox3;
        private Label P4Label;
        private ComboBox comboBox4;
        private Label P5Label;
        private ComboBox comboBox5;
        private Label P6Label;
        private ComboBox comboBox6;
        private Label P7Label;
        private ComboBox comboBox7;
        private Label P8Label;
        private Label P1Cash;

    }
}