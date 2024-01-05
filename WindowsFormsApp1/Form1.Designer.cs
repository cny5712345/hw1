namespace WindowsFormsApp1
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
            this.label4 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.SuspendLayout();
            // 
            // stepmode_btn
            // 
            this.stepmode_btn.AutoSize = true;
            this.stepmode_btn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stepmode_btn.Location = new System.Drawing.Point(72, 20);
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
            this.automode_btn.Location = new System.Drawing.Point(72, 99);
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
            this.textBox1.Location = new System.Drawing.Point(72, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 62);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 20);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 62);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(465, 20);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 61);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(190, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(393, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // y_plus
            // 
            this.y_plus.Image = ((System.Drawing.Image)(resources.GetObject("y_plus.Image")));
            this.y_plus.Location = new System.Drawing.Point(106, 31);
            this.y_plus.Margin = new System.Windows.Forms.Padding(2);
            this.y_plus.Name = "y_plus";
            this.y_plus.Size = new System.Drawing.Size(67, 69);
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
            this.y_minus.Location = new System.Drawing.Point(106, 182);
            this.y_minus.Margin = new System.Windows.Forms.Padding(2);
            this.y_minus.Name = "y_minus";
            this.y_minus.Size = new System.Drawing.Size(67, 58);
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
            this.x_minus.Location = new System.Drawing.Point(22, 111);
            this.x_minus.Margin = new System.Windows.Forms.Padding(2);
            this.x_minus.Name = "x_minus";
            this.x_minus.Size = new System.Drawing.Size(67, 59);
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
            this.x_plus.Location = new System.Drawing.Point(181, 109);
            this.x_plus.Margin = new System.Windows.Forms.Padding(2);
            this.x_plus.Name = "x_plus";
            this.x_plus.Size = new System.Drawing.Size(58, 61);
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
            this.z_plus.Location = new System.Drawing.Point(47, 290);
            this.z_plus.Margin = new System.Windows.Forms.Padding(2);
            this.z_plus.Name = "z_plus";
            this.z_plus.Size = new System.Drawing.Size(56, 64);
            this.z_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.z_plus.TabIndex = 12;
            this.z_plus.TabStop = false;
            this.z_plus.Click += new System.EventHandler(this.z_plus_Click);
            this.z_plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.z_minus_mousedown);
            this.z_plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.z_minus_mouseup);
            // 
            // z_minus
            // 
            this.z_minus.Image = ((System.Drawing.Image)(resources.GetObject("z_minus.Image")));
            this.z_minus.Location = new System.Drawing.Point(166, 290);
            this.z_minus.Margin = new System.Windows.Forms.Padding(2);
            this.z_minus.Name = "z_minus";
            this.z_minus.Size = new System.Drawing.Size(56, 64);
            this.z_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.z_minus.TabIndex = 13;
            this.z_minus.TabStop = false;
            this.z_minus.Click += new System.EventHandler(this.z_minus_Click);
            this.z_minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.z_plus_mousedown);
            this.z_minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.z_plus_mouseup);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "automode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gotopoint_btn
            // 
            this.gotopoint_btn.AutoSize = true;
            this.gotopoint_btn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gotopoint_btn.Location = new System.Drawing.Point(44, 77);
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
            this.step_distence.Location = new System.Drawing.Point(127, 47);
            this.step_distence.Margin = new System.Windows.Forms.Padding(2);
            this.step_distence.Multiline = true;
            this.step_distence.Name = "step_distence";
            this.step_distence.Size = new System.Drawing.Size(89, 41);
            this.step_distence.TabIndex = 23;
            this.step_distence.Text = "0.005";
            this.step_distence.TextChanged += new System.EventHandler(this.step_distence_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(39, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "step distance";
            // 
            // axActUtlType1
            // 
            this.axActUtlType1.Enabled = true;
            this.axActUtlType1.Location = new System.Drawing.Point(12, 110);
            this.axActUtlType1.Name = "axActUtlType1";
            this.axActUtlType1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axActUtlType1.OcxState")));
            this.axActUtlType1.Size = new System.Drawing.Size(32, 32);
            this.axActUtlType1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 59);
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
            this.pictureBox2.Location = new System.Drawing.Point(42, 187);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(84, 154);
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
            this.groupBox1.Location = new System.Drawing.Point(1, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 293);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.groupBox2.Location = new System.Drawing.Point(226, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 375);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(59, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Up";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(164, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Down";
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
            this.groupBox3.Size = new System.Drawing.Size(628, 100);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.xpos);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.gotopoint_btn);
            this.groupBox4.Controls.Add(this.move_btn);
            this.groupBox4.Controls.Add(this.ypos);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.zpos);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(495, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 288);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 495);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.axActUtlType1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label4;
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
    }
}

