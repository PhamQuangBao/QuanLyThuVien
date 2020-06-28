namespace FormChinhV1
{
    partial class UserControlTTCN
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.txtpassold = new System.Windows.Forms.TextBox();
            this.txtpassnew2 = new System.Windows.Forms.TextBox();
            this.txtpassnew1 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button_Save);
            this.panel13.Controls.Add(this.button_Cancel);
            this.panel13.Controls.Add(this.label38);
            this.panel13.Controls.Add(this.txtpassold);
            this.panel13.Controls.Add(this.txtpassnew2);
            this.panel13.Controls.Add(this.txtpassnew1);
            this.panel13.Controls.Add(this.label35);
            this.panel13.Controls.Add(this.label36);
            this.panel13.Controls.Add(this.label37);
            this.panel13.Location = new System.Drawing.Point(313, 22);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(411, 482);
            this.panel13.TabIndex = 25;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Gold;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Image = global::FormChinhV1.Properties.Resources.save__1_;
            this.button_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Save.Location = new System.Drawing.Point(35, 401);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(133, 46);
            this.button_Save.TabIndex = 19;
            this.button_Save.Text = "SAVE";
            this.button_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.Gold;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Image = global::FormChinhV1.Properties.Resources.cancel321;
            this.button_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cancel.Location = new System.Drawing.Point(231, 401);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(134, 46);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(3, 3);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(162, 20);
            this.label38.TabIndex = 18;
            this.label38.Text = "Thay đổi mật khẩu";
            // 
            // txtpassold
            // 
            this.txtpassold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassold.Location = new System.Drawing.Point(194, 108);
            this.txtpassold.Name = "txtpassold";
            this.txtpassold.PasswordChar = '*';
            this.txtpassold.Size = new System.Drawing.Size(182, 27);
            this.txtpassold.TabIndex = 17;
            // 
            // txtpassnew2
            // 
            this.txtpassnew2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassnew2.Location = new System.Drawing.Point(194, 257);
            this.txtpassnew2.Name = "txtpassnew2";
            this.txtpassnew2.PasswordChar = '*';
            this.txtpassnew2.Size = new System.Drawing.Size(182, 27);
            this.txtpassnew2.TabIndex = 16;
            // 
            // txtpassnew1
            // 
            this.txtpassnew1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassnew1.Location = new System.Drawing.Point(194, 184);
            this.txtpassnew1.Name = "txtpassnew1";
            this.txtpassnew1.PasswordChar = '*';
            this.txtpassnew1.Size = new System.Drawing.Size(182, 27);
            this.txtpassnew1.TabIndex = 16;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(32, 111);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(96, 17);
            this.label35.TabIndex = 1;
            this.label35.Text = "Mật khẩu cũ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(32, 262);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(139, 17);
            this.label36.TabIndex = 1;
            this.label36.Text = "Nhập lại mật khẩu";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(32, 187);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(104, 17);
            this.label37.TabIndex = 1;
            this.label37.Text = "Mật khẩu mới";
            // 
            // UserControlTTCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panel13);
            this.Name = "UserControlTTCN";
            this.Size = new System.Drawing.Size(1040, 550);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtpassold;
        private System.Windows.Forms.TextBox txtpassnew2;
        private System.Windows.Forms.TextBox txtpassnew1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
    }
}
