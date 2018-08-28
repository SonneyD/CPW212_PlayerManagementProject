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
            this.txt_PlayerField = new System.Windows.Forms.TextBox();
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            this.cbox_ItemList = new System.Windows.Forms.ComboBox();
            this.lbl_itemList = new System.Windows.Forms.Label();
            this.lbox_pInventory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreateItem = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_displayItemInfo
            // 
            this.btn_displayItemInfo.Location = new System.Drawing.Point(328, 57);
            this.btn_displayItemInfo.Name = "btn_displayItemInfo";
            this.btn_displayItemInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_displayItemInfo.TabIndex = 1;
            this.btn_displayItemInfo.Text = "Display";
            this.btn_displayItemInfo.UseVisualStyleBackColor = true;
            this.btn_displayItemInfo.Click += new System.EventHandler(this.btn_displayItemInfo_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Location = new System.Drawing.Point(328, 169);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(75, 23);
            this.btn_removeItem.TabIndex = 3;
            this.btn_removeItem.Text = "Delete";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(328, 110);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 23);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // txt_PlayerField
            // 
            this.txt_PlayerField.Location = new System.Drawing.Point(82, 23);
            this.txt_PlayerField.Name = "txt_PlayerField";
            this.txt_PlayerField.ReadOnly = true;
            this.txt_PlayerField.Size = new System.Drawing.Size(120, 20);
            this.txt_PlayerField.TabIndex = 10;
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
            // cbox_ItemList
            // 
            this.cbox_ItemList.FormattingEnabled = true;
            this.cbox_ItemList.ItemHeight = 13;
            this.cbox_ItemList.Location = new System.Drawing.Point(82, 59);
            this.cbox_ItemList.Name = "cbox_ItemList";
            this.cbox_ItemList.Size = new System.Drawing.Size(226, 21);
            this.cbox_ItemList.TabIndex = 6;
            this.cbox_ItemList.SelectedIndexChanged += new System.EventHandler(this.cbox_ItemList_SelectedIndexChanged);
            // 
            // lbl_itemList
            // 
            this.lbl_itemList.AutoSize = true;
            this.lbl_itemList.Location = new System.Drawing.Point(24, 67);
            this.lbl_itemList.Name = "lbl_itemList";
            this.lbl_itemList.Size = new System.Drawing.Size(30, 13);
            this.lbl_itemList.TabIndex = 7;
            this.lbl_itemList.Text = "Item:";
            // 
            // lbox_pInventory
            // 
            this.lbox_pInventory.FormattingEnabled = true;
            this.lbox_pInventory.Location = new System.Drawing.Point(84, 110);
            this.lbox_pInventory.Name = "lbox_pInventory";
            this.lbox_pInventory.Size = new System.Drawing.Size(224, 82);
            this.lbox_pInventory.TabIndex = 8;
            this.lbox_pInventory.SelectedIndexChanged += new System.EventHandler(this.lbox_pInventory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inventory:";
            // 
            // btn_CreateItem
            // 
            this.btn_CreateItem.Location = new System.Drawing.Point(27, 217);
            this.btn_CreateItem.Name = "btn_CreateItem";
            this.btn_CreateItem.Size = new System.Drawing.Size(99, 33);
            this.btn_CreateItem.TabIndex = 4;
            this.btn_CreateItem.Text = "Create New Item";
            this.btn_CreateItem.UseVisualStyleBackColor = true;
            this.btn_CreateItem.Click += new System.EventHandler(this.btn_CreateItem_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(209, 217);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(99, 34);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_PlayerStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 275);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_CreateItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbox_pInventory);
            this.Controls.Add(this.lbl_itemList);
            this.Controls.Add(this.cbox_ItemList);
            this.Controls.Add(this.lbl_PlayerName);
            this.Controls.Add(this.txt_PlayerField);
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
        private System.Windows.Forms.TextBox txt_PlayerField;
        private System.Windows.Forms.Label lbl_PlayerName;
        private System.Windows.Forms.ComboBox cbox_ItemList;
        private System.Windows.Forms.Label lbl_itemList;
        private System.Windows.Forms.ListBox lbox_pInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreateItem;
        private System.Windows.Forms.Button btn_Logout;
    }
}