namespace Omniworlds_Control_Panel
{
    partial class Shop
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNPC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLevel)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.chkActive);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbLocation);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbNPC);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.txtLevel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 219);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // cmbNPC
            // 
            this.cmbNPC.FormattingEnabled = true;
            this.cmbNPC.Location = new System.Drawing.Point(217, 39);
            this.cmbNPC.Name = "cmbNPC";
            this.cmbNPC.Size = new System.Drawing.Size(130, 21);
            this.cmbNPC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shop Owner";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Shop Name";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 568);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(83, 37);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Create Shop";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(84, 626);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 37);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(163, 88);
            this.txtLevel.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(37, 20);
            this.txtLevel.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Min LvL";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(154, 568);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 37);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Shop";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(413, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 350);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(16, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 114);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(13, 20);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(724, 56);
            this.txtNotes.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNotes);
            this.groupBox5.Location = new System.Drawing.Point(17, 390);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(759, 93);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Notes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(254, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 496);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(11, 172);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(226, 394);
            this.lstItems.TabIndex = 8;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omniworlds_Control_Panel.Properties.Resources.OmniWorldsLogo_Normal;
            this.pictureBox1.Location = new System.Drawing.Point(0, -71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLocation.Location = new System.Drawing.Point(15, 87);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(130, 21);
            this.cmbLocation.TabIndex = 6;
            this.cmbLocation.Text = "Vas Aven";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Shop Location";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(169, 155);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 14);
            this.chkActive.TabIndex = 29;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Active";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(217, 88);
            this.txtBalance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(63, 20);
            this.txtBalance.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(214, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Balance";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Shop";
            this.Text = "Shop Manager";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLevel)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbNPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown txtLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown txtBalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label11;
    }
}