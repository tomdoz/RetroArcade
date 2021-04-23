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
    public partial class Register : Form
    {
        GameSelection gameSelection = new GameSelection();

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameSelection.Show();
            this.Close();
        }
    }
}
