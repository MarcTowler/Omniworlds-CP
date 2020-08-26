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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            //var itemManager = new Items();

            //itemManager.Show();
            this.Hide();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            var shopManager = new Shop();

            shopManager.Show();
            this.Hide();
        }

        private void btnResource_Click(object sender, EventArgs e)
        {
            var resourceManager = new Resource();

            resourceManager.Show();
            this.Hide();
        }

        private void btnWeapons_Click(object sender, EventArgs e)
        {
            var weaponManager = new Weapon();

            weaponManager.Show();
            this.Hide();
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            var monsterManager = new Monster();

            monsterManager.Show();
            this.Hide();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            var eventManager = new Event();

            eventManager.Show();
            this.Hide();
        }

        private void btnArmour_Click(object sender, EventArgs e)
        {
            var armourManager = new Armour();

            armourManager.Show();
            this.Hide();
        }
    }
}
