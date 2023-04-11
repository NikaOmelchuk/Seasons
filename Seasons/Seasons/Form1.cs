using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seasons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Obs n1, n2, n3, n4;
        InformNotify In = new InformNotify();
        Information inf;

        void opov(int f, int t, int d)
        {
            this.BackgroundImage = imageList1.Images[f];
            pictureBox1.Image = imageList1.Images[t];
            pictureBox2.Image = imageList1.Images[d];

            In = new InformNotify(f, t, d);
            not();
        }

        void not()
        {

            if (button6.Enabled == false)
            {
                inf = new Information();

                n1 = new LetoObs();
                inf.Attach(n1);

                n2 = new ZymaObs();
                inf.Attach(n2);

                n3 = new VesnaObs();
                inf.Attach(n3);

                n4 = new OsenObs();
                inf.Attach(n4);

                label1.Text = inf.Notify(In);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            opov(3,4,5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button6.Enabled = false;
            not();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "...";
            button6.Enabled = true;
            inf.Detach(n1);
            inf.Detach(n2);
            inf.Detach(n3);
            inf.Detach(n4);
            button5.Enabled = false;
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            opov(0, 1, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opov(6, 7, 8);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opov(9, 10, 11);
        }
    }
}
