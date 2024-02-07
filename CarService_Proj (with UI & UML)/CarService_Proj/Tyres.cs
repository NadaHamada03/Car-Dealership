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
    public partial class Tyres : KryptonForm
    {
        public Tyres()
        {
            InitializeComponent();
        }
        //back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repair r = new Repair();
            r.Show();
        }

        private void Tyres_Load(object sender, EventArgs e)
        {

        }
    }
}
