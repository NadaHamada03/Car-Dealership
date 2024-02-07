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
    public partial class Service : KryptonForm
    {
        public Service()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Service_Load(object sender, EventArgs e)
        {

        }
        //back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h = new HomePage ();
            h.Show();
        }
    }
}
