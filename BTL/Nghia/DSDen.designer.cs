namespace BTL
{
	partial class DSDen
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
			this.btnAnh = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDacDiem = new System.Windows.Forms.TextBox();
			this.dtpNgayDienRa = new System.Windows.Forms.DateTimePicker();
			this.cboDoTuoi = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rdoNam = new System.Windows.Forms.RadioButton();
			this.rdoNu = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvMain = new System.Windows.Forms.DataGridView();
			this.DoTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DacDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayDienRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AnhDoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnGhi = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.ptbAnhDoiTuong = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbAnhDoiTuong)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAnh
			// 
			this.btnAnh.AutoSize = true;
			this.btnAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnAnh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnAnh.Location = new System.Drawing.Point(434, 503);
			this.btnAnh.Name = "btnAnh";
			this.btnAnh.Size = new System.Drawing.Size(104, 38);
			this.btnAnh.TabIndex = 168;
			this.btnAnh.Text = "Ảnh";
			this.btnAnh.UseVisualStyleBackColor = false;
			this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(563, 255);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 26);
			this.label4.TabIndex = 167;
			this.label4.Text = "Ảnh đối tượng: ";
			// 
			// txtDacDiem
			// 
			this.txtDacDiem.BackColor = System.Drawing.SystemColors.Window;
			this.txtDacDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDacDiem.Location = new System.Drawing.Point(279, 371);
			this.txtDacDiem.Name = "txtDacDiem";
			this.txtDacDiem.Size = new System.Drawing.Size(223, 30);
			this.txtDacDiem.TabIndex = 165;
			// 
			// dtpNgayDienRa
			// 
			this.dtpNgayDienRa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNgayDienRa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayDienRa.Location = new System.Drawing.Point(279, 418);
			this.dtpNgayDienRa.Name = "dtpNgayDienRa";
			this.dtpNgayDienRa.Size = new System.Drawing.Size(223, 30);
			this.dtpNgayDienRa.TabIndex = 164;
			// 
			// cboDoTuoi
			// 
			this.cboDoTuoi.BackColor = System.Drawing.SystemColors.Window;
			this.cboDoTuoi.FormattingEnabled = true;
			this.cboDoTuoi.Items.AddRange(new object[] {
            "Trẻ con",
            "Trẻ vị thành niên",
            "Thanh niên",
            "Trung niên",
            "Người già"});
			this.cboDoTuoi.Location = new System.Drawing.Point(279, 271);
			this.cboDoTuoi.Name = "cboDoTuoi";
			this.cboDoTuoi.Size = new System.Drawing.Size(223, 24);
			this.cboDoTuoi.TabIndex = 163;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(51, 271);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 26);
			this.label2.TabIndex = 162;
			this.label2.Text = "Độ tuổi:";
			// 
			// rdoNam
			// 
			this.rdoNam.AutoSize = true;
			this.rdoNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoNam.Location = new System.Drawing.Point(279, 325);
			this.rdoNam.Name = "rdoNam";
			this.rdoNam.Size = new System.Drawing.Size(68, 26);
			this.rdoNam.TabIndex = 160;
			this.rdoNam.TabStop = true;
			this.rdoNam.Text = "Nam";
			this.rdoNam.UseVisualStyleBackColor = true;
			// 
			// rdoNu
			// 
			this.rdoNu.AutoSize = true;
			this.rdoNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoNu.Location = new System.Drawing.Point(364, 325);
			this.rdoNu.Name = "rdoNu";
			this.rdoNu.Size = new System.Drawing.Size(56, 26);
			this.rdoNu.TabIndex = 161;
			this.rdoNu.TabStop = true;
			this.rdoNu.Text = "Nữ";
			this.rdoNu.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(51, 422);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 26);
			this.label5.TabIndex = 157;
			this.label5.Text = "Ngày diễn ra:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(51, 375);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 26);
			this.label3.TabIndex = 158;
			this.label3.Text = "Đặc điểm nhận dạng: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(51, 324);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 26);
			this.label6.TabIndex = 159;
			this.label6.Text = "Giới tính:";
			// 
			// dgvMain
			// 
			this.dgvMain.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoTuoi,
            this.GioiTinh,
            this.SEX,
            this.DacDiem,
            this.NgayDienRa,
            this.AnhDoiTuong});
			this.dgvMain.Location = new System.Drawing.Point(12, 12);
			this.dgvMain.Name = "dgvMain";
			this.dgvMain.RowHeadersWidth = 51;
			this.dgvMain.RowTemplate.Height = 24;
			this.dgvMain.Size = new System.Drawing.Size(858, 220);
			this.dgvMain.TabIndex = 156;
			this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
			this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
			// 
			// DoTuoi
			// 
			this.DoTuoi.DataPropertyName = "DoTuoi";
			this.DoTuoi.HeaderText = "DoTuoi";
			this.DoTuoi.MinimumWidth = 6;
			this.DoTuoi.Name = "DoTuoi";
			this.DoTuoi.Width = 125;
			// 
			// GioiTinh
			// 
			this.GioiTinh.DataPropertyName = "GioiTinh";
			this.GioiTinh.HeaderText = "GioiTinh";
			this.GioiTinh.MinimumWidth = 6;
			this.GioiTinh.Name = "GioiTinh";
			this.GioiTinh.Visible = false;
			this.GioiTinh.Width = 125;
			// 
			// SEX
			// 
			this.SEX.DataPropertyName = "SEX";
			this.SEX.HeaderText = "GioiTinh";
			this.SEX.MinimumWidth = 6;
			this.SEX.Name = "SEX";
			this.SEX.Width = 125;
			// 
			// DacDiem
			// 
			this.DacDiem.DataPropertyName = "DacDiem";
			this.DacDiem.HeaderText = "DacDiem";
			this.DacDiem.MinimumWidth = 6;
			this.DacDiem.Name = "DacDiem";
			this.DacDiem.Width = 125;
			// 
			// NgayDienRa
			// 
			this.NgayDienRa.DataPropertyName = "NgayDienRa";
			this.NgayDienRa.HeaderText = "NgayDienRa";
			this.NgayDienRa.MinimumWidth = 6;
			this.NgayDienRa.Name = "NgayDienRa";
			this.NgayDienRa.Width = 125;
			// 
			// AnhDoiTuong
			// 
			this.AnhDoiTuong.DataPropertyName = "AnhDoiTuong";
			this.AnhDoiTuong.HeaderText = "AnhDoiTuong";
			this.AnhDoiTuong.MinimumWidth = 6;
			this.AnhDoiTuong.Name = "AnhDoiTuong";
			this.AnhDoiTuong.Width = 125;
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnHuy.Location = new System.Drawing.Point(692, 504);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(104, 38);
			this.btnHuy.TabIndex = 154;
			this.btnHuy.Text = "Huỷ";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnGhi
			// 
			this.btnGhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnGhi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnGhi.Location = new System.Drawing.Point(565, 504);
			this.btnGhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(104, 38);
			this.btnGhi.TabIndex = 153;
			this.btnGhi.Text = "Ghi";
			this.btnGhi.UseVisualStyleBackColor = false;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.Location = new System.Drawing.Point(312, 504);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(104, 38);
			this.btnXoa.TabIndex = 152;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSua.Location = new System.Drawing.Point(191, 504);
			this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(104, 38);
			this.btnSua.TabIndex = 155;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThem.Location = new System.Drawing.Point(65, 504);
			this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(104, 38);
			this.btnThem.TabIndex = 151;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// ptbAnhDoiTuong
			// 
			this.ptbAnhDoiTuong.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ptbAnhDoiTuong.Location = new System.Drawing.Point(577, 284);
			this.ptbAnhDoiTuong.Name = "ptbAnhDoiTuong";
			this.ptbAnhDoiTuong.Size = new System.Drawing.Size(245, 164);
			this.ptbAnhDoiTuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbAnhDoiTuong.TabIndex = 166;
			this.ptbAnhDoiTuong.TabStop = false;
			// 
			// DSDen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(882, 553);
			this.Controls.Add(this.btnAnh);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ptbAnhDoiTuong);
			this.Controls.Add(this.txtDacDiem);
			this.Controls.Add(this.dtpNgayDienRa);
			this.Controls.Add(this.cboDoTuoi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rdoNam);
			this.Controls.Add(this.rdoNu);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dgvMain);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Name = "DSDen";
			this.Text = "Đối tượng nguy hiểm";
			this.Load += new System.EventHandler(this.DSDen_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbAnhDoiTuong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAnh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox ptbAnhDoiTuong;
		private System.Windows.Forms.TextBox txtDacDiem;
		private System.Windows.Forms.DateTimePicker dtpNgayDienRa;
		private System.Windows.Forms.ComboBox cboDoTuoi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rdoNam;
		private System.Windows.Forms.RadioButton rdoNu;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvMain;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridViewTextBoxColumn DoTuoi;
		private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn SEX;
		private System.Windows.Forms.DataGridViewTextBoxColumn DacDiem;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayDienRa;
		private System.Windows.Forms.DataGridViewTextBoxColumn AnhDoiTuong;
	}
}