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
    public partial class HomePage : KryptonForm
    {
        public HomePage()
        {
            InitializeComponent();
        }
        //new cars
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCars n = new NewCars();
            n.Show();
        }
        //services button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service s = new Service();
            s.Show();
        }
        //repair button
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repair r = new Repair();
            r.Show();
        }
        //back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
