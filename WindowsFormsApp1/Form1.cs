using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        int now_mode;
        public Form1()
        {
            InitializeComponent();
            move_btn.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int re_num;
            //form1具現在視窗上時 自動執行

            link(); //連結機台
            value_initial();// 初始 x y z 各參數
            Thread thread = new Thread(new ThreadStart(setXYZlabel));
            thread.Start();
            //ManualAsn PosMoveBtn.Enabled = false;
        }

        delegate void agent();
        private void setXYZlabel()
        {        
           while(true)
           {
                this.Invoke((EventHandler)delegate
                {
                    List<double> real_num = readrandom_Click("D1000\nD1001\nD1010\nD1011\nR1000\nR1001\nR1010\nR1011\nD1006\nD1007" //1-2-3-4-5
            + "\nD1016\nD1017\nR1002\nR1003\nR1012\nR1013\nM1107\nM1117\nM1102\nM1105" //6-7-8--9-10-11-12
            + "\nM1112\nM1115\nM1209\nM1600\nM1601\nM1602\nM1603\nM1604\nM1605\nM1606" //13-14-15-16-17-18-19-20-21-22
            + "\nM1607\nM1608\nM1609\nM1610\nM1611\nM1602\nM1002\nM1012\nD1020\nD1021"// 23-24-25-26-27-28-29-30--31
            + "\nR1020\nR1021\nD1026\nD1027\nR1022\nR1023\nM1122\nM1125"//32-33-34--35-36
            + "\nM1613\nM1614\nM1615", 51);
                    textBox1.Text = (Math.Round(real_num[0], 3) / 10000).ToString();
                    textBox2.Text = (Math.Round(real_num[1], 3) / 10000).ToString();
                    textBox3.Text = (Math.Round(real_num[30], 3) / 10000).ToString();

                });
                Thread.Sleep(500);
                

           }
        }
        public void set_step_value()
        {
          
            double StepDistVal = Convert.ToDouble(step_distence.Text)*10000;
            double XSpeedVal = 3000 * 100;//Convert.ToDouble(ManualXSpeedTxtBox.Text);
            double YSpeedVal = 3000 * 100;//Convert.ToDouble(ManualYSpeedTxtBox.Text);
            double ZSpeedVal = 3000 * 100;//Convert.ToDouble(ManualZSpeedTxtBox.Text);
            double SpeedRateVal = 100*10;//Convert.ToDouble(ManualSpeedRateLbl.Text);

            writedevice("R1202", 2, StepDistVal);//寫入吋動距離
            writedevice("R1002", 2, XSpeedVal);//寫入X軸速度
            writedevice("R1012", 2, YSpeedVal);//寫入Y軸速度
            writedevice("R1022", 2, ZSpeedVal);//寫入z軸速度
            writedevice("R1200", 2,SpeedRateVal);//寫入速度比例
        }
        

        private void automode_btn_CheckedChanged(object sender, EventArgs e)
        {
            now_mode = 1;
            set_step_value();
            gotopoint_btn.Checked = false;
            move_btn.Enabled = false;
            axActUtlType1.SetDevice("M1201", 0);//連續移動
            move_btn.Enabled = false;
        }
        private void stepmode_CheckedChanged(object sender, EventArgs e)
        {
            now_mode = 2;
            set_step_value();
            gotopoint_btn.Checked = false;
            move_btn.Enabled = false;
            axActUtlType1.SetDevice("M1201", 1);//步階
            move_btn.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void y_plus_Click(object sender, EventArgs e)
        {
            if (now_mode == 2)
            {
                set_step_value();
                step_move("y_plus");
            }
            else return ;
        }
        private void y_plus_MouseClick(object sender, EventArgs e)
        {

        }

        private void gotopoint_btn_CheckedChanged(object sender, EventArgs e)
        {
            stepmode_btn.Checked = false;
            automode_btn.Checked = false;
            now_mode = 3;
            move_btn.Enabled = true;
        }

        private void move_btn_Click(object sender, EventArgs e)
        {
            int x_pos, y_pos, z_pos;
            int SpeedRate = 50;
            x_pos = Convert.ToInt32(xpos.Text) * 10000;
            y_pos = Convert.ToInt32(ypos.Text) * 10000;
            z_pos = Convert.ToInt32(zpos.Text) * 10000;
            if(now_mode==3)
            {
                //CancellationTokenSource x_token = new CancellationTokenSource();
                //CancellationToken token = x_token.Token;
                Thread x_go_point = new Thread(() => x_do(x_pos, SpeedRate));
                Thread y_go_point = new Thread(() => y_do(y_pos, SpeedRate));
                Thread z_go_point = new Thread(() => z_do(z_pos, SpeedRate));
                x_go_point.Start();
                y_go_point.Start();
                z_go_point.Start();
            }

        }
        public void x_do(int x_pos, int SpeedRate)
        {
            short[] x_short = int2short(x_pos);
            //寫速度，最後的*100是因為R1002的單位是0.01mm
            short[] XSpeed = int2short((3000 * SpeedRate / 100) * 100);
            axActUtlType1.WriteDeviceBlock2("R1002", 2, ref XSpeed[0]);

            //目標位置
            axActUtlType1.WriteDeviceBlock2("R1000",
                                         2, ref x_short[0]);

            axActUtlType1.SetDevice("M1002", 1);
            while (true)
            {
                List<Double> return_num = readrandom_Click("D1000\nD1001\nM1105\nM1102", 4);
                if (Math.Round(return_num[0]) == x_pos)
                {
                    //Console.WriteLine("M1105 = "+ return_num[1]);
                    //Console.WriteLine("M1102 = " + return_num[2]);
                    break;
                }
            }
            axActUtlType1.SetDevice("M1002", 0);
        }
        public void y_do(int y_pos, int SpeedRate)
        {
            short[] y_short = int2short(y_pos);
            //寫速度，最後的*100是因為R1002的單位是0.01mm
            short[] ySpeed = int2short((3000 * SpeedRate / 100) * 100);
            axActUtlType1.WriteDeviceBlock2("R1012", 2, ref ySpeed[0]);

            //目標位置
            axActUtlType1.WriteDeviceBlock2("R1010",
                                         2, ref y_short[0]);

            axActUtlType1.SetDevice("M1012", 1);
            while (true)
            {
                List<Double> return_num = readrandom_Click("D1010\nD1011\nM1115\nM1112", 4);
                if (Math.Round(return_num[0]) == y_pos)
                {
                    //Console.WriteLine("M1115 = " + return_num[1]);
                    //Console.WriteLine("M1112 = " + return_num[2]);
                    break;
                }
            }
            axActUtlType1.SetDevice("M1012", 0);
        }
        public void z_do(int z_pos, int SpeedRate)
        {
            short[] z_short = int2short(z_pos);
            //寫速度，最後的*100是因為R1002的單位是0.01mm
            short[] zSpeed = int2short((3000 * SpeedRate / 100) * 100);
            axActUtlType1.WriteDeviceBlock2("R1022", 2, ref zSpeed[0]);

            //目標位置
            axActUtlType1.WriteDeviceBlock2("R1020",
                                         2, ref z_short[0]);

            axActUtlType1.SetDevice("M1022", 1);
            while (true)
            {
                List<Double> return_num = readrandom_Click("D1020\nD1021", 2);
                if (Math.Round(return_num[0]) == z_pos)
                {
                    //Console.WriteLine("M1115 = " + return_num[1]);
                    //Console.WriteLine("M1112 = " + return_num[2]);
                    break;
                }
            }
            axActUtlType1.SetDevice("M1022", 0);
        }



        public void value_initial()
        {
            //x軸相關
            axActUtlType1.SetDevice("M1000", 0);
            axActUtlType1.SetDevice("M1001", 0);
            axActUtlType1.SetDevice("M1002", 0);
            axActUtlType1.SetDevice("M1003", 0);

            axActUtlType1.SetDevice("M1103", 0);

            //y軸相關
            axActUtlType1.SetDevice("M1010", 0);
            axActUtlType1.SetDevice("M1011", 0);
            axActUtlType1.SetDevice("M1012", 0);
            axActUtlType1.SetDevice("M1013", 0);

            axActUtlType1.SetDevice("M1113", 0);

            //z軸相關
            axActUtlType1.SetDevice("M1020", 0);
            axActUtlType1.SetDevice("M1021", 0);
            axActUtlType1.SetDevice("M1022", 0);
            axActUtlType1.SetDevice("M1023", 0);

            axActUtlType1.SetDevice("M1123", 0);

            //axActUtlType1.SetDevice("M1200", 0);
            //axActUtlType1.SetDevice("M1202", 0);

            }

        private void step_distence_TextChanged(object sender, EventArgs e)
        {

        }

        private void x_plus_Click(object sender, EventArgs e)
        {
            if (now_mode == 2)
            {
                set_step_value();
                step_move("x_plus");
            }
                
        }

        private void y_minus_Click(object sender, EventArgs e)
        {
            if(now_mode == 2)
            {
                set_step_value();
                step_move("y_minus");
            }
            
            
        }

        private void x_minus_Click(object sender, EventArgs e)
        {
            if (now_mode == 2)
            {
                set_step_value();
                step_move("x_minus");
            }
                
        }

        private void z_plus_Click(object sender, EventArgs e)
        {
            if (now_mode == 2)
            {
                set_step_value();
                step_move("z_plus");
            }
                
        }

        private void z_minus_Click(object sender, EventArgs e)
        {
            if(now_mode == 2)
            {
                set_step_value();
                step_move("z_minus");
            }
            
        }

        private void y_plus_mousedown(object sender, MouseEventArgs e)
        {
            int re_num;
            if (now_mode == 1)
            { 
                set_step_value();
                Console.WriteLine("aaa");
                re_num=axActUtlType1.SetDevice("M1201", 0);//連續移動(滑鼠一值按著)
              
                re_num =axActUtlType1.SetDevice("M1010", 1);//Y正向
    
            }
        }

        private void y_plus_mouseup(object sender, MouseEventArgs e)
        {
            set_step_value();
            ManualContinousPause();
       
        }
        private void y_minus_mousedown(object sender, MouseEventArgs e)
        {
            if (now_mode == 1)
            {
                set_step_value();
                axActUtlType1.SetDevice("M1201", 0);//連續移動(滑鼠一值按著)
                axActUtlType1.SetDevice("M1011", 1);//Y反向
            }
        }

        private void y_minus_mouseup(object sender, MouseEventArgs e)
        {
            ManualContinousPause();
        }
        private void x_plus_mousedown(object sender, MouseEventArgs e)
        {
            if (now_mode == 1)
            {
                set_step_value();
                axActUtlType1.SetDevice("M1201", 0);//連續移動(滑鼠一值按著)
                axActUtlType1.SetDevice("M1001", 1);//X正向
            }
        }

        private void x_plus_mouseup(object sender, MouseEventArgs e)
        {
            ManualContinousPause();
        }

        private void x_minus_mousedown(object sender, MouseEventArgs e)
        {
            if (now_mode == 1)
            {
                set_step_value();
                axActUtlType1.SetDevice("M1201", 0);//連續移動(滑鼠一值按著)
                axActUtlType1.SetDevice("M1000", 1);//X反向
            }
        }

        private void x_minus_mouseup(object sender, MouseEventArgs e)
        {
            ManualContinousPause();
        }

        private void z_plus_mousedown(object sender, MouseEventArgs e)
        {
            if (now_mode == 1)
            {
                set_step_value();
                axActUtlType1.SetDevice("M1201", 0);//連續移動(滑鼠一值按著)
                axActUtlType1.SetDevice("M1020", 1);//z正向
            }
        }

        private void z_plus_mouseup(object sender, MouseEventArgs e)
        {
            if (now_mode == 1)
            {
                set_step_value();
                axActUtlType1.SetDevice("M1201", 0);//連續移動(滑鼠一值按著)
                axActUtlType1.SetDevice("M1020", 0);//X正向
            }
        }
        private void z_minus_mousedown(object sender, MouseEventArgs e)
        {
            if (now_mode == 1)
            {
                set_step_value();
                axActUtlType1.SetDevice("M1201", 0);//連續移動(滑鼠一值按著)
                axActUtlType1.SetDevice("M1021", 1);//Z反向
            }
        }
        private void z_minus_mouseup(object sender, MouseEventArgs e)
        {
            if (now_mode == 1)
            {
                set_step_value();
                axActUtlType1.SetDevice("M1201", 0);//連續移動(滑鼠一值按著)
                axActUtlType1.SetDevice("M1021", 0);//X正向
            }
        }


        private void automode_btn_click(object sender, EventArgs e)
        {
            
        }
        private void xpos_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int re_num;
            re_num = axActUtlType1.SetDevice("M1010", 1);//Y正向
           
        }
        public List<double> readrandom_Click(string mylabelname, int mydatasize)
        {
            int iReturnCode;
            short[] mydataarr = new short[mydatasize];
            iReturnCode = axActUtlType1.ReadDeviceRandom2(mylabelname,
                                                            mydatasize, out mydataarr[0]
              );

            List<double> realval_list = new List<double>() { };
            string[] name = mylabelname.Split('\n');
            for (int i = 0; i < mydataarr.Length; i++)
            {
                
                if (name[i].Substring(0, 1) == "D" || name[i].Substring(0, 1) == "R")
                {
                    realval_list.Add(short2int(mydataarr[i], mydataarr[i + 1]));
                    i++;
                }
                else
                {
                    realval_list.Add(mydataarr[i]);
                }
            }
            return realval_list;
        }
        public int short2int(short num1, short num2)
        {
            int ret_val;
            byte[] byte_arr_1 = BitConverter.GetBytes(num1);
            byte[] byte_arr_2 = BitConverter.GetBytes(num2);

            byte_arr_1 = byte_arr_1.Concat(byte_arr_2).ToArray();
            ret_val = BitConverter.ToInt32(byte_arr_1, 0);
            return ret_val;
        }
        public short[] int2short(int num)
        {

            byte[] bytes = BitConverter.GetBytes(num);
            short firstHalf = BitConverter.ToInt16(bytes, 0);
            short secondHalf = BitConverter.ToInt16(bytes, 2);
            short[] returnnum = new short[2];
            returnnum[0] = firstHalf;
            returnnum[1] = secondHalf;

            return returnnum;
        }
        public void link()
        {
            int re_num;
            axActUtlType1.ActLogicalStationNumber = 0;
            re_num = axActUtlType1.Open();
         
        }
        public void writedevice(string mylabelname, int mydatasize, double devicedata)
        {
            short[] devicedata_arr;
            short devicedata_short;
            int return_num;
            devicedata_arr = int2short(Convert.ToInt32(devicedata));
            //記得改掉
            try
            {
                return_num = axActUtlType1.WriteDeviceBlock2(mylabelname,
                                             mydatasize,
                                     ref devicedata_arr[0]);
             
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
        public void step_move(string axis)
        {
            axActUtlType1.SetDevice("M1201", 1);//連續移動(滑鼠按一次只移動一定距離)
            //X正向 
            if (axis == "x_minus")
            {
                axActUtlType1.SetDevice("M1000", 1);
                while (true)
                {
                    List<double> _ReadVal = readrandom_Click("M1100\nM1105", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                    {
                        break;
                    }
                }
                axActUtlType1.SetDevice("M1000", 0);

            }
            //X負向 
            else if (axis == "x_plus")
            {
                axActUtlType1.SetDevice("M1001", 1);
                while (true)
                {
                    List<double> _ReadVal = readrandom_Click("M1101\nM1105", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1001", 0);
            }
            //y正向
            else if (axis == "y_plus")
            {
                axActUtlType1.SetDevice("M1010", 1);
                while (true)
                {
                    List<double> _ReadVal = readrandom_Click("M1110\nM1115", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1010", 0);
            }
            //y負向
            else if (axis == "y_minus")
            {
                axActUtlType1.SetDevice("M1011", 1);//y正向                                 
                while (true)
                {
                    List<double> _ReadVal = readrandom_Click("M1111\nM1115", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1011", 0);
            }
            //z正向 
            else if (axis == "z_plus")
            {
                axActUtlType1.SetDevice("M1020", 1);
                while (true)
                {
                    List<double> _ReadVal = readrandom_Click("M1120\nM1125", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1020", 0);
            }
            //z負向 
            else if (axis == "z_minus")
            {
                axActUtlType1.SetDevice("M1021", 1);
                while (true)
                {
                    List<double> _ReadVal = readrandom_Click("M1121\nM1125", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1021", 0);
            }
        }
        public void ManualContinousPause()
        {
            //停止
            axActUtlType1.SetDevice("M1001", 0);//X正向                                     
            axActUtlType1.SetDevice("M1000", 0);//X反向                                          
            axActUtlType1.SetDevice("M1010", 0);//Y正向                                        
            axActUtlType1.SetDevice("M1011", 0);//Y反向                                         
            axActUtlType1.SetDevice("M1020", 0);//Z正向                                        
            axActUtlType1.SetDevice("M1021", 0);//Z反向                                     
        }

        private void gohome_btn(object sender, EventArgs e)
        {
            Thread gohome = new Thread(new ThreadStart(gohome_do));
            gohome.Start();
        }
        public void gohome_do()
        {
            //z軸
            axActUtlType1.SetDevice("M1023", 1);
            while (true)
            {
                List<double> read_val = readrandom_Click("D1020\nD1021\nM1128", 3);
                //Console.WriteLine("read_val[0]="+read_val[0]);
                //Console.WriteLine("read_val[1]=" + read_val[1]);
                if (Math.Round(read_val[0]) == 3000000 && //OriZ && 
                    read_val[1] == 0)
                    break;
            }
            axActUtlType1.SetDevice("M1023", 0);
            Console.Write("z軸賦歸完成");

            //y軸
            axActUtlType1.SetDevice("M1013", 1);
            while (true)
            {
                List<double> read_val = readrandom_Click("D1010\nD1011\nM1118", 3);
                if (read_val[0] == 3000000 && //OriZ && 
                    read_val[1] == 0)
                    break;
            }
            axActUtlType1.SetDevice("M1013", 0);

            //x軸
            axActUtlType1.SetDevice("M1003", 1);
            while (true)
            {
                List<double> read_val = readrandom_Click("D1000\nD1001\nM1108", 3);
                if (read_val[0] == 3000000 && //OriZ && 
                    read_val[1] == 0)
                    break;
            }
            axActUtlType1.SetDevice("M1003", 0);


            ////Z軸復歸
            //axActUtlType1.SetDevice("M1023", 0);
            //axActUtlType1.SetDevice("M1023", 1);
            //while (true)
            //{
            //    double[] _ReadVal = ReadPLCDataRandom("D1020\nD1021\nM1128", 3);


            //    if (_ReadVal[0] == 300 && //OriZ && 
            //        _ReadVal[1] == 0)
            //        break;
            //}

            ////y軸復歸
            //axActUtlType1.SetDevice("M1013", 0);
            //axActUtlType1.SetDevice("M1013", 1);
            //while (true)
            //{
            //    double[] _ReadVal = ReadPLCDataRandom("D1010\nD1011\nM1118", 3);


            //    if (_ReadVal[0] == 300 && // OriY && 
            //        _ReadVal[1] == 0)
            //        break;
            //}

            ////x軸復歸
            //axActUtlType1.SetDevice("M1003", 0);
            //axActUtlType1.SetDevice("M1013", 0);
            //axActUtlType1.SetDevice("M1003", 1);

            //while (true)
            //{
            //    double[] _ReadVal = ReadPLCDataRandom("D1000\nD1001\nM1108", 3);


            //    if (_ReadVal[0] == 300 &&//OriX && 
            //        _ReadVal[1] == 0)
            //        break;
            //}





            //axActUtlType1.SetDevice("M1003", 0);
            //axActUtlType1.SetDevice("M1013", 0);
            //axActUtlType1.SetDevice("M1023", 0);

            //axActUtlType1.SetDevice("M1202", 1);
            //axActUtlType1.SetDevice("M1202", 0);
            //axActUtlType1.SetDevice("M1200", 1);
            //axActUtlType1.SetDevice("M1200", 0);

            //MessageBox.Show(this, "復歸完成!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axActUtlType1.SetDevice("M1202", 1);
            value_initial();
            Thread.Sleep(1000);
            axActUtlType1.SetDevice("M1202", 0);
            Console.Write("aaaaaaaaaaaaaaaaaaaaaaaa");
        }

        private void label9_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ret_num;
            ret_num = axMMMark1.Initial();
             axMMMark1.LoadFile("C:/Users/MyUser/Desktop/test0105.ezm");
            Console.WriteLine("ret_num = " + ret_num);
        }


    }
}
