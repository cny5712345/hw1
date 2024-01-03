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
            ((System.ComponentModel.ISupportInitialize)(this.y_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axActUtlType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // stepmode_btn
            // 
            this.stepmode_btn.AutoSize = true;
            this.stepmode_btn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stepmode_btn.Location = new System.Drawing.Point(54, 157);
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
            this.automode_btn.Location = new System.Drawing.Point(54, 234);
            this.automode_btn.Margin = new System.Windows.Forms.Padding(2);
            this.automode_btn.Name = "automode_btn";
            this.automode_btn.Size = new System.Drawing.Size(84, 19);
            this.automode_btn.TabIndex = 1;
            this.automode_btn.TabStop = true;
            this.automode_btn.Text = "auto mode";
            this.automode_btn.UseVisualStyleBackColor = true;
            this.automode_btn.CheckedChanged += new System.EventHandler(this.automode_btn_CheckedChanged);
            this.automode_btn.Click += new System.EventHandler(this.automode_btn_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 100);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(371, 29);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 100);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(637, 29);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 100);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 53);
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
            this.label2.Location = new System.Drawing.Point(313, 53);
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
            this.label3.Location = new System.Drawing.Point(575, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // y_plus
            // 
            this.y_plus.Image = ((System.Drawing.Image)(resources.GetObject("y_plus.Image")));
            this.y_plus.Location = new System.Drawing.Point(256, 165);
            this.y_plus.Margin = new System.Windows.Forms.Padding(2);
            this.y_plus.Name = "y_plus";
            this.y_plus.Size = new System.Drawing.Size(85, 95);
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
            this.y_minus.Location = new System.Drawing.Point(257, 360);
            this.y_minus.Margin = new System.Windows.Forms.Padding(2);
            this.y_minus.Name = "y_minus";
            this.y_minus.Size = new System.Drawing.Size(85, 95);
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
            this.x_minus.Location = new System.Drawing.Point(167, 264);
            this.x_minus.Margin = new System.Windows.Forms.Padding(2);
            this.x_minus.Name = "x_minus";
            this.x_minus.Size = new System.Drawing.Size(85, 95);
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
            this.x_plus.Location = new System.Drawing.Point(345, 264);
            this.x_plus.Margin = new System.Windows.Forms.Padding(2);
            this.x_plus.Name = "x_plus";
            this.x_plus.Size = new System.Drawing.Size(85, 95);
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
            this.z_plus.Location = new System.Drawing.Point(458, 176);
            this.z_plus.Margin = new System.Windows.Forms.Padding(2);
            this.z_plus.Name = "z_plus";
            this.z_plus.Size = new System.Drawing.Size(85, 95);
            this.z_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.z_plus.TabIndex = 12;
            this.z_plus.TabStop = false;
            this.z_plus.Click += new System.EventHandler(this.z_plus_Click);
            // 
            // z_minus
            // 
            this.z_minus.Image = ((System.Drawing.Image)(resources.GetObject("z_minus.Image")));
            this.z_minus.Location = new System.Drawing.Point(458, 307);
            this.z_minus.Margin = new System.Windows.Forms.Padding(2);
            this.z_minus.Name = "z_minus";
            this.z_minus.Size = new System.Drawing.Size(85, 95);
            this.z_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.z_minus.TabIndex = 13;
            this.z_minus.TabStop = false;
            this.z_minus.Click += new System.EventHandler(this.z_minus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "automode";
            // 
            // gotopoint_btn
            // 
            this.gotopoint_btn.AutoSize = true;
            this.gotopoint_btn.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gotopoint_btn.Location = new System.Drawing.Point(637, 201);
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
            this.xpos.Location = new System.Drawing.Point(673, 236);
            this.xpos.Margin = new System.Windows.Forms.Padding(2);
            this.xpos.Multiline = true;
            this.xpos.Name = "xpos";
            this.xpos.Size = new System.Drawing.Size(151, 41);
            this.xpos.TabIndex = 16;
            this.xpos.TextChanged += new System.EventHandler(this.xpos_TextChanged);
            // 
            // ypos
            // 
            this.ypos.Location = new System.Drawing.Point(673, 298);
            this.ypos.Margin = new System.Windows.Forms.Padding(2);
            this.ypos.Multiline = true;
            this.ypos.Name = "ypos";
            this.ypos.Size = new System.Drawing.Size(151, 41);
            this.ypos.TabIndex = 17;
            // 
            // zpos
            // 
            this.zpos.Location = new System.Drawing.Point(673, 360);
            this.zpos.Margin = new System.Windows.Forms.Padding(2);
            this.zpos.Multiline = true;
            this.zpos.Name = "zpos";
            this.zpos.Size = new System.Drawing.Size(151, 41);
            this.zpos.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(583, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 54);
            this.label5.TabIndex = 19;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(583, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 54);
            this.label6.TabIndex = 20;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(589, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 54);
            this.label7.TabIndex = 21;
            this.label7.Text = "Z";
            // 
            // move_btn
            // 
            this.move_btn.Location = new System.Drawing.Point(684, 418);
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
            this.step_distence.Location = new System.Drawing.Point(109, 184);
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
            this.label8.Location = new System.Drawing.Point(21, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "step distance";
            // 
            // axActUtlType1
            // 
            this.axActUtlType1.Enabled = true;
            this.axActUtlType1.Location = new System.Drawing.Point(371, 184);
            this.axActUtlType1.Name = "axActUtlType1";
            this.axActUtlType1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axActUtlType1.OcxState")));
            this.axActUtlType1.Size = new System.Drawing.Size(32, 32);
            this.axActUtlType1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 495);
            this.Controls.Add(this.axActUtlType1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.step_distence);
            this.Controls.Add(this.move_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zpos);
            this.Controls.Add(this.ypos);
            this.Controls.Add(this.xpos);
            this.Controls.Add(this.gotopoint_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.z_minus);
            this.Controls.Add(this.z_plus);
            this.Controls.Add(this.x_plus);
            this.Controls.Add(this.x_minus);
            this.Controls.Add(this.y_minus);
            this.Controls.Add(this.y_plus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.automode_btn);
            this.Controls.Add(this.stepmode_btn);
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
    }
}

