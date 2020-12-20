using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _20EventExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            myForm form = new myForm();
            form.ShowDialog();
        }
    }
    class myForm:Form
    {
        private TextBox textBox;
        private Button button;

        public myForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.button.Click += this.ButtonClicked;
            this.button.Text = "Say Hello";
            this.button.Top = 100;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello,World!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
        }
    }
}
