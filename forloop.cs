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
namespace KID__
{
    public partial class forloop : Form
    {
        public forloop()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void forloop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
                Point p1 = new Point(0, 0);
                pictureBox1.Location = p1;
                int x = pictureBox1.Location.X;
                int y = pictureBox1.Location.Y;
                for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                {
                    x = x + 20;
                    Thread.Sleep(500);
                    Console.Beep();
                    Point p = new Point(x, y);
                    pictureBox1.Location = p;
                }
               
               if (textBox1.Text == "10")
                {

                    label5.Visible = true;
                }
                else
                {
                    label7.Visible = true;
                }
            
        }
    }
}
