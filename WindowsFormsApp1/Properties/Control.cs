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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }
        public List<int> readrandom_Click(string mylabelname, int mydatasize)
        {
            int iReturnCode;
            short[] mydataarr = new short[mydatasize];
            iReturnCode = axActUtlType1.ReadDeviceRandom2(mylabelname,
                                                            mydatasize, out mydataarr[0]
              );

            List<int> realval_list = new List<int>() { };
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
            axActUtlType1.ActLogicalStationNumber = 0;
            iReturnCode = this.axActUtlType1.Open();
        }
        public void writedevice(string mylabelname, int mydatasize, double devicedata)
        {
            short[] devicedata_arr;
            short devicedata_short;
            devicedata_arr = int2short(Convert.ToInt32(devicedata));
            //記得改掉
            try
            {
                axActUtlType1.WriteDeviceBlock2(mylabelname,
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
            //X正向 
            if (ActionPos == "x_plus")
            {
                axActUtlType1.SetDevice("M1000", 1);
                while (true)
                {
                    List<int> _ReadVal = readrandom_Click("M1100\nM1105", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1000", 0);
            }
            //X負向 
            if (ActionPos == "x_minus")
            {
                axActUtlType1.SetDevice("M1001", 1);
                while (true)
                {
                    List<int> _ReadVal = readrandom_Click("M1101\nM1105", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1001", 0);
            }
            //y正向
            elif(ActionPos == "y_plus")
            {
                axActUtlType1.SetDevice("M1010", 1);
                while (true)
                {
                    List<int> _ReadVal = readrandom_Click("M1110\nM1115", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1010", 0);
            }
            //y負向
            elif(ActionPos == "y_minus")
            {
                axActUtlType1.SetDevice("M1011", 1);//y正向                                 
                while (true)
                {
                    List<int> _ReadVal = readrandom_Click("M1110\nM1115", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1011", 0);
            }
            //z正向 
            if (ActionPos == "z_plus")
            {
                axActUtlType1.SetDevice("M1020", 1);
                while (true)
                {
                    List <int> _ReadVal = readrandom_Click("M1120\nM1125", 2);
                    if (_ReadVal[0] == 1 && _ReadVal[1] == 0)
                        break;
                }
                axActUtlType1.SetDevice("M1020", 0);
            }
            //z負向 
            if (ActionPos == "z_minus")
            {
                axActUtlType1.SetDevice("M1021", 1);
                while (true)
                {
                    List<int> _ReadVal = readrandom_Click("M1121\nM1125", 2);
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
    }
}
