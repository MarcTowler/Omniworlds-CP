﻿using System;
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
            var itemManager = new Items();

            itemManager.Show();
            this.Hide();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            var shopManager = new Shop();

            shopManager.Show();
            this.Hide();
        }
    }
}
