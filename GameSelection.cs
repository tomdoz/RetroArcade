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
    public partial class GameSelection : Form
    {

        Pong pong = new Pong();
        public GameSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pong.Show();
            this.Close();
        }
    }
}
