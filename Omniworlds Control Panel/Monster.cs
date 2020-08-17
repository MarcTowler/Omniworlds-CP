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
    public partial class Monster : Form
    {
        public Monster()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var menu = new MainMenu();

            menu.Show();
            this.Close();
        }


        private void txtAttackMsg_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            lblAttackOutput.Text = txtName.Text + " " + tb.Text + " PLAYER";
        }

        private void txtDefenseMsg_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            lblAttackOutput.Text = txtName.Text + " " + tb.Text + " PLAYER";
        }
    }
}
