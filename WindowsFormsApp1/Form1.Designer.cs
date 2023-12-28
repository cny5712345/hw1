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
            this.stepmode_btn = new System.Windows.Forms.RadioButton();
            this.automode_btn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gotopoint_btn = new System.Windows.Forms.RadioButton();
            this.xpos = new System.Windows.Forms.TextBox();
            this.ypos = new System.Windows.Forms.TextBox();
            this.zpos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.move_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // stepmode_btn
            // 
            this.stepmode_btn.AutoSize = true;
            this.stepmode_btn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stepmode_btn.Location = new System.Drawing.Point(81, 235);
            this.stepmode_btn.Name = "stepmode_btn";
            this.stepmode_btn.Size = new System.Drawing.Size(113, 26);
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
            this.automode_btn.Location = new System.Drawing.Point(81, 351);
            this.automode_btn.Name = "automode_btn";
            this.automode_btn.Size = new System.Drawing.Size(121, 26);
            this.automode_btn.TabIndex = 1;
            this.automode_btn.TabStop = true;
            this.automode_btn.Text = "auto mode";
            this.automode_btn.UseVisualStyleBackColor = true;
            this.automode_btn.CheckedChanged += new System.EventHandler(this.automode_btn_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 148);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(556, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 148);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(955, 43);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 148);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(49, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(469, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 80);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(862, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 80);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(374, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 142);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(385, 540);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 142);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(251, 396);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 142);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(518, 396);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 142);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(687, 264);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 142);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(687, 461);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(128, 142);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(975, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "automode";
            // 
            // gotopoint_btn
            // 
            this.gotopoint_btn.AutoSize = true;
            this.gotopoint_btn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gotopoint_btn.Location = new System.Drawing.Point(955, 301);
            this.gotopoint_btn.Name = "gotopoint_btn";
            this.gotopoint_btn.Size = new System.Drawing.Size(125, 26);
            this.gotopoint_btn.TabIndex = 15;
            this.gotopoint_btn.TabStop = true;
            this.gotopoint_btn.Text = "go to point";
            this.gotopoint_btn.UseVisualStyleBackColor = true;
            this.gotopoint_btn.CheckedChanged += new System.EventHandler(this.gotopoint_btn_CheckedChanged);
            // 
            // xpos
            // 
            this.xpos.Location = new System.Drawing.Point(1009, 354);
            this.xpos.Multiline = true;
            this.xpos.Name = "xpos";
            this.xpos.Size = new System.Drawing.Size(224, 59);
            this.xpos.TabIndex = 16;
            // 
            // ypos
            // 
            this.ypos.Location = new System.Drawing.Point(1009, 447);
            this.ypos.Multiline = true;
            this.ypos.Name = "ypos";
            this.ypos.Size = new System.Drawing.Size(224, 59);
            this.ypos.TabIndex = 17;
            // 
            // zpos
            // 
            this.zpos.Location = new System.Drawing.Point(1009, 540);
            this.zpos.Multiline = true;
            this.zpos.Name = "zpos";
            this.zpos.Size = new System.Drawing.Size(224, 59);
            this.zpos.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(875, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 80);
            this.label5.TabIndex = 19;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(875, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 80);
            this.label6.TabIndex = 20;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(883, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 80);
            this.label7.TabIndex = 21;
            this.label7.Text = "Z";
            // 
            // move_btn
            // 
            this.move_btn.Location = new System.Drawing.Point(1026, 627);
            this.move_btn.Name = "move_btn";
            this.move_btn.Size = new System.Drawing.Size(173, 64);
            this.move_btn.TabIndex = 22;
            this.move_btn.Text = "move";
            this.move_btn.UseVisualStyleBackColor = true;
            this.move_btn.Click += new System.EventHandler(this.move_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 742);
            this.Controls.Add(this.move_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zpos);
            this.Controls.Add(this.ypos);
            this.Controls.Add(this.xpos);
            this.Controls.Add(this.gotopoint_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.automode_btn);
            this.Controls.Add(this.stepmode_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton gotopoint_btn;
        private System.Windows.Forms.TextBox xpos;
        private System.Windows.Forms.TextBox ypos;
        private System.Windows.Forms.TextBox zpos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button move_btn;
    }
}

