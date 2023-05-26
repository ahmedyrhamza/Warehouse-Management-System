namespace Trading_Company
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UnitBox = new System.Windows.Forms.TextBox();
            this.WHManagerLabel = new System.Windows.Forms.Label();
            this.WHAddressLabel = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WHBox = new System.Windows.Forms.ComboBox();
            this.DeptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(356, 330);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(150, 50);
            this.UpdateBtn.TabIndex = 58;
            this.UpdateBtn.Text = "Update Info.";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.InsertBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.InsertBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InsertBtn.Location = new System.Drawing.Point(83, 330);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(150, 50);
            this.InsertBtn.TabIndex = 57;
            this.InsertBtn.Text = "Add New";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NameBox.ForeColor = System.Drawing.Color.Purple;
            this.NameBox.Location = new System.Drawing.Point(243, 41);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(300, 38);
            this.NameBox.TabIndex = 56;
            // 
            // UnitBox
            // 
            this.UnitBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UnitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.UnitBox.ForeColor = System.Drawing.Color.Purple;
            this.UnitBox.Location = new System.Drawing.Point(243, 247);
            this.UnitBox.Name = "UnitBox";
            this.UnitBox.Size = new System.Drawing.Size(300, 38);
            this.UnitBox.TabIndex = 54;
            // 
            // WHManagerLabel
            // 
            this.WHManagerLabel.AutoSize = true;
            this.WHManagerLabel.BackColor = System.Drawing.Color.Transparent;
            this.WHManagerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.WHManagerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WHManagerLabel.Location = new System.Drawing.Point(38, 109);
            this.WHManagerLabel.Name = "WHManagerLabel";
            this.WHManagerLabel.Size = new System.Drawing.Size(210, 38);
            this.WHManagerLabel.TabIndex = 53;
            this.WHManagerLabel.Text = "Warehouse:";
            // 
            // WHAddressLabel
            // 
            this.WHAddressLabel.AutoSize = true;
            this.WHAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.WHAddressLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.WHAddressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WHAddressLabel.Location = new System.Drawing.Point(38, 39);
            this.WHAddressLabel.Name = "WHAddressLabel";
            this.WHAddressLabel.Size = new System.Drawing.Size(121, 38);
            this.WHAddressLabel.TabIndex = 52;
            this.WHAddressLabel.Text = "Name:";
            // 
            // AmountBox
            // 
            this.AmountBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AmountBox.ForeColor = System.Drawing.Color.Purple;
            this.AmountBox.Location = new System.Drawing.Point(243, 179);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(300, 38);
            this.AmountBox.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 59;
            this.label1.Text = "Amount:";
            // 
            // WHBox
            // 
            this.WHBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WHBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WHBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WHBox.ForeColor = System.Drawing.Color.Purple;
            this.WHBox.FormattingEnabled = true;
            this.WHBox.Location = new System.Drawing.Point(243, 117);
            this.WHBox.Name = "WHBox";
            this.WHBox.Size = new System.Drawing.Size(300, 33);
            this.WHBox.TabIndex = 62;
            // 
            // DeptLabel
            // 
            this.DeptLabel.AutoSize = true;
            this.DeptLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeptLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.DeptLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeptLabel.Location = new System.Drawing.Point(40, 245);
            this.DeptLabel.Name = "DeptLabel";
            this.DeptLabel.Size = new System.Drawing.Size(93, 38);
            this.DeptLabel.TabIndex = 61;
            this.DeptLabel.Text = "Unit:";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trading_Company.Properties.Resources.Bk;
            this.ClientSize = new System.Drawing.Size(623, 423);
            this.Controls.Add(this.WHBox);
            this.Controls.Add(this.DeptLabel);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.UnitBox);
            this.Controls.Add(this.WHManagerLabel);
            this.Controls.Add(this.WHAddressLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox UnitBox;
        private System.Windows.Forms.Label WHManagerLabel;
        private System.Windows.Forms.Label WHAddressLabel;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WHBox;
        private System.Windows.Forms.Label DeptLabel;
    }
}