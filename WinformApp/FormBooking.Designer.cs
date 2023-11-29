namespace WinformApp
{
    partial class FormBooking
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
            label1 = new Label();
            labelTenTranDau = new Label();
            labelLoaiVe = new Label();
            textBoxSoLuong = new TextBox();
            button1 = new Button();
            button2 = new Button();
            labelTime = new Label();
            labelTongTien = new Label();
            labelPrice = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 247);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // labelTenTranDau
            // 
            labelTenTranDau.AutoSize = true;
            labelTenTranDau.Location = new Point(126, 77);
            labelTenTranDau.Name = "labelTenTranDau";
            labelTenTranDau.Size = new Size(74, 15);
            labelTenTranDau.TabIndex = 3;
            labelTenTranDau.Text = "Tên Trận Đấu";
            // 
            // labelLoaiVe
            // 
            labelLoaiVe.AutoSize = true;
            labelLoaiVe.Location = new Point(126, 170);
            labelLoaiVe.Name = "labelLoaiVe";
            labelLoaiVe.Size = new Size(44, 15);
            labelLoaiVe.TabIndex = 4;
            labelLoaiVe.Text = "Loại Vé";
            
            // 
            // textBoxSoLuong
            // 
            textBoxSoLuong.Location = new Point(126, 247);
            textBoxSoLuong.Margin = new Padding(3, 2, 3, 2);
            textBoxSoLuong.Name = "textBoxSoLuong";
            textBoxSoLuong.Size = new Size(148, 23);
            textBoxSoLuong.TabIndex = 5;
            textBoxSoLuong.TextChanged += textBoxSoLuong_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(68, 360);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 6;
            button1.Text = "Mua";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(221, 360);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 7;
            button2.Text = "Huy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(126, 128);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(56, 15);
            labelTime.TabIndex = 8;
            labelTime.Text = "Thời gian";
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.Location = new Point(126, 301);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(38, 15);
            labelTongTien.TabIndex = 9;
            labelTongTien.Text = "label2";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(126, 206);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(38, 15);
            labelPrice.TabIndex = 10;
            labelPrice.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 77);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 11;
            label2.Text = "Tên trận đấu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 128);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "Thời gian:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 170);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 13;
            label4.Text = "Loại vé:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 206);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 14;
            label5.Text = "Giá vé:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 247);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 15;
            label6.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 301);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 16;
            label7.Text = "Tổng tiền:";
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 415);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelPrice);
            Controls.Add(labelTongTien);
            Controls.Add(labelTime);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxSoLuong);
            Controls.Add(labelLoaiVe);
            Controls.Add(labelTenTranDau);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBooking";
            Text = "FormBooking";
            Load += FormBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelTenTranDau;
        private Label labelLoaiVe;
        private TextBox textBoxSoLuong;
        private Button button1;
        private Button button2;
        private Label labelTime;
        private Label labelTongTien;
        private Label labelPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}