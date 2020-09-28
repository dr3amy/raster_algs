using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raster_algs
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void Task1a_Click(object sender, EventArgs e)
        {
            (new Task1a.Task1a()).Show();
        }

        private void Task1b_Click(object sender, EventArgs e)
        {
            (new Task1b.Task1b()).Show();
        }

        private void Task2_Click(object sender, EventArgs e)
        {
            (new Task2.Form1()).Show();
        }
        private void Task3_Click(object sender, EventArgs e)
        {
            (new Task3.Form1()).Show();
        }
    }
}
