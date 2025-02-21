namespace BTL
{
	partial class frmKhoHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoHang));
			this.btnHang = new System.Windows.Forms.Button();
			this.btnLoaihh = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btnNcc = new System.Windows.Forms.Button();
			this.btnNhap = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnHang
			// 
			this.btnHang.BackColor = System.Drawing.Color.LavenderBlush;
			this.btnHang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHang.Location = new System.Drawing.Point(12, 238);
			this.btnHang.Name = "btnHang";
			this.btnHang.Size = new System.Drawing.Size(412, 129);
			this.btnHang.TabIndex = 0;
			this.btnHang.Text = "Hàng hóa trưng bày";
			this.btnHang.UseVisualStyleBackColor = false;
			this.btnHang.Click += new System.EventHandler(this.btnHang_Click);
			// 
			// btnLoaihh
			// 
			this.btnLoaihh.BackColor = System.Drawing.Color.LavenderBlush;
			this.btnLoaihh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoaihh.Location = new System.Drawing.Point(12, 373);
			this.btnLoaihh.Name = "btnLoaihh";
			this.btnLoaihh.Size = new System.Drawing.Size(412, 129);
			this.btnLoaihh.TabIndex = 0;
			this.btnLoaihh.Text = "Loại hàng hóa";
			this.btnLoaihh.UseVisualStyleBackColor = false;
			this.btnLoaihh.Click += new System.EventHandler(this.btnLoaihh_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "phan-mem-ban-hang-quan-ly-kho-sieu-thi.jpg");
			this.imageList1.Images.SetKeyName(1, "phan-mem-ban-hang-quan-ly-kho-sieu-thi.jpg");
			this.imageList1.Images.SetKeyName(2, "snapedit_1703559443630.png");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(236, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(635, 68);
			this.label1.TabIndex = 1;
			this.label1.Text = "QUẢN LÝ SẢN PHẨM";
			// 
			// btnNcc
			// 
			this.btnNcc.BackColor = System.Drawing.Color.LavenderBlush;
			this.btnNcc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNcc.Location = new System.Drawing.Point(430, 238);
			this.btnNcc.Name = "btnNcc";
			this.btnNcc.Size = new System.Drawing.Size(412, 129);
			this.btnNcc.TabIndex = 2;
			this.btnNcc.Text = "Nhà cung cấp";
			this.btnNcc.UseVisualStyleBackColor = false;
			this.btnNcc.Click += new System.EventHandler(this.btnNcc_Click);
			// 
			// btnNhap
			// 
			this.btnNhap.BackColor = System.Drawing.Color.LavenderBlush;
			this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNhap.Location = new System.Drawing.Point(430, 373);
			this.btnNhap.Name = "btnNhap";
			this.btnNhap.Size = new System.Drawing.Size(412, 129);
			this.btnNhap.TabIndex = 3;
			this.btnNhap.Text = "Quản lý kho";
			this.btnNhap.UseVisualStyleBackColor = false;
			this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
			// 
			// label2
			// 
			this.label2.ImageIndex = 2;
			this.label2.ImageList = this.imageList1;
			this.label2.Location = new System.Drawing.Point(35, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 169);
			this.label2.TabIndex = 4;
			// 
			// frmKhoHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(867, 503);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnNhap);
			this.Controls.Add(this.btnNcc);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLoaihh);
			this.Controls.Add(this.btnHang);
			this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmKhoHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý kho ";
//			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKhoHang_FormClosed);
			this.Load += new System.EventHandler(this.frmKhoHang_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnHang;
		private System.Windows.Forms.Button btnLoaihh;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNcc;
		private System.Windows.Forms.Button btnNhap;
		private System.Windows.Forms.Label label2;
	}
}

