namespace PlayerDatabaseModule
{
    partial class frm_PlayerStorage
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
            this.btn_displayItemInfo = new System.Windows.Forms.Button();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_itemList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_displayItemInfo
            // 
            this.btn_displayItemInfo.Location = new System.Drawing.Point(231, 23);
            this.btn_displayItemInfo.Name = "btn_displayItemInfo";
            this.btn_displayItemInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_displayItemInfo.TabIndex = 1;
            this.btn_displayItemInfo.Text = "Display";
            this.btn_displayItemInfo.UseVisualStyleBackColor = true;
            this.btn_displayItemInfo.Click += new System.EventHandler(this.btn_displayItemInfo_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Location = new System.Drawing.Point(231, 107);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(75, 23);
            this.btn_removeItem.TabIndex = 2;
            this.btn_removeItem.Text = "Delete";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(231, 78);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 23);
            this.btn_addItem.TabIndex = 3;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Location = new System.Drawing.Point(24, 26);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(39, 13);
            this.lbl_PlayerName.TabIndex = 5;
            this.lbl_PlayerName.Text = "Player:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lbl_itemList
            // 
            this.lbl_itemList.AutoSize = true;
            this.lbl_itemList.Location = new System.Drawing.Point(24, 78);
            this.lbl_itemList.Name = "lbl_itemList";
            this.lbl_itemList.Size = new System.Drawing.Size(30, 13);
            this.lbl_itemList.TabIndex = 7;
            this.lbl_itemList.Text = "Item:";
            // 
            // frm_PlayerStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 159);
            this.Controls.Add(this.lbl_itemList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_PlayerName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.btn_displayItemInfo);
            this.Name = "frm_PlayerStorage";
            this.Text = "frm_PlayerStorage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_displayItemInfo;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_PlayerName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_itemList;
    }
}