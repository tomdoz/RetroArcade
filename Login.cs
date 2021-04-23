using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace downbadArcade
{
    public partial class Login : Form
    {

        GameSelection gameSelection = new GameSelection();
        Register goToRegister = new Register();

        public Login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameSelection.Show();
            this.Hide();
        }

        private void GoToRegister_Click(object sender, EventArgs e)
        {
            goToRegister.Show();
            this.Hide();
        }
    }
}
