using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codes;
using ComponentFactory.Krypton.Toolkit;

namespace CarService_Proj
{
    public partial class Renault : KryptonForm
    {
        MeganeClass megane = new MeganeClass();
        LoganClass logan = new LoganClass();

        public Renault()
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

        private void Renault_Load(object sender, EventArgs e)
        {
            //megane specs
            MakeM.Text = megane.Manufacturer();
            ModelM.Text = megane.Model();
            YearM.Text = Convert.ToString(megane.ModelYear());
            ColorM.Text = megane.Color();
            PriceM.Text = Convert.ToString(megane.Price());

            //logan specs
            MakeL.Text = logan.Manufacturer();
            ModelL.Text = logan.Model();
            YearL.Text = Convert.ToString(logan.ModelYear());
            ColorL.Text = logan.Color();
            PriceL.Text = Convert.ToString(logan.Price());
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
