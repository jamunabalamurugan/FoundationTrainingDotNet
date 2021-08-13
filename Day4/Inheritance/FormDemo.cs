using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkwithInheritance
{
    class FormDemo:Form
    {
        public FormDemo()
        {
            Button b1 = new Button();
            b1.Text = "Clickme";
            b1.Height = 30;
            b1.Width = 100;
            b1.Location = new System.Drawing.Point(30, 40);
            this.Controls.Add(b1);
            b1.Click += new System.EventHandler(show);
          
        }
        static void Main()
        {
           // FormDemo ob = new FormDemo();
            Application.Run(new FormDemo());
          
        }
        public void show(object sender, EventArgs e)
        {
            MessageBox.Show("hi ");
        }
    }
}
