﻿namespace menulist
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
            btnback2 = new Button();
            numorder = new NumericUpDown();
            btnPlaceOrder = new Button();
            btnVerify = new Button();
            ((System.ComponentModel.ISupportInitialize)numorder).BeginInit();
            SuspendLayout();
            // 
            // btnback2
            // 
            btnback2.BackColor = Color.Red;
            btnback2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback2.Location = new Point(22, 476);
            btnback2.Name = "btnback2";
            btnback2.Size = new Size(84, 42);
            btnback2.TabIndex = 0;
            btnback2.Text = "Back";
            btnback2.UseVisualStyleBackColor = false;
            // 
            // numorder
            // 
            numorder.Location = new Point(368, 423);
            numorder.Name = "numorder";
            numorder.Size = new Size(132, 23);
            numorder.TabIndex = 1;
            numorder.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.Lime;
            btnPlaceOrder.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaceOrder.Location = new Point(757, 476);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(117, 42);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.Yellow;
            btnVerify.Location = new Point(368, 476);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(120, 42);
            btnVerify.TabIndex = 3;
            btnVerify.Text = "Verify Order";
            btnVerify.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 548);
            Controls.Add(btnVerify);
            Controls.Add(btnPlaceOrder);
            Controls.Add(numorder);
            Controls.Add(btnback2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numorder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnback2;
        private NumericUpDown numorder;
        private Button btnPlaceOrder;
        private Button btnVerify;
    }
}
