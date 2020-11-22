using System;
using System.Windows.Forms;
using System.ServiceProcess;

namespace Omniworlds_Control_Panel
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            ServiceController sc = new ServiceController("ElrakisBot");

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    label2.Text = "Elrakis is Running";

                    break;
                case ServiceControllerStatus.Stopped:
                    label2.Text = "Elrakis is Stopped";

                    break;
                case ServiceControllerStatus.Paused:
                    label2.Text = "Elrakis is Paused";

                    break;
                case ServiceControllerStatus.StopPending:
                    label2.Text = "Elrakis is Stopping";

                    break;
                case ServiceControllerStatus.StartPending:
                    label2.Text = "Elrakis is Starting";

                    break;
            }
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
