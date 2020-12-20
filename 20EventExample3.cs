using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _20EventExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();//事件的拥有者 form
            form.Click += form.FormClicked;//事件 Click   //事件的响应者 form   //事件的处理器 FormClicked方法  //+=事件的合并
            form.ShowDialog();
        }
    }
    class MyForm : Form
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
