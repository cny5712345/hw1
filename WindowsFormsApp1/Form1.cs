using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int now_mode;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // form1具現在視窗上時 自動執行
            //連線到機台0
            // 初始 x y z 各參數
            //設定timer開始讀取各參數(view_label)

        }
        private void ManualSet()
        {
            //設定步近距離(讀取)
            //設定xyz速度=3000
            double _SpeedRateVal = 100;
            //PLCAction.ManualSet(_StepDistVal,
            // _XSpeedVal, _YSpeedVal, _ZSpeedVal, _SpeedRateVal);// for 吋動需要修改步階距離

        }
        private void view_label()
        {
            // read "D1000\nD1001\nD1010\nD1011\nR1000\nR1001\nR1010\nR1011\nD1006\nD1007" //1-2-3-4-5
            //+"\nD1016\nD1017\nR1002\nR1003\nR1012\nR1013\nM1107\nM1117\nM1102\nM1105" //6-7-8--9-10-11-12
            //+ "\nM1112\nM1115\nM1209\nM1600\nM1601\nM1602\nM1603\nM1604\nM1605\nM1606" //13-14-15-16-17-18-19-20-21-22
            //+ "\nM1607\nM1608\nM1609\nM1610\nM1611\nM1602\nM1002\nM1012\nD1020\nD1021"// 23-24-25-26-27-28-29-30--31
            //+ "\nR1020\nR1021\nD1026\nD1027\nR1022\nR1023\nM1122\nM1125"//32-33-34--35-36
            //+ "\nM1613\nM1614\nM1615", 51
            //放 xyz當前位置在面板上
            textBox1.Text = ; 
            textBox1.Text = ;
            textBox1.Text = ;

        }

        private void stepmode_CheckedChanged(object sender, EventArgs e)
        {
            now_mode = 2;
            ManualSet();
            gotopoint_btn.Checked = false;
            move_btn.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gotopoint_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void move_btn_Click(object sender, EventArgs e)
        {

        }

        private void automode_btn_CheckedChanged(object sender, EventArgs e)
        {
            now_mode = 1;
            ManualSet();
            gotopoint_btn.Checked = true;
            move_btn.Enabled = true ;
        }
    }



}
