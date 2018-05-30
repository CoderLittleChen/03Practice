using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12程序的启动路径问题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //F:\cm\OneDrive\文档\MySelf\平时练习\Test\12程序的启动路径问题\bin\Debug

            //Application.StartupPath  这里拿到得就是 程序的启动路径，也就是exe文件所在的路径
            MessageBox.Show(Application.StartupPath);
        }
    }
}
