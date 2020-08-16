namespace Omniworlds_Control_Panel
{
    partial class Weapon
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lstWeapon = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSlot = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLstClasses = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.numSell = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numLvl = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numAccuracy = new System.Windows.Forms.NumericUpDown();
            this.numEvasion = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numMagic = new System.Windows.Forms.NumericUpDown();
            this.numMagicDef = new System.Windows.Forms.NumericUpDown();
            this.numDefense = new System.Windows.Forms.NumericUpDown();
            this.numAttack = new System.Windows.Forms.NumericUpDown();
            this.numMagicAtt = new System.Windows.Forms.NumericUpDown();
            this.numVitality = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numDurability = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.lstResources = new System.Windows.Forms.ListBox();
            this.lstCrafting = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEvasion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMagic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMagicDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMagicAtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVitality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 644);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 26);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstWeapon
            // 
            this.lstWeapon.FormattingEnabled = true;
            this.lstWeapon.Location = new System.Drawing.Point(12, 151);
            this.lstWeapon.Name = "lstWeapon";
            this.lstWeapon.Size = new System.Drawing.Size(116, 407);
            this.lstWeapon.TabIndex = 16;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 29);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit Weapon";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 82);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 29);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New Weapon";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(143, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Weapon Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 569);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 29);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Weapon";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 136);
            this.textBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Weapon Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Sword",
            "Dagger",
            "Staff",
            "Bow",
            "Mace",
            "Tomes",
            "Gun",
            "Spear",
            "Knuckles",
            "Throwables"});
            this.cmbType.Location = new System.Drawing.Point(146, 314);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(174, 21);
            this.cmbType.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Weapon Slot";
            // 
            // cmbSlot
            // 
            this.cmbSlot.FormattingEnabled = true;
            this.cmbSlot.Items.AddRange(new object[] {
            "Main",
            "Offhand",
            "Both"});
            this.cmbSlot.Location = new System.Drawing.Point(147, 363);
            this.cmbSlot.Name = "cmbSlot";
            this.cmbSlot.Size = new System.Drawing.Size(174, 21);
            this.cmbSlot.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Usable Classes";
            // 
            // chkLstClasses
            // 
            this.chkLstClasses.FormattingEnabled = true;
            this.chkLstClasses.Items.AddRange(new object[] {
            "None",
            "Squire"});
            this.chkLstClasses.Location = new System.Drawing.Point(333, 102);
            this.chkLstClasses.Name = "chkLstClasses";
            this.chkLstClasses.Size = new System.Drawing.Size(163, 289);
            this.chkLstClasses.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Base Cost";
            // 
            // numCost
            // 
            this.numCost.Location = new System.Drawing.Point(147, 415);
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(174, 20);
            this.numCost.TabIndex = 30;
            // 
            // numSell
            // 
            this.numSell.Location = new System.Drawing.Point(147, 462);
            this.numSell.Name = "numSell";
            this.numSell.Size = new System.Drawing.Size(173, 20);
            this.numSell.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sell Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Required Level";
            // 
            // numLvl
            // 
            this.numLvl.Location = new System.Drawing.Point(334, 415);
            this.numLvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLvl.Name = "numLvl";
            this.numLvl.Size = new System.Drawing.Size(162, 20);
            this.numLvl.TabIndex = 34;
            this.numLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Attack";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Defense";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Magic Defense";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Magic Attack";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 561);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Magic";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 518);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Vitality";
            // 
            // numAccuracy
            // 
            this.numAccuracy.Location = new System.Drawing.Point(420, 578);
            this.numAccuracy.Name = "numAccuracy";
            this.numAccuracy.Size = new System.Drawing.Size(76, 20);
            this.numAccuracy.TabIndex = 51;
            // 
            // numEvasion
            // 
            this.numEvasion.Location = new System.Drawing.Point(420, 535);
            this.numEvasion.Name = "numEvasion";
            this.numEvasion.Size = new System.Drawing.Size(76, 20);
            this.numEvasion.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(418, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Accuracy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(418, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Evasion";
            // 
            // numMagic
            // 
            this.numMagic.Location = new System.Drawing.Point(333, 578);
            this.numMagic.Name = "numMagic";
            this.numMagic.Size = new System.Drawing.Size(76, 20);
            this.numMagic.TabIndex = 52;
            // 
            // numMagicDef
            // 
            this.numMagicDef.Location = new System.Drawing.Point(236, 578);
            this.numMagicDef.Name = "numMagicDef";
            this.numMagicDef.Size = new System.Drawing.Size(76, 20);
            this.numMagicDef.TabIndex = 53;
            // 
            // numDefense
            // 
            this.numDefense.Location = new System.Drawing.Point(145, 578);
            this.numDefense.Name = "numDefense";
            this.numDefense.Size = new System.Drawing.Size(76, 20);
            this.numDefense.TabIndex = 54;
            // 
            // numAttack
            // 
            this.numAttack.Location = new System.Drawing.Point(145, 535);
            this.numAttack.Name = "numAttack";
            this.numAttack.Size = new System.Drawing.Size(76, 20);
            this.numAttack.TabIndex = 57;
            // 
            // numMagicAtt
            // 
            this.numMagicAtt.Location = new System.Drawing.Point(236, 535);
            this.numMagicAtt.Name = "numMagicAtt";
            this.numMagicAtt.Size = new System.Drawing.Size(76, 20);
            this.numMagicAtt.TabIndex = 56;
            // 
            // numVitality
            // 
            this.numVitality.Location = new System.Drawing.Point(333, 535);
            this.numVitality.Name = "numVitality";
            this.numVitality.Size = new System.Drawing.Size(76, 20);
            this.numVitality.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(331, 446);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "Durability";
            // 
            // numDurability
            // 
            this.numDurability.Location = new System.Drawing.Point(334, 462);
            this.numDurability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDurability.Name = "numDurability";
            this.numDurability.Size = new System.Drawing.Size(162, 20);
            this.numDurability.TabIndex = 59;
            this.numDurability.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(526, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "Resource List";
            // 
            // lstResources
            // 
            this.lstResources.FormattingEnabled = true;
            this.lstResources.Location = new System.Drawing.Point(529, 102);
            this.lstResources.Name = "lstResources";
            this.lstResources.Size = new System.Drawing.Size(206, 381);
            this.lstResources.TabIndex = 61;
            // 
            // lstCrafting
            // 
            this.lstCrafting.FormattingEnabled = true;
            this.lstCrafting.Location = new System.Drawing.Point(813, 102);
            this.lstCrafting.Name = "lstCrafting";
            this.lstCrafting.Size = new System.Drawing.Size(206, 381);
            this.lstCrafting.TabIndex = 62;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(810, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 63;
            this.label18.Text = "Crafting List";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(754, 102);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(39, 380);
            this.btnTransfer.TabIndex = 64;
            this.btnTransfer.Text = ">>";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(536, 501);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(136, 30);
            this.btnIncrease.TabIndex = 65;
            this.btnIncrease.Text = "Increase Quantity";
            this.btnIncrease.UseVisualStyleBackColor = true;
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(697, 501);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(136, 30);
            this.btnDecrease.TabIndex = 66;
            this.btnDecrease.Text = "Decrease Quantity";
            this.btnDecrease.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(858, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 30);
            this.button1.TabIndex = 67;
            this.button1.Text = "Remove Resource";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omniworlds_Control_Panel.Properties.Resources.OmniWorldsLogo_Normal;
            this.pictureBox1.Location = new System.Drawing.Point(0, -56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 26);
            this.button2.TabIndex = 94;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Weapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lstCrafting);
            this.Controls.Add(this.lstResources);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numDurability);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numAttack);
            this.Controls.Add(this.numMagicAtt);
            this.Controls.Add(this.numVitality);
            this.Controls.Add(this.numDefense);
            this.Controls.Add(this.numMagicDef);
            this.Controls.Add(this.numMagic);
            this.Controls.Add(this.numAccuracy);
            this.Controls.Add(this.numEvasion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numLvl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numSell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkLstClasses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSlot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstWeapon);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Weapon";
            this.Text = "Weapon";
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEvasion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMagic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMagicDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMagicAtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVitality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstWeapon;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSlot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chkLstClasses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numSell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numLvl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numAccuracy;
        private System.Windows.Forms.NumericUpDown numEvasion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numMagic;
        private System.Windows.Forms.NumericUpDown numMagicDef;
        private System.Windows.Forms.NumericUpDown numDefense;
        private System.Windows.Forms.NumericUpDown numAttack;
        private System.Windows.Forms.NumericUpDown numMagicAtt;
        private System.Windows.Forms.NumericUpDown numVitality;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numDurability;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lstResources;
        private System.Windows.Forms.ListBox lstCrafting;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}