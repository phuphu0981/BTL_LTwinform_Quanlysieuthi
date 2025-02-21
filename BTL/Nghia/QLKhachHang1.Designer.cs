namespace BTL.Nghia
{
	partial class QLKhachHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLKhachHang));
			this.btnDSDen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnKHBT = new System.Windows.Forms.Button();
			this.btnKHTT = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnDSDen
			// 
			this.btnDSDen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnDSDen.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnDSDen.Location = new System.Drawing.Point(460, 383);
			this.btnDSDen.Name = "btnDSDen";
			this.btnDSDen.Size = new System.Drawing.Size(412, 129);
			this.btnDSDen.TabIndex = 18;
			this.btnDSDen.Text = "Đối tượng nguy hiểm";
			this.btnDSDen.UseVisualStyleBackColor = false;
			this.btnDSDen.Click += new System.EventHandler(this.btnNcc_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(237, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(620, 57);
			this.label1.TabIndex = 17;
			this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
			// 
			// btnKHBT
			// 
			this.btnKHBT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnKHBT.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnKHBT.Location = new System.Drawing.Point(42, 383);
			this.btnKHBT.Name = "btnKHBT";
			this.btnKHBT.Size = new System.Drawing.Size(412, 129);
			this.btnKHBT.TabIndex = 15;
			this.btnKHBT.Text = "Khảo sát khách hàng";
			this.btnKHBT.UseVisualStyleBackColor = false;
			this.btnKHBT.Click += new System.EventHandler(this.btnLoaihh_Click);
			// 
			// btnKHTT
			// 
			this.btnKHTT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnKHTT.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnKHTT.Location = new System.Drawing.Point(42, 248);
			this.btnKHTT.Name = "btnKHTT";
			this.btnKHTT.Size = new System.Drawing.Size(830, 129);
			this.btnKHTT.TabIndex = 16;
			this.btnKHTT.Text = "Khách hàng thân thiết";
			this.btnKHTT.UseVisualStyleBackColor = false;
			this.btnKHTT.Click += new System.EventHandler(this.btnHang_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "logo.png");
			// 
			// label2
			// 
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.imageList1;
			this.label2.Location = new System.Drawing.Point(42, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 168);
			this.label2.TabIndex = 19;
			// 
			// QLKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(934, 559);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnDSDen);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnKHBT);
			this.Controls.Add(this.btnKHTT);
			this.Name = "QLKhachHang";
			this.Text = "Quản lí khách hàng";
//			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLKhachHang_FormClosing);
			this.Load += new System.EventHandler(this.QLKhachHang_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDSDen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnKHBT;
		private System.Windows.Forms.Button btnKHTT;
		private System.Windows.Forms.ImageList imageList1;
	}
}