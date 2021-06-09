using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_4_
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Label №" + cnt.ToString();
            label.Font = new Font("Arial", 10, FontStyle.Bold);
            label.Location = new Point(15, 30 * cnt);
            label.Size = new Size(800, 20);
            this.Controls.Add(label);
            cnt++;
        }
    }
}
