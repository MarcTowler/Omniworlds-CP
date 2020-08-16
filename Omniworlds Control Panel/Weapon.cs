using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omniworlds_Control_Panel
{
    public partial class Weapon : Form
    {
        public Weapon()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var menu = new MainMenu();

            menu.Show();
            this.Close();
        }
    }
}
