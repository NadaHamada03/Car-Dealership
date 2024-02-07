using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codes;
using ComponentFactory.Krypton.Toolkit;

namespace CarService_Proj
{
    public partial class Toyota : KryptonForm
    {
        CorollaClass corolla = new CorollaClass();
        YarisClass yaris = new YarisClass();    

        public Toyota()
        {
            InitializeComponent();
        }
        //back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCars n = new NewCars();
            n.Show();
        }

        private void Toyota_Load(object sender, EventArgs e)
        {

            //corolla specs
            MakeCorolla.Text = corolla.Manufacturer();
            ModelCorolla.Text = corolla.Model();
            YearCorolla.Text = Convert.ToString(corolla.ModelYear());
            ColorCorolla.Text = corolla.Color();
            PriceCorolla.Text = Convert.ToString(corolla.Price());

            //yaris specs
            MakeY.Text = yaris.Manufacturer();
            ModelY.Text = yaris.Model();
            YearY.Text = Convert.ToString(yaris.ModelYear());
            ColorY.Text = yaris.Color();
            PriceY.Text = Convert.ToString(yaris.Price());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmPreOrder order = new ConfirmPreOrder();
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfirmPreOrder order = new ConfirmPreOrder();
            order.Show();
        }
    }
}
