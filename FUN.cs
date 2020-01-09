using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KID__
{
    public partial class FUN : Form
    {
        public FUN()
        {
            InitializeComponent();
        }

        private void FUN_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            if(!int.TryParse(textBox1.Text,out num))
            {
                MessageBox.Show("enter a number");
            }
            else
            {
                label1.Visible = false;
                int a = Convert.ToInt32(textBox1.Text);
                int x = pictureBox1.Location.X;
                int y = pictureBox1.Location.Y;

                x = x + a*5;
                Point p = new Point(x, y);
                
                pictureBox1.Location = p;
                label1.Location = p;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(textBox1.Text, out num))
            {
                MessageBox.Show("enter a number");
            }
            else
            {
                label1.Visible = false;
                int a = Convert.ToInt32(textBox2.Text);
                int x = pictureBox1.Location.X;
                int y = pictureBox1.Location.Y;

                x = x - a * 5;
                Point p = new Point(x, y);

                pictureBox1.Location = p;
                label1.Location = p;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(textBox1.Text, out num))
            {
                MessageBox.Show("enter a number");
            }
            else
            {
                label1.Visible = false;
                int a = Convert.ToInt32(textBox3.Text);
                int x = pictureBox1.Location.X;
                int y = pictureBox1.Location.Y;

                y = y - a * 5;
                Point p = new Point(x, y);

                pictureBox1.Location = p;
                label1.Location = p;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(textBox1.Text, out num))
            {
                MessageBox.Show("enter a number");
            }
            else
            {
                label1.Visible = false;
                int a = Convert.ToInt32(textBox4.Text);
                int x = pictureBox1.Location.X;
                int y = pictureBox1.Location.Y;

                y = y + a * 5;
                Point p = new Point(x, y);

                pictureBox1.Location = p;
                label1.Location = p;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            label1.Text = "location is X:" + x.ToString() + " Y:" + y.ToString();
            label1.Visible = true;
        }
    }
}
