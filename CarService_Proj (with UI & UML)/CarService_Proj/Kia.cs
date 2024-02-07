using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codes;
using ComponentFactory.Krypton.Toolkit;

namespace CarService_Proj
{
    public partial class Kia : KryptonForm
    {
        SportageClass sportage = new SportageClass();
        CeratoClass cerato = new CeratoClass();
        public Kia()
        {
            InitializeComponent();
        }

        private void Kia_Load(object sender, EventArgs e)
        {
            //cerato specs
            MakeC.Text = cerato.Manufacturer();
            ModelC.Text = cerato.Model();
            YearC.Text = Convert.ToString(cerato.ModelYear());
            ColorC.Text = cerato.Color();
            PriceC.Text = Convert.ToString(cerato.Price());

            //sportage specs
            MakeS.Text = sportage.Manufacturer();
            ModelS.Text = sportage.Model();
            YearS.Text = Convert.ToString(sportage.ModelYear());
            ColorS.Text = sportage.Color();
            PriceS.Text = Convert.ToString(sportage.Price());
        }

        private void MakeC_Click(object sender, EventArgs e)
        {
            
        }

        private void ModelC_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCars n = new NewCars();
            n.Show();
        }

        private void preorder_Click(object sender, EventArgs e)
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
