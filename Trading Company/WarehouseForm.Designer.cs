namespace Trading_Company
{
    partial class WarehouseEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseEditForm));
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ManagerBox = new System.Windows.Forms.TextBox();
            this.WHManagerLabel = new System.Windows.Forms.Label();
            this.WHAddressLabel = new System.Windows.Forms.Label();
            this.WHNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(371, 281);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(150, 50);
            this.UpdateBtn.TabIndex = 50;
            this.UpdateBtn.Text = "Update Info.";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.InsertBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.InsertBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InsertBtn.Location = new System.Drawing.Point(98, 281);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(150, 50);
            this.InsertBtn.TabIndex = 49;
            this.InsertBtn.Text = "Add New";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AddressBox.ForeColor = System.Drawing.Color.Purple;
            this.AddressBox.Location = new System.Drawing.Point(265, 114);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(300, 38);
            this.AddressBox.TabIndex = 48;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NameBox.ForeColor = System.Drawing.Color.Purple;
            this.NameBox.Location = new System.Drawing.Point(265, 45);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(300, 38);
            this.NameBox.TabIndex = 47;
            // 
            // ManagerBox
            // 
            this.ManagerBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ManagerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ManagerBox.ForeColor = System.Drawing.Color.Purple;
            this.ManagerBox.Location = new System.Drawing.Point(265, 184);
            this.ManagerBox.Name = "ManagerBox";
            this.ManagerBox.Size = new System.Drawing.Size(300, 38);
            this.ManagerBox.TabIndex = 46;
            // 
            // WHManagerLabel
            // 
            this.WHManagerLabel.AutoSize = true;
            this.WHManagerLabel.BackColor = System.Drawing.Color.Transparent;
            this.WHManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.WHManagerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WHManagerLabel.Location = new System.Drawing.Point(60, 182);
            this.WHManagerLabel.Name = "WHManagerLabel";
            this.WHManagerLabel.Size = new System.Drawing.Size(154, 38);
            this.WHManagerLabel.TabIndex = 45;
            this.WHManagerLabel.Text = "Manager:";
            // 
            // WHAddressLabel
            // 
            this.WHAddressLabel.AutoSize = true;
            this.WHAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.WHAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.WHAddressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WHAddressLabel.Location = new System.Drawing.Point(60, 112);
            this.WHAddressLabel.Name = "WHAddressLabel";
            this.WHAddressLabel.Size = new System.Drawing.Size(136, 38);
            this.WHAddressLabel.TabIndex = 44;
            this.WHAddressLabel.Text = "Addess:";
            // 
            // WHNameLabel
            // 
            this.WHNameLabel.AutoSize = true;
            this.WHNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.WHNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.WHNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WHNameLabel.Location = new System.Drawing.Point(60, 43);
            this.WHNameLabel.Name = "WHNameLabel";
            this.WHNameLabel.Size = new System.Drawing.Size(113, 38);
            this.WHNameLabel.TabIndex = 43;
            this.WHNameLabel.Text = "Name:";
            // 
            // WarehouseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trading_Company.Properties.Resources.Bk;
            this.ClientSize = new System.Drawing.Size(625, 374);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ManagerBox);
            this.Controls.Add(this.WHManagerLabel);
            this.Controls.Add(this.WHAddressLabel);
            this.Controls.Add(this.WHNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarehouseEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Warehouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox ManagerBox;
        private System.Windows.Forms.Label WHManagerLabel;
        private System.Windows.Forms.Label WHAddressLabel;
        private System.Windows.Forms.Label WHNameLabel;
    }
}