using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _20EventExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();//form 事件的拥有者
            Controller controller = new Controller(form);//controller 事件的响应者
            form.ShowDialog();
        }
    }

    class Controller
    {
        private Form _form;//对应事件的拥有者是事件的响应者的字段成员
        public Controller(Form form)
        {
            if (form != null)
            {
                this._form = form;
                this._form.Click += this.FormClicked;//form.click 事件成员//事件的订阅
                //对应第一种情况:事件的响应者中的事件的处理器订阅了事件的拥有者中的事件
            }
        }
        
        private void FormClicked(object sender, EventArgs e)//事件的处理器
        {
            this._form.Text = DateTime.Now.ToString();
        }
    }
}
