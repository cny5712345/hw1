﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stepmode_btn = new System.Windows.Forms.RadioButton();
            this.automode_btn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.y_plus = new System.Windows.Forms.PictureBox();
            this.y_minus = new System.Windows.Forms.PictureBox();
            this.x_minus = new System.Windows.Forms.PictureBox();
            this.x_plus = new System.Windows.Forms.PictureBox();
            this.z_plus = new System.Windows.Forms.PictureBox();
            this.z_minus = new System.Windows.Forms.PictureBox();
            this.gotopoint_btn = new System.Windows.Forms.RadioButton();
            this.xpos = new System.Windows.Forms.TextBox();
            this.ypos = new System.Windows.Forms.TextBox();
            this.zpos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.move_btn = new System.Windows.Forms.Button();
            this.step_distence = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.axActUtlType1 = new AxActUtlTypeLib.AxActUtlType();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.axMMMark1 = new AxMMMARKLib.AxMMMark();
            this.chose_file = new System.Windows.Forms.Button();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.preview = new System.Windows.Forms.Button();
            this.stop_preview = new System.Windows.Forms.Button();
            this.red_light_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.y_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axActUtlType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMMMark1)).BeginInit();
            this.SuspendLayout();
            // 
            // stepmode_btn
            // 
            this.stepmode_btn.AutoSize = true;
            this.stepmode_btn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stepmode_btn.Location = new System.Drawing.Point(11, 20);
            this.stepmode_btn.Margin = new System.Windows.Forms.Padding(2);
            this.stepmode_btn.Name = "stepmode_btn";
            this.stepmode_btn.Size = new System.Drawing.Size(78, 19);
            this.stepmode_btn.TabIndex = 0;
            this.stepmode_btn.TabStop = true;
            this.stepmode_btn.Text = "stepmode";
            this.stepmode_btn.UseVisualStyleBackColor = true;
            this.stepmode_btn.CheckedChanged += new System.EventHandler(this.stepmode_CheckedChanged);
            // 
            // automode_btn
            // 
            this.automode_btn.AutoSize = true;
            this.automode_btn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.automode_btn.Location = new System.Drawing.Point(11, 95);
            this.automode_btn.Margin = new System.Windows.Forms.Padding(2);
            this.automode_btn.Name = "automode_btn";
            this.automode_btn.Size = new System.Drawing.Size(111, 19);
            this.automode_btn.TabIndex = 1;
            this.automode_btn.TabStop = true;
            this.automode_btn.Text = "Continue mode";
            this.automode_btn.UseVisualStyleBackColor = true;
            this.automode_btn.CheckedChanged += new System.EventHandler(this.automode_btn_CheckedChanged);
            this.automode_btn.Click += new System.EventHandler(this.automode_btn_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 18);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 34);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 18);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 34);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(119, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(245, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // y_plus
            // 
            this.y_plus.Image = ((System.Drawing.Image)(resources.GetObject("y_plus.Image")));
            this.y_plus.Location = new System.Drawing.Point(63, 27);
            this.y_plus.Margin = new System.Windows.Forms.Padding(2);
            this.y_plus.Name = "y_plus";
            this.y_plus.Size = new System.Drawing.Size(42, 45);
            this.y_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.y_plus.TabIndex = 8;
            this.y_plus.TabStop = false;
            this.y_plus.Click += new System.EventHandler(this.y_plus_Click);
            this.y_plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.y_plus_mousedown);
            this.y_plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.y_plus_mouseup);
            // 
            // y_minus
            // 
            this.y_minus.Image = ((System.Drawing.Image)(resources.GetObject("y_minus.Image")));
            this.y_minus.Location = new System.Drawing.Point(63, 178);
            this.y_minus.Margin = new System.Windows.Forms.Padding(2);
            this.y_minus.Name = "y_minus";
            this.y_minus.Size = new System.Drawing.Size(42, 34);
            this.y_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.y_minus.TabIndex = 9;
            this.y_minus.TabStop = false;
            this.y_minus.Click += new System.EventHandler(this.y_minus_Click);
            this.y_minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.y_minus_mousedown);
            this.y_minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.y_minus_mouseup);
            // 
            // x_minus
            // 
            this.x_minus.Image = ((System.Drawing.Image)(resources.GetObject("x_minus.Image")));
            this.x_minus.Location = new System.Drawing.Point(5, 111);
            this.x_minus.Margin = new System.Windows.Forms.Padding(2);
            this.x_minus.Name = "x_minus";
            this.x_minus.Size = new System.Drawing.Size(42, 35);
            this.x_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.x_minus.TabIndex = 10;
            this.x_minus.TabStop = false;
            this.x_minus.Click += new System.EventHandler(this.x_minus_Click);
            this.x_minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.x_minus_mousedown);
            this.x_minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.x_minus_mouseup);
            // 
            // x_plus
            // 
            this.x_plus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.x_plus.Image = ((System.Drawing.Image)(resources.GetObject("x_plus.Image")));
            this.x_plus.Location = new System.Drawing.Point(124, 111);
            this.x_plus.Margin = new System.Windows.Forms.Padding(2);
            this.x_plus.Name = "x_plus";
            this.x_plus.Size = new System.Drawing.Size(33, 37);
            this.x_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.x_plus.TabIndex = 11;
            this.x_plus.TabStop = false;
            this.x_plus.Click += new System.EventHandler(this.x_plus_Click);
            this.x_plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.x_plus_mousedown);
            this.x_plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.x_plus_mouseup);
            // 
            // z_plus
            // 
            this.z_plus.Image = ((System.Drawing.Image)(resources.GetObject("z_plus.Image")));
            this.z_plus.Location = new System.Drawing.Point(16, 267);
            this.z_plus.Margin = new System.Windows.Forms.Padding(2);
            this.z_plus.Name = "z_plus";
            this.z_plus.Size = new System.Drawing.Size(31, 40);
            this.z_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.z_plus.TabIndex = 12;
            this.z_plus.TabStop = false;
            this.z_plus.Click += new System.EventHandler(this.z_minus_Click);
            this.z_plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.z_minus_mousedown);
            this.z_plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.z_minus_mouseup);
            // 
            // z_minus
            // 
            this.z_minus.Image = ((System.Drawing.Image)(resources.GetObject("z_minus.Image")));
            this.z_minus.Location = new System.Drawing.Point(116, 267);
            this.z_minus.Margin = new System.Windows.Forms.Padding(2);
            this.z_minus.Name = "z_minus";
            this.z_minus.Size = new System.Drawing.Size(31, 40);
            this.z_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.z_minus.TabIndex = 13;
            this.z_minus.TabStop = false;
            this.z_minus.Click += new System.EventHandler(this.z_plus_Click);
            this.z_minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.z_plus_mousedown);
            this.z_minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.z_plus_mouseup);
            // 
            // gotopoint_btn
            // 
            this.gotopoint_btn.AutoSize = true;
            this.gotopoint_btn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gotopoint_btn.Location = new System.Drawing.Point(15, 47);
            this.gotopoint_btn.Margin = new System.Windows.Forms.Padding(2);
            this.gotopoint_btn.Name = "gotopoint_btn";
            this.gotopoint_btn.Size = new System.Drawing.Size(87, 19);
            this.gotopoint_btn.TabIndex = 15;
            this.gotopoint_btn.TabStop = true;
            this.gotopoint_btn.Text = "go to point";
            this.gotopoint_btn.UseVisualStyleBackColor = true;
            this.gotopoint_btn.CheckedChanged += new System.EventHandler(this.gotopoint_btn_CheckedChanged);
            // 
            // xpos
            // 
            this.xpos.Location = new System.Drawing.Point(91, 111);
            this.xpos.Margin = new System.Windows.Forms.Padding(2);
            this.xpos.Multiline = true;
            this.xpos.Name = "xpos";
            this.xpos.Size = new System.Drawing.Size(90, 32);
            this.xpos.TabIndex = 16;
            this.xpos.TextChanged += new System.EventHandler(this.xpos_TextChanged);
            // 
            // ypos
            // 
            this.ypos.Location = new System.Drawing.Point(91, 152);
            this.ypos.Margin = new System.Windows.Forms.Padding(2);
            this.ypos.Multiline = true;
            this.ypos.Name = "ypos";
            this.ypos.Size = new System.Drawing.Size(90, 32);
            this.ypos.TabIndex = 17;
            this.ypos.Text = "300";
            // 
            // zpos
            // 
            this.zpos.Location = new System.Drawing.Point(91, 197);
            this.zpos.Margin = new System.Windows.Forms.Padding(2);
            this.zpos.Multiline = true;
            this.zpos.Name = "zpos";
            this.zpos.Size = new System.Drawing.Size(90, 28);
            this.zpos.TabIndex = 18;
            this.zpos.Text = "300";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(20, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(20, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(23, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Z";
            // 
            // move_btn
            // 
            this.move_btn.Location = new System.Drawing.Point(44, 245);
            this.move_btn.Margin = new System.Windows.Forms.Padding(2);
            this.move_btn.Name = "move_btn";
            this.move_btn.Size = new System.Drawing.Size(115, 43);
            this.move_btn.TabIndex = 22;
            this.move_btn.Text = "move";
            this.move_btn.UseVisualStyleBackColor = true;
            this.move_btn.Click += new System.EventHandler(this.move_btn_Click);
            // 
            // step_distence
            // 
            this.step_distence.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.step_distence.Location = new System.Drawing.Point(97, 47);
            this.step_distence.Margin = new System.Windows.Forms.Padding(2);
            this.step_distence.Multiline = true;
            this.step_distence.Name = "step_distence";
            this.step_distence.Size = new System.Drawing.Size(58, 25);
            this.step_distence.TabIndex = 23;
            this.step_distence.Text = "0.005";
            this.step_distence.TextChanged += new System.EventHandler(this.step_distence_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(5, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "step distance";
            // 
            // axActUtlType1
            // 
            this.axActUtlType1.Enabled = true;
            this.axActUtlType1.Location = new System.Drawing.Point(12, 67);
            this.axActUtlType1.Name = "axActUtlType1";
            this.axActUtlType1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axActUtlType1.OcxState")));
            this.axActUtlType1.Size = new System.Drawing.Size(32, 32);
            this.axActUtlType1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.gohome_btn);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 178);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(33, 138);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(43, 21);
            this.stop.TabIndex = 28;
            this.stop.Text = "stop";
            this.stop.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stepmode_btn);
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.automode_btn);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.step_distence);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(1, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 328);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "步進/寸進模式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.y_plus);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.y_minus);
            this.groupBox2.Controls.Add(this.x_minus);
            this.groupBox2.Controls.Add(this.x_plus);
            this.groupBox2.Controls.Add(this.z_plus);
            this.groupBox2.Controls.Add(this.z_minus);
            this.groupBox2.Location = new System.Drawing.Point(199, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 375);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "移動";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(102, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Down";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(13, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Up";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(50, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 100);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "座標";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.xpos);
            this.groupBox4.Controls.Add(this.gotopoint_btn);
            this.groupBox4.Controls.Add(this.move_btn);
            this.groupBox4.Controls.Add(this.ypos);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.zpos);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(367, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 310);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "自動模式";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 8);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // axMMMark1
            // 
            this.axMMMark1.Enabled = true;
            this.axMMMark1.Location = new System.Drawing.Point(654, 67);
            this.axMMMark1.Name = "axMMMark1";
            this.axMMMark1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMMMark1.OcxState")));
            this.axMMMark1.Size = new System.Drawing.Size(373, 374);
            this.axMMMark1.TabIndex = 35;
            // 
            // chose_file
            // 
            this.chose_file.Location = new System.Drawing.Point(952, 28);
            this.chose_file.Name = "chose_file";
            this.chose_file.Size = new System.Drawing.Size(75, 23);
            this.chose_file.TabIndex = 36;
            this.chose_file.Text = "選擇加工檔";
            this.chose_file.UseVisualStyleBackColor = true;
            this.chose_file.Click += new System.EventHandler(this.chose_file_Click);
            // 
            // path_txt
            // 
            this.path_txt.Location = new System.Drawing.Point(735, 30);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(211, 22);
            this.path_txt.TabIndex = 37;
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(1033, 86);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(75, 23);
            this.preview.TabIndex = 38;
            this.preview.Text = "路徑預覽";
            this.preview.UseVisualStyleBackColor = true;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // stop_preview
            // 
            this.stop_preview.Location = new System.Drawing.Point(1114, 86);
            this.stop_preview.Name = "stop_preview";
            this.stop_preview.Size = new System.Drawing.Size(75, 23);
            this.stop_preview.TabIndex = 39;
            this.stop_preview.Text = "結束預覽";
            this.stop_preview.UseVisualStyleBackColor = true;
            this.stop_preview.Click += new System.EventHandler(this.stop_preview_Click);
            // 
            // red_light_btn
            // 
            this.red_light_btn.Location = new System.Drawing.Point(1085, 30);
            this.red_light_btn.Name = "red_light_btn";
            this.red_light_btn.Size = new System.Drawing.Size(52, 48);
            this.red_light_btn.TabIndex = 40;
            this.red_light_btn.Text = "紅光";
            this.red_light_btn.UseVisualStyleBackColor = true;
            this.red_light_btn.Click += new System.EventHandler(this.red_light_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 495);
            this.Controls.Add(this.red_light_btn);
            this.Controls.Add(this.stop_preview);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.path_txt);
            this.Controls.Add(this.chose_file);
            this.Controls.Add(this.axMMMark1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.axActUtlType1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.y_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axActUtlType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMMMark1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton stepmode_btn;
        private System.Windows.Forms.RadioButton automode_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox y_plus;
        private System.Windows.Forms.PictureBox y_minus;
        private System.Windows.Forms.PictureBox x_minus;
        private System.Windows.Forms.PictureBox x_plus;
        private System.Windows.Forms.PictureBox z_plus;
        private System.Windows.Forms.PictureBox z_minus;
        private System.Windows.Forms.RadioButton gotopoint_btn;
        private System.Windows.Forms.TextBox xpos;
        private System.Windows.Forms.TextBox ypos;
        private System.Windows.Forms.TextBox zpos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button move_btn;
        private System.Windows.Forms.TextBox step_distence;
        private System.Windows.Forms.Label label8;
        private AxActUtlTypeLib.AxActUtlType axActUtlType1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AxMMMARKLib.AxMMMark axMMMark1;
        private System.Windows.Forms.Button chose_file;
        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.Button stop_preview;
        private System.Windows.Forms.Button red_light_btn;
    }
}

