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
    public partial class NewCars : KryptonForm
    {
        public NewCars()
        {
            InitializeComponent();
        }
        // back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h = new HomePage();
            h.Show();

        }
        // toyota button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Toyota t = new Toyota();
            t.Show();
        }
        // kia button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kia k = new Kia();
            k.Show();
        }

        //renault button

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Renault r = new Renault();
            r.Show();
        }

        private void kryptonPalette1_PalettePaint(object sender, ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }

        private void NewCars_Load(object sender, EventArgs e)
        {

        }
    }
}
