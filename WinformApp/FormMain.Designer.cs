namespace WinformApp
{
    partial class FormMain
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
            dataGridView1 = new DataGridView();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonLoad = new Button();
            buttonXoa = new Button();
            label1 = new Label();
            textBoxSearch = new TextBox();
            button1 = new Button();
            button2 = new Button();
            buttonDangXuat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 132);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(834, 332);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = SystemColors.InactiveCaption;
            buttonThem.Location = new Point(858, 283);
            buttonThem.Margin = new Padding(3, 2, 3, 2);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 38);
            buttonThem.TabIndex = 1;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = SystemColors.InactiveCaption;
            buttonSua.Location = new Point(858, 226);
            buttonSua.Margin = new Padding(3, 2, 3, 2);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 38);
            buttonSua.TabIndex = 2;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.InactiveCaption;
            buttonLoad.Location = new Point(858, 404);
            buttonLoad.Margin = new Padding(3, 2, 3, 2);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(94, 38);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = SystemColors.InactiveCaption;
            buttonXoa.Location = new Point(858, 346);
            buttonXoa.Margin = new Padding(3, 2, 3, 2);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 38);
            buttonXoa.TabIndex = 4;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 65);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Tìm Kiếm";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(91, 65);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(231, 23);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(378, 65);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 7;
            button1.Text = "Xuất ra Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(869, 51);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 8;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonDangXuat
            // 
            buttonDangXuat.Location = new Point(869, 85);
            buttonDangXuat.Margin = new Padding(3, 2, 3, 2);
            buttonDangXuat.Name = "buttonDangXuat";
            buttonDangXuat.Size = new Size(82, 22);
            buttonDangXuat.TabIndex = 9;
            buttonDangXuat.Text = "Đăng xuất khỏi trái đất";
            buttonDangXuat.UseVisualStyleBackColor = true;
            buttonDangXuat.Click += buttonDangXuat_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 466);
            Controls.Add(buttonDangXuat);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(buttonXoa);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonLoad;
        private Button buttonXoa;
        private Label label1;
        private TextBox textBoxSearch;
        private Button button1;
        private Button button2;
        private Button buttonDangXuat;
    }
}