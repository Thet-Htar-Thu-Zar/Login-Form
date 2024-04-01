namespace Login_Form1
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
            label1 = new Label();
            btnlogin = new Button();
            txtemail = new TextBox();
            lblemail = new Label();
            label3 = new Label();
            txtpw = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(313, 28);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.IndianRed;
            btnlogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.Black;
            btnlogin.Location = new Point(483, 262);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 48);
            btnlogin.TabIndex = 1;
            btnlogin.Text = "Sign In";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(354, 112);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(223, 27);
            txtemail.TabIndex = 2;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblemail.Location = new Point(268, 112);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(61, 25);
            lblemail.TabIndex = 3;
            lblemail.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(246, 197);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtpw
            // 
            txtpw.Location = new Point(354, 195);
            txtpw.Name = "txtpw";
            txtpw.Size = new Size(223, 27);
            txtpw.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtpw);
            Controls.Add(label3);
            Controls.Add(lblemail);
            Controls.Add(txtemail);
            Controls.Add(btnlogin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnlogin;
        private TextBox txtemail;
        private Label lblemail;
        private Label label3;
        private TextBox txtpw;
    }
}
