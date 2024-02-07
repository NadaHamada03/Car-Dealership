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
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //login button

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (username.Text == "Fazwy" && password.Text == "1234")
            {
                this.Hide();
                HomePage h = new HomePage();
                h.Show();
            }
            else
            {
                if (username.Text != "Fawzy")
                {
                    username.Text = "Re-enter username";
                }
                if (password.Text != "1234")
                {
                    password.Text = "Re-enter password";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
