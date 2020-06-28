namespace FormChinhV1
{
    partial class UserControlQLĐG
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
            this.cbbluachon = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgDung = new System.Windows.Forms.TextBox();
            this.dateTimeNgayHuy = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeNSinh = new System.Windows.Forms.DateTimePicker();
            this.radioBNu = new System.Windows.Forms.RadioButton();
            this.radioBNam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdDG = new System.Windows.Forms.TextBox();
            this.txtSdtDG = new System.Windows.Forms.TextBox();
            this.txtIdPMT = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtNameDG = new System.Windows.Forms.TextBox();
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
            this.panel3.Location = new System.Drawing.Point(59, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 250);
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
            this.dataGridView1.Size = new System.Drawing.Size(917, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbluachon);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Controls.Add(this.btn_Del);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Location = new System.Drawing.Point(59, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 70);
            this.panel2.TabIndex = 8;
            // 
            // cbbluachon
            // 
            this.cbbluachon.FormattingEnabled = true;
            this.cbbluachon.Items.AddRange(new object[] {
            "Thông tin độc giả",
            "Thông tin phiếu mượn trả"});
            this.cbbluachon.Location = new System.Drawing.Point(629, 10);
            this.cbbluachon.Name = "cbbluachon";
            this.cbbluachon.Size = new System.Drawing.Size(279, 24);
            this.cbbluachon.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Gold;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Image = global::FormChinhV1.Properties.Resources.cancel321;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.Location = new System.Drawing.Point(363, 13);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(119, 46);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Gold;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = global::FormChinhV1.Properties.Resources.find;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(488, 13);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 46);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "SEARCH";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.Gold;
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Image = global::FormChinhV1.Properties.Resources.del321;
            this.btn_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Del.Location = new System.Drawing.Point(241, 13);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(116, 46);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "DELETE";
            this.btn_Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Gold;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Image = global::FormChinhV1.Properties.Resources.update321;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(121, 13);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(114, 46);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.Gold;
            this.btn_Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Image = global::FormChinhV1.Properties.Resources.add321;
            this.btn_Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Insert.Location = new System.Drawing.Point(8, 13);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(107, 46);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(629, 40);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(279, 22);
            this.txt_Search.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNgDung);
            this.panel1.Controls.Add(this.dateTimeNgayHuy);
            this.panel1.Controls.Add(this.dateTimeNgayTao);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimeNSinh);
            this.panel1.Controls.Add(this.radioBNu);
            this.panel1.Controls.Add(this.radioBNam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdDG);
            this.panel1.Controls.Add(this.txtSdtDG);
            this.panel1.Controls.Add(this.txtIdPMT);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.txtNameDG);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 192);
            this.panel1.TabIndex = 7;
            // 
            // txtNgDung
            // 
            this.txtNgDung.Location = new System.Drawing.Point(604, 87);
            this.txtNgDung.Name = "txtNgDung";
            this.txtNgDung.Size = new System.Drawing.Size(260, 22);
            this.txtNgDung.TabIndex = 13;
            // 
            // dateTimeNgayHuy
            // 
            this.dateTimeNgayHuy.Location = new System.Drawing.Point(604, 158);
            this.dateTimeNgayHuy.Name = "dateTimeNgayHuy";
            this.dateTimeNgayHuy.Size = new System.Drawing.Size(260, 22);
            this.dateTimeNgayHuy.TabIndex = 12;
            // 
            // dateTimeNgayTao
            // 
            this.dateTimeNgayTao.Location = new System.Drawing.Point(604, 125);
            this.dateTimeNgayTao.Name = "dateTimeNgayTao";
            this.dateTimeNgayTao.Size = new System.Drawing.Size(260, 22);
            this.dateTimeNgayTao.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ngày hết hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày tạo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Người dùng";
            // 
            // dateTimeNSinh
            // 
            this.dateTimeNSinh.Location = new System.Drawing.Point(135, 120);
            this.dateTimeNSinh.Name = "dateTimeNSinh";
            this.dateTimeNSinh.Size = new System.Drawing.Size(284, 22);
            this.dateTimeNSinh.TabIndex = 6;
            // 
            // radioBNu
            // 
            this.radioBNu.AutoSize = true;
            this.radioBNu.Location = new System.Drawing.Point(224, 88);
            this.radioBNu.Name = "radioBNu";
            this.radioBNu.Size = new System.Drawing.Size(47, 21);
            this.radioBNu.TabIndex = 5;
            this.radioBNu.TabStop = true;
            this.radioBNu.Text = "Nữ";
            this.radioBNu.UseVisualStyleBackColor = true;
            // 
            // radioBNam
            // 
            this.radioBNam.AutoSize = true;
            this.radioBNam.Location = new System.Drawing.Point(135, 88);
            this.radioBNam.Name = "radioBNam";
            this.radioBNam.Size = new System.Drawing.Size(58, 21);
            this.radioBNam.TabIndex = 4;
            this.radioBNam.TabStop = true;
            this.radioBNam.Text = "Nam";
            this.radioBNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã mượn tài liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên";
            // 
            // txtIdDG
            // 
            this.txtIdDG.Location = new System.Drawing.Point(135, 9);
            this.txtIdDG.Name = "txtIdDG";
            this.txtIdDG.Size = new System.Drawing.Size(284, 22);
            this.txtIdDG.TabIndex = 1;
            // 
            // txtSdtDG
            // 
            this.txtSdtDG.Location = new System.Drawing.Point(604, 9);
            this.txtSdtDG.Name = "txtSdtDG";
            this.txtSdtDG.Size = new System.Drawing.Size(260, 22);
            this.txtSdtDG.TabIndex = 1;
            // 
            // txtIdPMT
            // 
            this.txtIdPMT.Location = new System.Drawing.Point(604, 53);
            this.txtIdPMT.Name = "txtIdPMT";
            this.txtIdPMT.Size = new System.Drawing.Size(260, 22);
            this.txtIdPMT.TabIndex = 1;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(135, 157);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(284, 22);
            this.txtDiachi.TabIndex = 1;
            // 
            // txtNameDG
            // 
            this.txtNameDG.Location = new System.Drawing.Point(135, 53);
            this.txtNameDG.Name = "txtNameDG";
            this.txtNameDG.Size = new System.Drawing.Size(284, 22);
            this.txtNameDG.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Độc giả";
            // 
            // UserControlQLĐG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlQLĐG";
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
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimeNSinh;
        private System.Windows.Forms.RadioButton radioBNu;
        private System.Windows.Forms.RadioButton radioBNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdDG;
        private System.Windows.Forms.TextBox txtSdtDG;
        private System.Windows.Forms.TextBox txtIdPMT;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtNameDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimeNgayHuy;
        private System.Windows.Forms.DateTimePicker dateTimeNgayTao;
        private System.Windows.Forms.ComboBox cbbluachon;
        private System.Windows.Forms.TextBox txtNgDung;
    }
}
