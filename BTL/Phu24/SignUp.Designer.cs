namespace BTL
{
	partial class SignUp
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
			this.label10 = new System.Windows.Forms.Label();
			this.lblDangnhap = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.rdoNhanvien = new System.Windows.Forms.RadioButton();
			this.rdoQuanly = new System.Windows.Forms.RadioButton();
			this.rdoAdmin = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSdt = new BTL.custom.CustomTextBox();
			this.txtEmail = new BTL.custom.CustomTextBox();
			this.txtName = new BTL.custom.CustomTextBox();
			this.txtTenTK = new BTL.custom.CustomTextBox();
			this.txtMatKhau = new BTL.custom.CustomTextBox();
			this.txtMatKhau2 = new BTL.custom.CustomTextBox();
			this.btnDangki = new CustomButton.VBButton();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Gainsboro;
			this.label10.Location = new System.Drawing.Point(101, 55);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(403, 45);
			this.label10.TabIndex = 49;
			this.label10.Text = "Đăng Kí Tài Khoản";
			// 
			// lblDangnhap
			// 
			this.lblDangnhap.AutoSize = true;
			this.lblDangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.lblDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblDangnhap.Location = new System.Drawing.Point(387, 533);
			this.lblDangnhap.Name = "lblDangnhap";
			this.lblDangnhap.Size = new System.Drawing.Size(143, 20);
			this.lblDangnhap.TabIndex = 47;
			this.lblDangnhap.Text = "Đăng nhập ngay";
			this.lblDangnhap.Click += new System.EventHandler(this.lblDangnhap_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(235, 537);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(139, 16);
			this.label8.TabIndex = 46;
			this.label8.Text = "Bạn đã có Tài Khoản?";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(52, 375);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(147, 18);
			this.label7.TabIndex = 45;
			this.label7.Text = "Nhập lại Mật khẩu:";
			// 
			// rdoNhanvien
			// 
			this.rdoNhanvien.AutoSize = true;
			this.rdoNhanvien.ForeColor = System.Drawing.Color.Transparent;
			this.rdoNhanvien.Location = new System.Drawing.Point(440, 419);
			this.rdoNhanvien.Name = "rdoNhanvien";
			this.rdoNhanvien.Size = new System.Drawing.Size(90, 20);
			this.rdoNhanvien.TabIndex = 8;
			this.rdoNhanvien.TabStop = true;
			this.rdoNhanvien.Text = "Nhân Viên";
			this.rdoNhanvien.UseVisualStyleBackColor = true;
			// 
			// rdoQuanly
			// 
			this.rdoQuanly.AutoSize = true;
			this.rdoQuanly.ForeColor = System.Drawing.Color.Transparent;
			this.rdoQuanly.Location = new System.Drawing.Point(333, 420);
			this.rdoQuanly.Name = "rdoQuanly";
			this.rdoQuanly.Size = new System.Drawing.Size(77, 20);
			this.rdoQuanly.TabIndex = 7;
			this.rdoQuanly.TabStop = true;
			this.rdoQuanly.Text = "Quản Lý";
			this.rdoQuanly.UseVisualStyleBackColor = true;
			// 
			// rdoAdmin
			// 
			this.rdoAdmin.AutoSize = true;
			this.rdoAdmin.ForeColor = System.Drawing.Color.Transparent;
			this.rdoAdmin.Location = new System.Drawing.Point(239, 419);
			this.rdoAdmin.Name = "rdoAdmin";
			this.rdoAdmin.Size = new System.Drawing.Size(66, 20);
			this.rdoAdmin.TabIndex = 6;
			this.rdoAdmin.TabStop = true;
			this.rdoAdmin.Text = "Admin";
			this.rdoAdmin.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(52, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 18);
			this.label4.TabIndex = 41;
			this.label4.Text = "Họ Tên";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(52, 422);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 18);
			this.label6.TabIndex = 40;
			this.label6.Text = "Loại Tài Khoản";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(52, 281);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 18);
			this.label5.TabIndex = 39;
			this.label5.Text = "Tên tài khoản:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(52, 193);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 18);
			this.label1.TabIndex = 38;
			this.label1.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(52, 330);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 18);
			this.label3.TabIndex = 37;
			this.label3.Text = "Mật Khẩu:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(52, 235);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 18);
			this.label2.TabIndex = 36;
			this.label2.Text = "SDT";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icons8-delete-30.png");
			this.imageList1.Images.SetKeyName(1, "icons8-deletewhrite-24.png");
			this.imageList1.Images.SetKeyName(2, "icons8-delete-64.png");
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ImageKey = "icons8-cancel-50.png";
			this.label12.Location = new System.Drawing.Point(599, 20);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(16, 16);
			this.label12.TabIndex = 50;
			this.label12.Text = "   ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Transparent;
			this.label9.ImageKey = "icons8-delete-64.png";
			this.label9.ImageList = this.imageList1;
			this.label9.Location = new System.Drawing.Point(570, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 18);
			this.label9.TabIndex = 51;
			this.label9.Text = "   ";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// txtSdt
			// 
			this.txtSdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.txtSdt.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.txtSdt.BorderFocusColor = System.Drawing.Color.HotPink;
			this.txtSdt.BorderRadius = 0;
			this.txtSdt.BorderSize = 2;
			this.txtSdt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSdt.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtSdt.Location = new System.Drawing.Point(217, 210);
			this.txtSdt.MultyLine = false;
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtSdt.Passworchar = false;
			this.txtSdt.PlaceHodercolor1 = System.Drawing.Color.DarkGray;
			this.txtSdt.Placeholdertext1 = "";
			this.txtSdt.Size = new System.Drawing.Size(303, 33);
			this.txtSdt.TabIndex = 2;
			this.txtSdt.Texts = "";
			this.txtSdt.UnderlinedStyle = true;
			this.txtSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSdt_KeyPress);
			this.txtSdt.Leave += new System.EventHandler(this.txtSdt_Leave);
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.txtEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
			this.txtEmail.BorderRadius = 0;
			this.txtEmail.BorderSize = 2;
			this.txtEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtEmail.Location = new System.Drawing.Point(218, 168);
			this.txtEmail.MultyLine = false;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtEmail.Passworchar = false;
			this.txtEmail.PlaceHodercolor1 = System.Drawing.Color.DarkGray;
			this.txtEmail.Placeholdertext1 = "";
			this.txtEmail.Size = new System.Drawing.Size(303, 33);
			this.txtEmail.TabIndex = 1;
			this.txtEmail.Texts = "";
			this.txtEmail.UnderlinedStyle = true;
			this.txtEmail._TextChanged += new System.EventHandler(this.txtEmail__TextChanged);
			this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
			this.txtName.BorderRadius = 0;
			this.txtName.BorderSize = 2;
			this.txtName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtName.Location = new System.Drawing.Point(217, 123);
			this.txtName.MultyLine = false;
			this.txtName.Name = "txtName";
			this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtName.Passworchar = false;
			this.txtName.PlaceHodercolor1 = System.Drawing.Color.DarkGray;
			this.txtName.Placeholdertext1 = "";
			this.txtName.Size = new System.Drawing.Size(303, 33);
			this.txtName.TabIndex = 0;
			this.txtName.Texts = "";
			this.txtName.UnderlinedStyle = true;
			this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
			this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
			// 
			// txtTenTK
			// 
			this.txtTenTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.txtTenTK.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.txtTenTK.BorderFocusColor = System.Drawing.Color.HotPink;
			this.txtTenTK.BorderRadius = 10;
			this.txtTenTK.BorderSize = 2;
			this.txtTenTK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenTK.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtTenTK.Location = new System.Drawing.Point(217, 271);
			this.txtTenTK.MultyLine = false;
			this.txtTenTK.Name = "txtTenTK";
			this.txtTenTK.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtTenTK.Passworchar = false;
			this.txtTenTK.PlaceHodercolor1 = System.Drawing.Color.DarkGray;
			this.txtTenTK.Placeholdertext1 = "";
			this.txtTenTK.Size = new System.Drawing.Size(303, 33);
			this.txtTenTK.TabIndex = 3;
			this.txtTenTK.Texts = "";
			this.txtTenTK.UnderlinedStyle = false;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.txtMatKhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
			this.txtMatKhau.BorderRadius = 10;
			this.txtMatKhau.BorderSize = 2;
			this.txtMatKhau.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatKhau.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtMatKhau.Location = new System.Drawing.Point(217, 320);
			this.txtMatKhau.MultyLine = false;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtMatKhau.Passworchar = true;
			this.txtMatKhau.PlaceHodercolor1 = System.Drawing.Color.DarkGray;
			this.txtMatKhau.Placeholdertext1 = "";
			this.txtMatKhau.Size = new System.Drawing.Size(303, 33);
			this.txtMatKhau.TabIndex = 4;
			this.txtMatKhau.Texts = "";
			this.txtMatKhau.UnderlinedStyle = false;
			// 
			// txtMatKhau2
			// 
			this.txtMatKhau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.txtMatKhau2.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.txtMatKhau2.BorderFocusColor = System.Drawing.Color.HotPink;
			this.txtMatKhau2.BorderRadius = 10;
			this.txtMatKhau2.BorderSize = 2;
			this.txtMatKhau2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatKhau2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtMatKhau2.Location = new System.Drawing.Point(217, 365);
			this.txtMatKhau2.MultyLine = false;
			this.txtMatKhau2.Name = "txtMatKhau2";
			this.txtMatKhau2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtMatKhau2.Passworchar = true;
			this.txtMatKhau2.PlaceHodercolor1 = System.Drawing.Color.DarkGray;
			this.txtMatKhau2.Placeholdertext1 = "";
			this.txtMatKhau2.Size = new System.Drawing.Size(303, 33);
			this.txtMatKhau2.TabIndex = 5;
			this.txtMatKhau2.Texts = "";
			this.txtMatKhau2.UnderlinedStyle = false;
			// 
			// btnDangki
			// 
			this.btnDangki.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnDangki.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.btnDangki.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnDangki.BorderRadius = 20;
			this.btnDangki.BorderSize = 0;
			this.btnDangki.FlatAppearance.BorderSize = 0;
			this.btnDangki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDangki.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangki.ForeColor = System.Drawing.Color.White;
			this.btnDangki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDangki.ImageList = this.imageList1;
			this.btnDangki.Location = new System.Drawing.Point(218, 459);
			this.btnDangki.Name = "btnDangki";
			this.btnDangki.Size = new System.Drawing.Size(304, 51);
			this.btnDangki.TabIndex = 9;
			this.btnDangki.Text = "Đăng Kí";
			this.btnDangki.TextColor = System.Drawing.Color.White;
			this.btnDangki.UseVisualStyleBackColor = false;
			this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
			// 
			// SignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.ClientSize = new System.Drawing.Size(638, 585);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtSdt);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtTenTK);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtMatKhau2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnDangki);
			this.Controls.Add(this.lblDangnhap);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.rdoNhanvien);
			this.Controls.Add(this.rdoQuanly);
			this.Controls.Add(this.rdoAdmin);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUp";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "   ";
			this.Load += new System.EventHandler(this.SignUp_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label10;
		private CustomButton.VBButton btnDangki;
		private System.Windows.Forms.Label lblDangnhap;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rdoNhanvien;
		private System.Windows.Forms.RadioButton rdoQuanly;
		private System.Windows.Forms.RadioButton rdoAdmin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private custom.CustomTextBox txtMatKhau2;
		private custom.CustomTextBox txtMatKhau;
		private custom.CustomTextBox txtTenTK;
		private custom.CustomTextBox txtName;
		private custom.CustomTextBox txtEmail;
		private custom.CustomTextBox txtSdt;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
	}
}