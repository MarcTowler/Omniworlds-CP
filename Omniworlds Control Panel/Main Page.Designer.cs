namespace Omniworlds_Control_Panel
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnItem = new System.Windows.Forms.Button();
            this.btnNPC = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(22, 194);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(135, 45);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "Item Manager";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnNPC
            // 
            this.btnNPC.Location = new System.Drawing.Point(248, 194);
            this.btnNPC.Name = "btnNPC";
            this.btnNPC.Size = new System.Drawing.Size(135, 45);
            this.btnNPC.TabIndex = 2;
            this.btnNPC.Text = "NPC Manager";
            this.btnNPC.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(455, 194);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(135, 45);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "User Manager";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(657, 194);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(135, 45);
            this.btnShop.TabIndex = 4;
            this.btnShop.Text = "Shop Manager";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(840, 194);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(135, 45);
            this.btnEvent.TabIndex = 5;
            this.btnEvent.Text = "Event Manager";
            this.btnEvent.UseVisualStyleBackColor = true;
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(465, 318);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(135, 45);
            this.btnLocation.TabIndex = 6;
            this.btnLocation.Text = "Location Manager";
            this.btnLocation.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omniworlds_Control_Panel.Properties.Resources.OmniWorldsLogo_Normal;
            this.pictureBox1.Location = new System.Drawing.Point(0, -72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnNPC);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "Omniworlds RPG Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnNPC;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnLocation;
    }
}

