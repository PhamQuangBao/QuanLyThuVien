namespace FormChinhV1
{
    partial class UserControlTra
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgDung = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeTra = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPhTra = new System.Windows.Forms.ComboBox();
            this.cbbTailieu = new System.Windows.Forms.ComboBox();
            this.cbbTTrang = new System.Windows.Forms.ComboBox();
            this.txtDocGia = new System.Windows.Forms.TextBox();
            this.txtbID_TaiLieu = new System.Windows.Forms.TextBox();
            this.txtbsoluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(59, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 297);
            this.panel3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(917, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Location = new System.Drawing.Point(59, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 72);
            this.panel2.TabIndex = 8;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Gold;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Image = global::FormChinhV1.Properties.Resources.cancel321;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.Location = new System.Drawing.Point(264, 13);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(128, 46);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Gold;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = global::FormChinhV1.Properties.Resources.find;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(448, 13);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(134, 46);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "SEARCH";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.Gold;
            this.btn_Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Image = global::FormChinhV1.Properties.Resources.apply13;
            this.btn_Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Insert.Location = new System.Drawing.Point(83, 13);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(134, 46);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "XÁC NHẬN";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(630, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(630, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(279, 22);
            this.txt_Search.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNgDung);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimeTra);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbPhTra);
            this.panel1.Controls.Add(this.cbbTailieu);
            this.panel1.Controls.Add(this.cbbTTrang);
            this.panel1.Controls.Add(this.txtDocGia);
            this.panel1.Controls.Add(this.txtbID_TaiLieu);
            this.panel1.Controls.Add(this.txtbsoluong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 155);
            this.panel1.TabIndex = 7;
            // 
            // txtNgDung
            // 
            this.txtNgDung.Location = new System.Drawing.Point(675, 42);
            this.txtNgDung.Name = "txtNgDung";
            this.txtNgDung.Size = new System.Drawing.Size(221, 22);
            this.txtNgDung.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(536, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Người nhận";
            // 
            // dateTimeTra
            // 
            this.dateTimeTra.Location = new System.Drawing.Point(675, 80);
            this.dateTimeTra.Name = "dateTimeTra";
            this.dateTimeTra.Size = new System.Drawing.Size(200, 22);
            this.dateTimeTra.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ngày trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phiếu mượn trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tài liệu";
            // 
            // cbbPhTra
            // 
            this.cbbPhTra.FormattingEnabled = true;
            this.cbbPhTra.Location = new System.Drawing.Point(150, 121);
            this.cbbPhTra.Name = "cbbPhTra";
            this.cbbPhTra.Size = new System.Drawing.Size(296, 24);
            this.cbbPhTra.TabIndex = 2;
            this.cbbPhTra.SelectedIndexChanged += new System.EventHandler(this.cbbPhTra_SelectedIndexChanged);
            // 
            // cbbTailieu
            // 
            this.cbbTailieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTailieu.FormattingEnabled = true;
            this.cbbTailieu.Location = new System.Drawing.Point(150, 35);
            this.cbbTailieu.Name = "cbbTailieu";
            this.cbbTailieu.Size = new System.Drawing.Size(296, 26);
            this.cbbTailieu.TabIndex = 2;
            // 
            // cbbTTrang
            // 
            this.cbbTTrang.FormattingEnabled = true;
            this.cbbTTrang.Items.AddRange(new object[] {
            "Tốt",
            "Cũ",
            "Hỏng hoặc làm mất"});
            this.cbbTTrang.Location = new System.Drawing.Point(675, 7);
            this.cbbTTrang.Name = "cbbTTrang";
            this.cbbTTrang.Size = new System.Drawing.Size(221, 24);
            this.cbbTTrang.TabIndex = 2;
            // 
            // txtDocGia
            // 
            this.txtDocGia.Location = new System.Drawing.Point(150, 65);
            this.txtDocGia.Name = "txtDocGia";
            this.txtDocGia.Size = new System.Drawing.Size(296, 22);
            this.txtDocGia.TabIndex = 1;
            // 
            // txtbID_TaiLieu
            // 
            this.txtbID_TaiLieu.Location = new System.Drawing.Point(150, 7);
            this.txtbID_TaiLieu.Name = "txtbID_TaiLieu";
            this.txtbID_TaiLieu.ReadOnly = true;
            this.txtbID_TaiLieu.Size = new System.Drawing.Size(296, 22);
            this.txtbID_TaiLieu.TabIndex = 1;
            // 
            // txtbsoluong
            // 
            this.txtbsoluong.Location = new System.Drawing.Point(150, 93);
            this.txtbsoluong.Name = "txtbsoluong";
            this.txtbsoluong.Size = new System.Drawing.Size(296, 22);
            this.txtbsoluong.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tình trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Phiếu Mượn";
            // 
            // UserControlTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlTra";
            this.Size = new System.Drawing.Size(1040, 550);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimeTra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTailieu;
        private System.Windows.Forms.ComboBox cbbTTrang;
        private System.Windows.Forms.TextBox txtDocGia;
        private System.Windows.Forms.TextBox txtbID_TaiLieu;
        private System.Windows.Forms.TextBox txtbsoluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPhTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNgDung;
    }
}
