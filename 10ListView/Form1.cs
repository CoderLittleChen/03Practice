using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置subitems是item的子项，可以理解为item里又扩展出一个listview来存储
            //不同的地方是listview下标从0开始，subitem下标从1开始

            //注意ListView先要设置View.Details 模式
            //然后要设置列头
            listView1.View = View.Details;
            //先要设置列头
            ColumnHeader ch1 = new ColumnHeader();
            ch1.Text = "列标题1";
            listView1.Columns.Add(ch1);

            ColumnHeader ch2 = new ColumnHeader();
            ch2.Text = "列标题2";
            listView1.Columns.Add(ch2);

            ColumnHeader ch3 = new ColumnHeader();
            ch3.Text = "列标题3";
            listView1.Columns.Add(ch3);

            ColumnHeader ch4 = new ColumnHeader();
            ch4.Text = "列标题4";
            listView1.Columns.Add(ch4);

            //显示结果  dsad  测试1  测试2  
            ListViewItem item = new ListViewItem();
            //最终显示为   dsad  测试1  测试2  测试3
            //Text属性为第一
            item.Text = "dsad";
            item.SubItems.Add("测试1");
            item.SubItems.Add("测试2");
            item.SubItems.Add("测试3");

            ListViewItem item1 = new ListViewItem();
            item1.Text = "1231";

            ListViewItem item2 = new ListViewItem();
            item2.Text = "789";

            listView1.Items.Add(item);
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);



            //ListViewItem item1 = listView1.Items.Add("第一行的第一列");
            //item1.SubItems.Add("第一行的第二列");
            //item1.SubItems.Add("第一行的第三列");

            //listView1.Items.Add(item1);

        }
    }
}
