namespace Omniworlds_Control_Panel
{
    partial class Resource
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lstResource = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 53);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Resource";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 88);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Resource";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lstResource
            // 
            this.lstResource.FormattingEnabled = true;
            this.lstResource.Location = new System.Drawing.Point(13, 135);
            this.lstResource.Name = "lstResource";
            this.lstResource.Size = new System.Drawing.Size(116, 329);
            this.lstResource.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 615);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 26);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(173, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Resource Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Resource Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Clay",
            "Cloth",
            "Gem",
            "Metals",
            "Food",
            "Hide",
            "Key Items",
            "Animal",
            "Unidentified"});
            this.cmbType.Location = new System.Drawing.Point(175, 136);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(175, 21);
            this.cmbType.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 26);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 44);
            this.label2.TabIndex = 19;
            this.label2.Text = "Resource Manager";
            // 
            // Resource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstResource);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Name = "Resource";
            this.Text = "Resource Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox lstResource;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
    }
}