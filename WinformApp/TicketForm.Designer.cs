namespace WinformApp
{
    partial class TicketForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxGiaVe = new TextBox();
            textBoxID = new TextBox();
            textBoxDesc = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxTheLoaiVe = new ComboBox();
            textBoxSoLuongVe = new TextBox();
            label5 = new Label();
            label6 = new Label();
            buttonThem = new Button();
            buttonThoat = new Button();
            textBoxTenTranDau = new TextBox();
            label7 = new Label();
            labelChecksoluong = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 118);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên trận đấu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 192);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Giá vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 57);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 230);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Mô tả";
            // 
            // textBoxGiaVe
            // 
            textBoxGiaVe.Location = new Point(231, 192);
            textBoxGiaVe.Margin = new Padding(3, 2, 3, 2);
            textBoxGiaVe.Name = "textBoxGiaVe";
            textBoxGiaVe.Size = new Size(173, 23);
            textBoxGiaVe.TabIndex = 5;
            textBoxGiaVe.TextChanged += textBoxGiaVe_TextChanged;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(231, 55);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(173, 23);
            textBoxID.TabIndex = 6;
            textBoxID.TextChanged += textBoxID_TextChanged;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(570, 227);
            textBoxDesc.Margin = new Padding(3, 2, 3, 2);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(175, 23);
            textBoxDesc.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(570, 60);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // comboBoxTheLoaiVe
            // 
            comboBoxTheLoaiVe.FormattingEnabled = true;
            comboBoxTheLoaiVe.Location = new Point(567, 151);
            comboBoxTheLoaiVe.Margin = new Padding(3, 2, 3, 2);
            comboBoxTheLoaiVe.Name = "comboBoxTheLoaiVe";
            comboBoxTheLoaiVe.Size = new Size(178, 23);
            comboBoxTheLoaiVe.TabIndex = 9;
            // 
            // textBoxSoLuongVe
            // 
            textBoxSoLuongVe.Location = new Point(231, 256);
            textBoxSoLuongVe.Margin = new Padding(3, 2, 3, 2);
            textBoxSoLuongVe.Name = "textBoxSoLuongVe";
            textBoxSoLuongVe.Size = new Size(173, 23);
            textBoxSoLuongVe.TabIndex = 10;
            textBoxSoLuongVe.TextChanged += textBoxSoLuongVe_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 258);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 11;
            label5.Text = "Số lượng vé";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 153);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 12;
            label6.Text = "Thể loại vé";
            // 
            // buttonThem
            // 
            buttonThem.BackColor = SystemColors.InactiveCaption;
            buttonThem.Location = new Point(277, 332);
            buttonThem.Margin = new Padding(3, 2, 3, 2);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(116, 38);
            buttonThem.TabIndex = 13;
            buttonThem.Text = "Lưu";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = SystemColors.InactiveCaption;
            buttonThoat.Location = new Point(465, 332);
            buttonThoat.Margin = new Padding(3, 2, 3, 2);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(116, 38);
            buttonThoat.TabIndex = 14;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // textBoxTenTranDau
            // 
            textBoxTenTranDau.Location = new Point(231, 112);
            textBoxTenTranDau.Margin = new Padding(3, 2, 3, 2);
            textBoxTenTranDau.Name = "textBoxTenTranDau";
            textBoxTenTranDau.Size = new Size(173, 23);
            textBoxTenTranDau.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 60);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 16;
            label7.Text = "Ngày đấu";
            // 
            // labelChecksoluong
            // 
            labelChecksoluong.AutoSize = true;
            labelChecksoluong.Location = new Point(99, 291);
            labelChecksoluong.Name = "labelChecksoluong";
            labelChecksoluong.Size = new Size(38, 15);
            labelChecksoluong.TabIndex = 17;
            labelChecksoluong.Text = "label8";
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 395);
            Controls.Add(labelChecksoluong);
            Controls.Add(label7);
            Controls.Add(textBoxTenTranDau);
            Controls.Add(buttonThoat);
            Controls.Add(buttonThem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxSoLuongVe);
            Controls.Add(comboBoxTheLoaiVe);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxID);
            Controls.Add(textBoxGiaVe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TicketForm";
            Text = "TicketForm";
            Load += TicketForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxGiaVe;
        private TextBox textBoxID;
        private TextBox textBoxDesc;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxTheLoaiVe;
        private TextBox textBoxSoLuongVe;
        private Label label5;
        private Label label6;
        private Button buttonThem;
        private Button buttonThoat;
        private TextBox textBoxTenTranDau;
        private Label label7;
        private Label labelChecksoluong;
    }
}