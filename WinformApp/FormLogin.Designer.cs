namespace WinformApp
{
    partial class FormLogin
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
            label2 = new Label();
            textBoxusename = new TextBox();
            textBoxPassword = new TextBox();
            buttonDangNhap = new Button();
            buttoncancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 61);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 126);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // textBoxusename
            // 
            textBoxusename.Location = new Point(262, 61);
            textBoxusename.Margin = new Padding(3, 2, 3, 2);
            textBoxusename.Name = "textBoxusename";
            textBoxusename.Size = new Size(182, 23);
            textBoxusename.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(262, 126);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(182, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextChanged += textBox2_TextChanged;
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.Location = new Point(146, 204);
            buttonDangNhap.Margin = new Padding(3, 2, 3, 2);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new Size(108, 32);
            buttonDangNhap.TabIndex = 4;
            buttonDangNhap.Text = "Đăng nhập";
            buttonDangNhap.UseVisualStyleBackColor = true;
            buttonDangNhap.Click += buttonDangNhap_Click;
            // 
            // buttoncancel
            // 
            buttoncancel.Location = new Point(335, 204);
            buttoncancel.Margin = new Padding(3, 2, 3, 2);
            buttoncancel.Name = "buttoncancel";
            buttoncancel.Size = new Size(108, 32);
            buttoncancel.TabIndex = 5;
            buttoncancel.Text = "Thoát";
            buttoncancel.UseVisualStyleBackColor = true;
            buttoncancel.Click += buttoncancel_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 314);
            Controls.Add(buttoncancel);
            Controls.Add(buttonDangNhap);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxusename);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxusename;
        private TextBox textBoxPassword;
        private Button buttonDangNhap;
        private Button buttoncancel;
    }
}