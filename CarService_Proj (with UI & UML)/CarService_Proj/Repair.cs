using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CarService_Proj
{
    public partial class Repair : KryptonForm
    {
        public Repair()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //lights
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lights l = new Lights();
            l.Show();
        }
        // tyres

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tyres t = new Tyres();
            t.Show();
        }
        //back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h = new HomePage();
            h.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //bumper button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bumper b = new Bumper();
            b.Show();
        }

        private void Repair_Load(object sender, EventArgs e)
        {

        }
    }
}
