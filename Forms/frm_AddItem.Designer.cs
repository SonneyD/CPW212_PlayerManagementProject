namespace PlayerDatabaseModule
{
    partial class frm_AddItem
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
            this.btn_CreateItem = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.txt_ItemDesc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_CreateItem
            // 
            this.btn_CreateItem.Location = new System.Drawing.Point(28, 155);
            this.btn_CreateItem.Name = "btn_CreateItem";
            this.btn_CreateItem.Size = new System.Drawing.Size(90, 32);
            this.btn_CreateItem.TabIndex = 0;
            this.btn_CreateItem.Text = "Create Item";
            this.btn_CreateItem.UseVisualStyleBackColor = true;
            this.btn_CreateItem.Click += new System.EventHandler(this.btn_CreateItem_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(209, 155);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(88, 32);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Description";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Location = new System.Drawing.Point(123, 21);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(174, 20);
            this.txt_ItemName.TabIndex = 4;
            // 
            // txt_ItemDesc
            // 
            this.txt_ItemDesc.Location = new System.Drawing.Point(123, 60);
            this.txt_ItemDesc.Name = "txt_ItemDesc";
            this.txt_ItemDesc.Size = new System.Drawing.Size(174, 70);
            this.txt_ItemDesc.TabIndex = 5;
            this.txt_ItemDesc.Text = "";
            // 
            // frm_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 203);
            this.Controls.Add(this.txt_ItemDesc);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_CreateItem);
            this.Name = "frm_AddItem";
            this.Text = "Create Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateItem;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.RichTextBox txt_ItemDesc;
    }
}