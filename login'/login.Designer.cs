namespace login_
{
    partial class frmlogin
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
            button1 = new Button();
            lblEmail = new Label();
            txtBEmail = new TextBox();
            txtBPassword = new TextBox();
            lblPassword = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(110, 227);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 0;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(37, 111);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // txtBEmail
            // 
            txtBEmail.Location = new Point(110, 113);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Size = new Size(164, 23);
            txtBEmail.TabIndex = 2;
            // 
            // txtBPassword
            // 
            txtBPassword.Location = new Point(110, 152);
            txtBPassword.Name = "txtBPassword";
            txtBPassword.Size = new Size(161, 23);
            txtBPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(28, 154);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // button2
            // 
            button2.Location = new Point(110, 279);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 6;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 450);
            Controls.Add(button2);
            Controls.Add(lblPassword);
            Controls.Add(txtBPassword);
            Controls.Add(txtBEmail);
            Controls.Add(lblEmail);
            Controls.Add(button1);
            Name = "frmlogin";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblEmail;
        private TextBox txtBEmail;
        private TextBox txtBPassword;
        private Label lblPassword;
        private Button button2;
    }
}
