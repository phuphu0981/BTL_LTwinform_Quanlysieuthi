namespace BTL
{
	partial class Login
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
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.vbButton1 = new CustomButton.VBButton();
			this.txtTenTKhoan = new BTL.custom.CustomTextBox();
			this.txtMatKhau = new BTL.custom.CustomTextBox();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic);
			this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new System.Drawing.Point(103, 351);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(219, 18);
			this.label5.TabIndex = 15;
			this.label5.Text = "Nếu bạn chưa có Tài Khoản?";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new System.Drawing.Point(338, 349);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Đăng kí";
			this.label4.Click += new System.EventHandler(this.label4_Click_1);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic);
			this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.lblError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblError.Location = new System.Drawing.Point(30, 395);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(33, 20);
			this.lblError.TabIndex = 13;
			this.lblError.Text = "Lỗi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F);
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new System.Drawing.Point(74, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 18);
			this.label3.TabIndex = 12;
			this.label3.Text = "Mật Khẩu:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F);
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(74, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 18);
			this.label2.TabIndex = 11;
			this.label2.Text = "Tên tài khoản:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(496, 40);
			this.label1.TabIndex = 10;
			this.label1.Text = "QUẢN LÝ SIÊU THỊ TTTNP";
			// 
			// vbButton1
			// 
			this.vbButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.vbButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.vbButton1.BorderColor = System.Drawing.Color.MistyRose;
			this.vbButton1.BorderRadius = 20;
			this.vbButton1.BorderSize = 2;
			this.vbButton1.FlatAppearance.BorderSize = 0;
			this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.vbButton1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vbButton1.ForeColor = System.Drawing.Color.White;
			this.vbButton1.Location = new System.Drawing.Point(117, 277);
			this.vbButton1.Name = "vbButton1";
			this.vbButton1.Size = new System.Drawing.Size(323, 54);
			this.vbButton1.TabIndex = 3;
			this.vbButton1.Text = "Đăng Nhập";
			this.vbButton1.TextColor = System.Drawing.Color.White;
			this.vbButton1.UseVisualStyleBackColor = false;
			this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
			// 
			// txtTenTKhoan
			// 
			this.txtTenTKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.txtTenTKhoan.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.txtTenTKhoan.BorderFocusColor = System.Drawing.Color.HotPink;
			this.txtTenTKhoan.BorderRadius = 10;
			this.txtTenTKhoan.BorderSize = 2;
			this.txtTenTKhoan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenTKhoan.ForeColor = System.Drawing.Color.Transparent;
			this.txtTenTKhoan.Location = new System.Drawing.Point(118, 135);
			this.txtTenTKhoan.MultyLine = true;
			this.txtTenTKhoan.Name = "txtTenTKhoan";
			this.txtTenTKhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtTenTKhoan.Passworchar = false;
			this.txtTenTKhoan.PlaceHodercolor1 = System.Drawing.Color.DarkGray;
			this.txtTenTKhoan.Placeholdertext1 = "";
			this.txtTenTKhoan.Size = new System.Drawing.Size(322, 33);
			this.txtTenTKhoan.TabIndex = 1;
			this.txtTenTKhoan.Texts = "";
			this.txtTenTKhoan.UnderlinedStyle = false;
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
			this.txtMatKhau.Location = new System.Drawing.Point(118, 210);
			this.txtMatKhau.MultyLine = false;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtMatKhau.Passworchar = true;
			this.txtMatKhau.PlaceHodercolor1 = System.Drawing.Color.DarkGray;
			this.txtMatKhau.Placeholdertext1 = "";
			this.txtMatKhau.Size = new System.Drawing.Size(322, 33);
			this.txtMatKhau.TabIndex = 2;
			this.txtMatKhau.Texts = "";
			this.txtMatKhau.UnderlinedStyle = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
			this.ClientSize = new System.Drawing.Size(555, 450);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.vbButton1);
			this.Controls.Add(this.txtTenTKhoan);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "   ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private custom.CustomTextBox txtTenTKhoan;
		public CustomButton.VBButton vbButton1;
		private custom.CustomTextBox txtMatKhau;
	}
}

