using System;
using System.Windows.Forms;

namespace Omniworlds_Control_Panel
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var menu = new MainMenu();

            menu.Show();
            this.Close();
        }
    }
}
