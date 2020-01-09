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
    public partial class LEARN : Form
    {
        public LEARN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forloop ob = new forloop();
            ob.Show();
            this.Hide();
        }
    }
}
