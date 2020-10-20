namespace frmMain
{
    partial class frmThongTinNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheckNewPwd = new System.Windows.Forms.TextBox();
            this.btChangePwd = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(162, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu nhân viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmMain.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(313, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(178, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Nhân Viên";
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmailNV.Location = new System.Drawing.Point(182, 215);
            this.txtEmailNV.Multiline = true;
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.Size = new System.Drawing.Size(403, 30);
            this.txtEmailNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(178, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOldPwd.Location = new System.Drawing.Point(182, 294);
            this.txtOldPwd.Multiline = true;
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(403, 30);
            this.txtOldPwd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(178, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNewPwd.Location = new System.Drawing.Point(182, 380);
            this.txtNewPwd.Multiline = true;
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(403, 30);
            this.txtNewPwd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(178, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // txtCheckNewPwd
            // 
            this.txtCheckNewPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCheckNewPwd.Location = new System.Drawing.Point(182, 465);
            this.txtCheckNewPwd.Multiline = true;
            this.txtCheckNewPwd.Name = "txtCheckNewPwd";
            this.txtCheckNewPwd.PasswordChar = '*';
            this.txtCheckNewPwd.Size = new System.Drawing.Size(403, 30);
            this.txtCheckNewPwd.TabIndex = 3;
            // 
            // btChangePwd
            // 
            this.btChangePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btChangePwd.Location = new System.Drawing.Point(297, 523);
            this.btChangePwd.Name = "btChangePwd";
            this.btChangePwd.Size = new System.Drawing.Size(162, 38);
            this.btChangePwd.TabIndex = 4;
            this.btChangePwd.Text = "Đổi mật khẩu";
            this.btChangePwd.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btThoat.Location = new System.Drawing.Point(297, 567);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(162, 38);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btChangePwd);
            this.Controls.Add(this.txtCheckNewPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmThongTinNV";
            this.Text = "frmThongTinNV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheckNewPwd;
        private System.Windows.Forms.Button btChangePwd;
        private System.Windows.Forms.Button btThoat;
    }
}