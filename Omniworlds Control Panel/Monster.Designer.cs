namespace Omniworlds_Control_Panel
{
    partial class Monster
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstMonster = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numLvl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numCoins = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numXP = new System.Windows.Forms.NumericUpDown();
            this.numDefense = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.txtRaceName = new System.Windows.Forms.TextBox();
            this.btnRaceAdd = new System.Windows.Forms.Button();
            this.btnRaceDel = new System.Windows.Forms.Button();
            this.chkLstItem = new System.Windows.Forms.CheckedListBox();
            this.chkItem = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chkWeapon = new System.Windows.Forms.CheckBox();
            this.chkLstWeapon = new System.Windows.Forms.CheckedListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkArmour = new System.Windows.Forms.CheckBox();
            this.chkLstArmour = new System.Windows.Forms.CheckedListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkResource = new System.Windows.Forms.CheckBox();
            this.chkLstResource = new System.Windows.Forms.CheckedListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkLstLocation = new System.Windows.Forms.CheckedListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLore = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAttackMsg = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDefenseMsg = new System.Windows.Forms.TextBox();
            this.lblAttackOutput = new System.Windows.Forms.Label();
            this.lblDefenseOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 569);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 29);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete Monster";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 644);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 26);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstMonster
            // 
            this.lstMonster.FormattingEnabled = true;
            this.lstMonster.Items.AddRange(new object[] {
            "Bat",
            "Harpy",
            "Goblin"});
            this.lstMonster.Location = new System.Drawing.Point(12, 151);
            this.lstMonster.Name = "lstMonster";
            this.lstMonster.Size = new System.Drawing.Size(116, 407);
            this.lstMonster.TabIndex = 38;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 29);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit Monster";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 82);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 29);
            this.btnNew.TabIndex = 36;
            this.btnNew.Text = "New Monster";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omniworlds_Control_Panel.Properties.Resources.OmniWorldsLogo_Normal;
            this.pictureBox1.Location = new System.Drawing.Point(0, -56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(150, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 13);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Monster Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Level";
            // 
            // numLvl
            // 
            this.numLvl.Location = new System.Drawing.Point(153, 141);
            this.numLvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLvl.Name = "numLvl";
            this.numLvl.Size = new System.Drawing.Size(109, 20);
            this.numLvl.TabIndex = 45;
            this.numLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Litcoins";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numCoins
            // 
            this.numCoins.Location = new System.Drawing.Point(152, 178);
            this.numCoins.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCoins.Name = "numCoins";
            this.numCoins.Size = new System.Drawing.Size(109, 20);
            this.numCoins.TabIndex = 47;
            this.numCoins.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Attack";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(343, 98);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown1.TabIndex = 49;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Experience";
            // 
            // numXP
            // 
            this.numXP.Location = new System.Drawing.Point(152, 217);
            this.numXP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numXP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numXP.Name = "numXP";
            this.numXP.Size = new System.Drawing.Size(109, 20);
            this.numXP.TabIndex = 51;
            this.numXP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDefense
            // 
            this.numDefense.Location = new System.Drawing.Point(343, 141);
            this.numDefense.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDefense.Name = "numDefense";
            this.numDefense.Size = new System.Drawing.Size(91, 20);
            this.numDefense.TabIndex = 53;
            this.numDefense.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Defense";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(343, 178);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown2.TabIndex = 55;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Magic Attack";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(343, 217);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown3.TabIndex = 57;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Magic Defense";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(343, 256);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown4.TabIndex = 59;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Vitality";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(343, 295);
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown5.TabIndex = 61;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Magic";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(343, 334);
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown6.TabIndex = 63;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Evasion";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(343, 373);
            this.numericUpDown7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown7.TabIndex = 65;
            this.numericUpDown7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Accuracy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(458, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "Monster Race";
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Location = new System.Drawing.Point(461, 98);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(164, 21);
            this.cmbRace.TabIndex = 67;
            // 
            // txtRaceName
            // 
            this.txtRaceName.Location = new System.Drawing.Point(461, 123);
            this.txtRaceName.Name = "txtRaceName";
            this.txtRaceName.Size = new System.Drawing.Size(164, 20);
            this.txtRaceName.TabIndex = 68;
            // 
            // btnRaceAdd
            // 
            this.btnRaceAdd.Location = new System.Drawing.Point(461, 149);
            this.btnRaceAdd.Name = "btnRaceAdd";
            this.btnRaceAdd.Size = new System.Drawing.Size(164, 23);
            this.btnRaceAdd.TabIndex = 69;
            this.btnRaceAdd.Text = "Add Race";
            this.btnRaceAdd.UseVisualStyleBackColor = true;
            // 
            // btnRaceDel
            // 
            this.btnRaceDel.Location = new System.Drawing.Point(461, 178);
            this.btnRaceDel.Name = "btnRaceDel";
            this.btnRaceDel.Size = new System.Drawing.Size(164, 23);
            this.btnRaceDel.TabIndex = 70;
            this.btnRaceDel.Text = "Delete Race";
            this.btnRaceDel.UseVisualStyleBackColor = true;
            // 
            // chkLstItem
            // 
            this.chkLstItem.FormattingEnabled = true;
            this.chkLstItem.Items.AddRange(new object[] {
            "Tiny Potion",
            "Strength Potion"});
            this.chkLstItem.Location = new System.Drawing.Point(152, 451);
            this.chkLstItem.Name = "chkLstItem";
            this.chkLstItem.Size = new System.Drawing.Size(176, 184);
            this.chkLstItem.TabIndex = 71;
            // 
            // chkItem
            // 
            this.chkItem.AutoSize = true;
            this.chkItem.Location = new System.Drawing.Point(152, 430);
            this.chkItem.Name = "chkItem";
            this.chkItem.Size = new System.Drawing.Size(112, 17);
            this.chkItem.TabIndex = 72;
            this.chkItem.Text = "Item as Rare Drop";
            this.chkItem.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(152, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 73;
            this.label13.Text = "Item List";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(344, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Weapon List";
            // 
            // chkWeapon
            // 
            this.chkWeapon.AutoSize = true;
            this.chkWeapon.Location = new System.Drawing.Point(344, 430);
            this.chkWeapon.Name = "chkWeapon";
            this.chkWeapon.Size = new System.Drawing.Size(133, 17);
            this.chkWeapon.TabIndex = 75;
            this.chkWeapon.Text = "Weapon as Rare Drop";
            this.chkWeapon.UseVisualStyleBackColor = true;
            // 
            // chkLstWeapon
            // 
            this.chkLstWeapon.FormattingEnabled = true;
            this.chkLstWeapon.Items.AddRange(new object[] {
            "Boxing Gloves",
            "Wooden Sword"});
            this.chkLstWeapon.Location = new System.Drawing.Point(344, 451);
            this.chkLstWeapon.Name = "chkLstWeapon";
            this.chkLstWeapon.Size = new System.Drawing.Size(176, 184);
            this.chkLstWeapon.TabIndex = 74;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(537, 414);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "Armour List";
            // 
            // chkArmour
            // 
            this.chkArmour.AutoSize = true;
            this.chkArmour.Location = new System.Drawing.Point(537, 430);
            this.chkArmour.Name = "chkArmour";
            this.chkArmour.Size = new System.Drawing.Size(125, 17);
            this.chkArmour.TabIndex = 78;
            this.chkArmour.Text = "Armour as Rare Drop";
            this.chkArmour.UseVisualStyleBackColor = true;
            // 
            // chkLstArmour
            // 
            this.chkLstArmour.FormattingEnabled = true;
            this.chkLstArmour.Items.AddRange(new object[] {
            "Torn Trousers",
            "Flat Cap"});
            this.chkLstArmour.Location = new System.Drawing.Point(537, 451);
            this.chkLstArmour.Name = "chkLstArmour";
            this.chkLstArmour.Size = new System.Drawing.Size(176, 184);
            this.chkLstArmour.TabIndex = 77;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(729, 414);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "Resource List";
            // 
            // chkResource
            // 
            this.chkResource.AutoSize = true;
            this.chkResource.Location = new System.Drawing.Point(729, 430);
            this.chkResource.Name = "chkResource";
            this.chkResource.Size = new System.Drawing.Size(138, 17);
            this.chkResource.TabIndex = 81;
            this.chkResource.Text = "Resource as Rare Drop";
            this.chkResource.UseVisualStyleBackColor = true;
            // 
            // chkLstResource
            // 
            this.chkLstResource.FormattingEnabled = true;
            this.chkLstResource.Items.AddRange(new object[] {
            "Iron Ore",
            "Wool",
            "Bones"});
            this.chkLstResource.Location = new System.Drawing.Point(729, 451);
            this.chkLstResource.Name = "chkLstResource";
            this.chkLstResource.Size = new System.Drawing.Size(176, 184);
            this.chkLstResource.TabIndex = 80;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(458, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 83;
            this.label17.Text = "Locations";
            // 
            // chkLstLocation
            // 
            this.chkLstLocation.FormattingEnabled = true;
            this.chkLstLocation.Items.AddRange(new object[] {
            "Vas Aven Sewers",
            "Vas Aven Fields"});
            this.chkLstLocation.Location = new System.Drawing.Point(461, 220);
            this.chkLstLocation.Name = "chkLstLocation";
            this.chkLstLocation.Size = new System.Drawing.Size(164, 184);
            this.chkLstLocation.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(649, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 85;
            this.label18.Text = "Monster Lore";
            // 
            // txtLore
            // 
            this.txtLore.Location = new System.Drawing.Point(653, 102);
            this.txtLore.Multiline = true;
            this.txtLore.Name = "txtLore";
            this.txtLore.Size = new System.Drawing.Size(308, 138);
            this.txtLore.TabIndex = 86;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(650, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 87;
            this.label19.Text = "Attack Message";
            // 
            // txtAttackMsg
            // 
            this.txtAttackMsg.Location = new System.Drawing.Point(652, 269);
            this.txtAttackMsg.Name = "txtAttackMsg";
            this.txtAttackMsg.Size = new System.Drawing.Size(309, 20);
            this.txtAttackMsg.TabIndex = 88;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(650, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 89;
            this.label20.Text = "Defense Message";
            // 
            // txtDefenseMsg
            // 
            this.txtDefenseMsg.Location = new System.Drawing.Point(652, 344);
            this.txtDefenseMsg.Name = "txtDefenseMsg";
            this.txtDefenseMsg.Size = new System.Drawing.Size(309, 20);
            this.txtDefenseMsg.TabIndex = 90;
            // 
            // lblAttackOutput
            // 
            this.lblAttackOutput.AutoSize = true;
            this.lblAttackOutput.Location = new System.Drawing.Point(650, 302);
            this.lblAttackOutput.Name = "lblAttackOutput";
            this.lblAttackOutput.Size = new System.Drawing.Size(158, 13);
            this.lblAttackOutput.TabIndex = 91;
            this.lblAttackOutput.Text = "{Monster} {attack_msg} {player}";
            // 
            // lblDefenseOutput
            // 
            this.lblDefenseOutput.AutoSize = true;
            this.lblDefenseOutput.Location = new System.Drawing.Point(650, 375);
            this.lblDefenseOutput.Name = "lblDefenseOutput";
            this.lblDefenseOutput.Size = new System.Drawing.Size(166, 13);
            this.lblDefenseOutput.TabIndex = 92;
            this.lblDefenseOutput.Text = "{Monster} {defense_msg} {player}";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 26);
            this.button1.TabIndex = 93;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Monster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDefenseOutput);
            this.Controls.Add(this.lblAttackOutput);
            this.Controls.Add(this.txtDefenseMsg);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtAttackMsg);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtLore);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.chkLstLocation);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chkResource);
            this.Controls.Add(this.chkLstResource);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chkArmour);
            this.Controls.Add(this.chkLstArmour);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chkWeapon);
            this.Controls.Add(this.chkLstWeapon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkItem);
            this.Controls.Add(this.chkLstItem);
            this.Controls.Add(this.btnRaceDel);
            this.Controls.Add(this.btnRaceAdd);
            this.Controls.Add(this.txtRaceName);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numDefense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numXP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCoins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numLvl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstMonster);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Monster";
            this.Text = "Monster";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstMonster;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCoins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numXP;
        private System.Windows.Forms.NumericUpDown numDefense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.TextBox txtRaceName;
        private System.Windows.Forms.Button btnRaceAdd;
        private System.Windows.Forms.Button btnRaceDel;
        private System.Windows.Forms.CheckedListBox chkLstItem;
        private System.Windows.Forms.CheckBox chkItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkWeapon;
        private System.Windows.Forms.CheckedListBox chkLstWeapon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkArmour;
        private System.Windows.Forms.CheckedListBox chkLstArmour;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkResource;
        private System.Windows.Forms.CheckedListBox chkLstResource;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckedListBox chkLstLocation;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtLore;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAttackMsg;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDefenseMsg;
        private System.Windows.Forms.Label lblAttackOutput;
        private System.Windows.Forms.Label lblDefenseOutput;
        private System.Windows.Forms.Button button1;
    }
}