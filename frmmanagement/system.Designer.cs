namespace frmmanagement
{
    partial class frmfoodmanagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMenu = new Button();
            btnCost = new Button();
            btnOrder = new Button();
            btnInventory = new Button();
            btnBack = new Button();
            header = new Label();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(128, 137);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(136, 63);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu List";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnCost
            // 
            btnCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCost.Location = new Point(480, 137);
            btnCost.Name = "btnCost";
            btnCost.Size = new Size(136, 63);
            btnCost.TabIndex = 1;
            btnCost.Text = "Cost Control";
            btnCost.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(128, 303);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(136, 63);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order List";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.Location = new Point(480, 303);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(136, 63);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(706, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 28);
            btnBack.TabIndex = 4;
            btnBack.Text = "Log Out";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.Location = new Point(231, 20);
            header.Name = "header";
            header.Size = new Size(306, 45);
            header.TabIndex = 5;
            header.Text = "Food Management ";
            // 
            // frmfoodmanagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(header);
            Controls.Add(btnBack);
            Controls.Add(btnInventory);
            Controls.Add(btnOrder);
            Controls.Add(btnCost);
            Controls.Add(btnMenu);
            Name = "frmfoodmanagement";
            Text = "Food Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Button btnCost;
        private Button btnOrder;
        private Button btnInventory;
        private Button btnBack;
        private Label header;
    }
}
