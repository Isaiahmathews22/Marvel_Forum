namespace Marvel_Proj
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgItem = new System.Windows.Forms.Panel();
            this.itemName = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imgItem
            // 
            this.imgItem.BackColor = System.Drawing.Color.White;
            this.imgItem.Location = new System.Drawing.Point(0, 0);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(226, 176);
            this.imgItem.TabIndex = 0;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(3, 191);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(89, 18);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Item Name";
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.Location = new System.Drawing.Point(189, 191);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(26, 18);
            this.itemPrice.TabIndex = 2;
            this.itemPrice.Text = "$0";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.imgItem);
            this.Name = "Items";
            this.Size = new System.Drawing.Size(226, 223);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel imgItem;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label itemPrice;
    }
}
