namespace Order_List
{
    partial class Form1
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
            btnBack3 = new Button();
            SuspendLayout();
            // 
            // btnBack3
            // 
            btnBack3.BackColor = Color.Red;
            btnBack3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack3.Location = new Point(27, 487);
            btnBack3.Name = "btnBack3";
            btnBack3.Size = new Size(82, 34);
            btnBack3.TabIndex = 0;
            btnBack3.Text = "Back";
            btnBack3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 533);
            Controls.Add(btnBack3);
            Name = "Form1";
            Text = "Order List";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack3;
    }
}
