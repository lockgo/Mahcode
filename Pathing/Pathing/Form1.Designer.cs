﻿namespace Pathing
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listSessions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textHealth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textWis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textInt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textAC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textDex = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textStr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textWill = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textReflex = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textForitude = new System.Windows.Forms.TextBox();
            this.textCha = new System.Windows.Forms.TextBox();
            this.textCon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textIniative = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textHD = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBaseAttack = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textCMB = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textCMD = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSessions = new System.Windows.Forms.OpenFileDialog();
            this.saveSessions = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 97);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 2;
            this.textName.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Here";
            // 
            // listSessions
            // 
            this.listSessions.ColumnWidth = 3;
            this.listSessions.FormattingEnabled = true;
            this.listSessions.Location = new System.Drawing.Point(56, 255);
            this.listSessions.Name = "listSessions";
            this.listSessions.Size = new System.Drawing.Size(736, 95);
            this.listSessions.TabIndex = 25;
            this.listSessions.SelectedIndexChanged += new System.EventHandler(this.listSessions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Class";
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(118, 97);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(100, 20);
            this.textClass.TabIndex = 3;
            this.textClass.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Health";
            // 
            // textHealth
            // 
            this.textHealth.Location = new System.Drawing.Point(224, 97);
            this.textHealth.Name = "textHealth";
            this.textHealth.Size = new System.Drawing.Size(100, 20);
            this.textHealth.TabIndex = 4;
            this.textHealth.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wis";
            // 
            // textWis
            // 
            this.textWis.Location = new System.Drawing.Point(9, 294);
            this.textWis.Name = "textWis";
            this.textWis.Size = new System.Drawing.Size(32, 20);
            this.textWis.TabIndex = 10;
            this.textWis.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Int";
            // 
            // textInt
            // 
            this.textInt.Location = new System.Drawing.Point(10, 255);
            this.textInt.Name = "textInt";
            this.textInt.Size = new System.Drawing.Size(31, 20);
            this.textInt.TabIndex = 9;
            this.textInt.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "AC";
            // 
            // textAC
            // 
            this.textAC.Location = new System.Drawing.Point(330, 97);
            this.textAC.Name = "textAC";
            this.textAC.Size = new System.Drawing.Size(100, 20);
            this.textAC.TabIndex = 5;
            this.textAC.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Con";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Dex";
            // 
            // textDex
            // 
            this.textDex.Location = new System.Drawing.Point(10, 183);
            this.textDex.Name = "textDex";
            this.textDex.Size = new System.Drawing.Size(32, 20);
            this.textDex.TabIndex = 7;
            this.textDex.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Str";
            // 
            // textStr
            // 
            this.textStr.Location = new System.Drawing.Point(11, 144);
            this.textStr.Name = "textStr";
            this.textStr.Size = new System.Drawing.Size(31, 20);
            this.textStr.TabIndex = 6;
            this.textStr.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Will";
            // 
            // textWill
            // 
            this.textWill.Location = new System.Drawing.Point(114, 219);
            this.textWill.Name = "textWill";
            this.textWill.Size = new System.Drawing.Size(32, 20);
            this.textWill.TabIndex = 14;
            this.textWill.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Reflex";
            // 
            // textReflex
            // 
            this.textReflex.Location = new System.Drawing.Point(114, 183);
            this.textReflex.Name = "textReflex";
            this.textReflex.Size = new System.Drawing.Size(32, 20);
            this.textReflex.TabIndex = 13;
            this.textReflex.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(111, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Foritude";
            // 
            // textForitude
            // 
            this.textForitude.Location = new System.Drawing.Point(115, 144);
            this.textForitude.Name = "textForitude";
            this.textForitude.Size = new System.Drawing.Size(31, 20);
            this.textForitude.TabIndex = 12;
            this.textForitude.Text = "0";
            // 
            // textCha
            // 
            this.textCha.Location = new System.Drawing.Point(11, 330);
            this.textCha.Name = "textCha";
            this.textCha.Size = new System.Drawing.Size(31, 20);
            this.textCha.TabIndex = 11;
            this.textCha.Text = "0";
            // 
            // textCon
            // 
            this.textCon.Location = new System.Drawing.Point(11, 216);
            this.textCon.Name = "textCon";
            this.textCon.Size = new System.Drawing.Size(31, 20);
            this.textCon.TabIndex = 8;
            this.textCon.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(149, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Initiative";
            // 
            // textIniative
            // 
            this.textIniative.Location = new System.Drawing.Point(153, 183);
            this.textIniative.Name = "textIniative";
            this.textIniative.Size = new System.Drawing.Size(31, 20);
            this.textIniative.TabIndex = 15;
            this.textIniative.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(222, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "HD";
            // 
            // textHD
            // 
            this.textHD.Location = new System.Drawing.Point(223, 180);
            this.textHD.Name = "textHD";
            this.textHD.Size = new System.Drawing.Size(31, 20);
            this.textHD.TabIndex = 16;
            this.textHD.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(222, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(223, 219);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(31, 20);
            this.textEmail.TabIndex = 19;
            this.textEmail.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(148, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "BaseAttack";
            // 
            // textBaseAttack
            // 
            this.textBaseAttack.Location = new System.Drawing.Point(152, 219);
            this.textBaseAttack.Name = "textBaseAttack";
            this.textBaseAttack.Size = new System.Drawing.Size(31, 20);
            this.textBaseAttack.TabIndex = 18;
            this.textBaseAttack.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(264, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "CMB";
            // 
            // textCMB
            // 
            this.textCMB.Location = new System.Drawing.Point(263, 180);
            this.textCMB.Name = "textCMB";
            this.textCMB.ReadOnly = true;
            this.textCMB.Size = new System.Drawing.Size(31, 20);
            this.textCMB.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 203);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "CMD";
            // 
            // textCMD
            // 
            this.textCMD.Location = new System.Drawing.Point(260, 219);
            this.textCMD.Name = "textCMD";
            this.textCMD.ReadOnly = true;
            this.textCMD.Size = new System.Drawing.Size(31, 20);
            this.textCMD.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openSessions
            // 
            this.openSessions.FileName = "openSessions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 539);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textCMB);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textCMD);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBaseAttack);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textHD);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textIniative);
            this.Controls.Add(this.textCon);
            this.Controls.Add(this.textCha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textWill);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textReflex);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textForitude);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textDex);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textStr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textWis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textInt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textHealth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listSessions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listSessions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHealth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textWis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textInt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textStr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textWill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textReflex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textForitude;
        private System.Windows.Forms.TextBox textCha;
        private System.Windows.Forms.TextBox textCon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textIniative;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textHD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBaseAttack;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textCMB;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textCMD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openSessions;
        private System.Windows.Forms.SaveFileDialog saveSessions;
    }
}

