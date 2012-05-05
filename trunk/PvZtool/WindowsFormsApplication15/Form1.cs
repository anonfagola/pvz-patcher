using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
using System.Net;
namespace WindowsFormsApplication15
{
    public partial class Form1 : Office2007Form
    {
        string saveFD = "";
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            saveFD = OFD.FileName;
            
        }


        public void Savecontrol(object sender, EventArgs e)
        {
            {
                OpenFileDialog OFD = new OpenFileDialog();
                if (OFD.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                saveFD = OFD.FileName;
                FileStream stream = new FileStream(saveFD, FileMode.Open, FileAccess.ReadWrite);
                BinaryReader reader = new BinaryReader(stream);
                reader.BaseStream.Position = 0x4;

                byte br = reader.ReadByte();
               
                byte b = (byte)br;
                string level = br.ToString("X");
                if (level == "01")
                {
                    comboBox1.SelectedItem = "1-1";
                }
                if (level == "02")
                {
                    comboBox1.SelectedItem = "1-2";
                }
                if (level == "03")
                {
                    comboBox1.SelectedItem = "1-3";
                }
                if (level == "04")
                {
                    comboBox1.SelectedItem = "1-4";
                }
                if (level == "05")
                {
                    comboBox1.SelectedItem = "1-5";
                }
                if (level == "06")
                {
                    comboBox1.SelectedItem = "1-6";
                }
                if (level == "07")
                {
                    comboBox1.SelectedItem = "1-7";
                }
                if (level == "08")
                {
                    comboBox1.SelectedItem = "1-8";
                }
                if (level == "09")
                {
                    comboBox1.SelectedItem = "1-9";
                }
                if (level == "0A")
                {
                    comboBox1.SelectedItem = "1-10";
                }
                if (level == "0B")
                {
                    comboBox1.SelectedItem = "2-1";
                }
                if (level == "0C")
                {
                    comboBox1.SelectedItem = "2-2";
                }
                if (level == "0D")
                {
                    comboBox1.SelectedItem = "2-3";
                }
                if (level == "0E")
                {
                    comboBox1.SelectedItem = "2-4";
                }
                if (level == "0F")
                {
                    comboBox1.SelectedItem = "2-5";
                }
                if (level == "10")
                {
                    comboBox1.SelectedItem = "2-6";
                }
                if (level == "11")
                {
                    comboBox1.SelectedItem = "2-7";
                }
                if (level == "12")
                {
                    comboBox1.SelectedItem = "2-8";
                }
                if (level == "13")
                {
                    comboBox1.SelectedItem = "2-9";
                }
                if (level == "14")
                {
                    comboBox1.SelectedItem = "2-10";
                }
                if (level == "15")
                {
                    comboBox1.SelectedItem = "3-1";
                }
                if (level == "16")
                {
                    comboBox1.SelectedItem = "3-2";
                }
                if (level == "17")
                {
                    comboBox1.SelectedItem = "3-3";
                }
                if (level == "18")
                {
                    comboBox1.SelectedItem = "3-4";
                }
                if (level == "19")
                {
                    comboBox1.SelectedItem = "3-2";
                }
                reader.BaseStream.Position = 0x8;
                integerInput1.Value = reader.ReadInt32();




                reader.BaseStream.Position = 0xC;
                string br2 = reader.ReadByte().ToString();
                if (br2 != "00")
                {
                    checkBoxX1.Checked = true;
                    
                }

            }
        }


        public static byte[] ConvertInt32ToByteArray(int I)
        {

            return BitConverter.GetBytes(I);

        }
        public string GetLevel(string lvl)
        {
            
            comboBox1.SelectedItem = GetLevel(br.ToString("X"));
            switch (lvl)
            {
                case "01": return "1-1";
                case "02": return "1-2";
                case "03": return "1-3";
                case "04": return "1-4"; 
                    // do that later
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.icheats.org/forum/");
        }
    }
}
