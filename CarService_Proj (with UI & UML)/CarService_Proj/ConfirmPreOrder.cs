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
    public partial class ConfirmPreOrder : KryptonForm
    {
        public ConfirmPreOrder()
        {
            InitializeComponent();
        }

        private void ConfirmPreOrder_Load(object sender, EventArgs e)
        {

        }

        private void preorderY_Click(object sender, EventArgs e)
        {
            confirmed.Text = "You will be contacted soon.";
        }

        private void preorderN_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
