namespace Omniworlds_Control_Panel
{
    partial class Items
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLvl = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tickActive = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.txtAP = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.NumericUpDown();
            this.txtSPD = new System.Windows.Forms.NumericUpDown();
            this.txtDex = new System.Windows.Forms.NumericUpDown();
            this.txtDEF = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSTR = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLore = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTR)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Items.AddRange(new object[] {
            "001: Potion",
            "002: Hi-Potion",
            "003: Cloth Hat",
            "004: Cloth Tunic",
            "005: Torn Trousers",
            "006: Cloth Shoes"});
            this.lstItems.Location = new System.Drawing.Point(11, 171);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(226, 394);
            this.lstItems.TabIndex = 2;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(254, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 496);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(13, 20);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(724, 56);
            this.txtNotes.TabIndex = 8;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(413, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 350);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLvl);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tickActive);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.txtAP);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtHP);
            this.groupBox3.Controls.Add(this.txtSPD);
            this.groupBox3.Controls.Add(this.txtDex);
            this.groupBox3.Controls.Add(this.txtDEF);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSTR);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(16, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 114);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtLvl
            // 
            this.txtLvl.Location = new System.Drawing.Point(118, 89);
            this.txtLvl.Name = "txtLvl";
            this.txtLvl.Size = new System.Drawing.Size(40, 20);
            this.txtLvl.TabIndex = 29;
            this.txtLvl.ValueChanged += new System.EventHandler(this.txtLvl_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Min Lvl";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tickActive
            // 
            this.tickActive.AutoSize = true;
            this.tickActive.Location = new System.Drawing.Point(179, 89);
            this.tickActive.Name = "tickActive";
            this.tickActive.Size = new System.Drawing.Size(15, 14);
            this.tickActive.TabIndex = 27;
            this.tickActive.UseVisualStyleBackColor = true;
            this.tickActive.CheckedChanged += new System.EventHandler(this.tickActive_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Active";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(69, 89);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(40, 20);
            this.txtQty.TabIndex = 25;
            this.txtQty.ValueChanged += new System.EventHandler(this.txtQty_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Qty";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(14, 89);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(40, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.ValueChanged += new System.EventHandler(this.txtPrice_ValueChanged);
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(276, 41);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(37, 20);
            this.txtAP.TabIndex = 23;
            this.txtAP.ValueChanged += new System.EventHandler(this.txtAP_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(224, 41);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(37, 20);
            this.txtHP.TabIndex = 22;
            this.txtHP.ValueChanged += new System.EventHandler(this.txtHP_ValueChanged);
            // 
            // txtSPD
            // 
            this.txtSPD.Location = new System.Drawing.Point(173, 41);
            this.txtSPD.Name = "txtSPD";
            this.txtSPD.Size = new System.Drawing.Size(37, 20);
            this.txtSPD.TabIndex = 21;
            this.txtSPD.ValueChanged += new System.EventHandler(this.txtSPD_ValueChanged);
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(121, 41);
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(37, 20);
            this.txtDex.TabIndex = 20;
            this.txtDex.ValueChanged += new System.EventHandler(this.txtDex_ValueChanged);
            // 
            // txtDEF
            // 
            this.txtDEF.Location = new System.Drawing.Point(69, 41);
            this.txtDEF.Name = "txtDEF";
            this.txtDEF.Size = new System.Drawing.Size(37, 20);
            this.txtDEF.TabIndex = 19;
            this.txtDEF.ValueChanged += new System.EventHandler(this.txtDEF_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "AP";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "HP";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "SPD";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DEX";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "DEF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSTR
            // 
            this.txtSTR.Location = new System.Drawing.Point(17, 41);
            this.txtSTR.Name = "txtSTR";
            this.txtSTR.Size = new System.Drawing.Size(37, 20);
            this.txtSTR.TabIndex = 13;
            this.txtSTR.ValueChanged += new System.EventHandler(this.txtSTR_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "STR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.txtLore);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblDesc);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(15, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 219);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtLore
            // 
            this.txtLore.Location = new System.Drawing.Point(15, 157);
            this.txtLore.Multiline = true;
            this.txtLore.Name = "txtLore";
            this.txtLore.Size = new System.Drawing.Size(331, 56);
            this.txtLore.TabIndex = 7;
            this.txtLore.TextChanged += new System.EventHandler(this.txtLore_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Lore";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(15, 82);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(331, 56);
            this.txtDesc.TabIndex = 5;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(217, 39);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(130, 21);
            this.cmbType.TabIndex = 4;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 66);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description";
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 567);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(83, 37);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Create Item";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(154, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(84, 625);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 37);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omniworlds_Control_Panel.Properties.Resources.OmniWorldsLogo_Normal;
            this.pictureBox1.Location = new System.Drawing.Point(0, -72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Items";
            this.Text = "Item Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDEF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTR)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.NumericUpDown txtAP;
        private System.Windows.Forms.NumericUpDown txtHP;
        private System.Windows.Forms.NumericUpDown txtSPD;
        private System.Windows.Forms.NumericUpDown txtDex;
        private System.Windows.Forms.NumericUpDown txtDEF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtSTR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox tickActive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown txtLvl;
        private System.Windows.Forms.Label label12;
    }
}