namespace BTL
{
	partial class Thongtinnv
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongtinnv));
			this.dgvxuat = new System.Windows.Forms.DataGridView();
			this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtma = new System.Windows.Forms.TextBox();
			this.txtten = new System.Windows.Forms.TextBox();
			this.txtque = new System.Windows.Forms.TextBox();
			this.txtsdt = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radnu = new System.Windows.Forms.RadioButton();
			this.radnam = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnreset = new System.Windows.Forms.Button();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.btntimkiem = new System.Windows.Forms.Button();
			this.imageList3 = new System.Windows.Forms.ImageList(this.components);
			this.btnhuy = new System.Windows.Forms.Button();
			this.btnghi = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btnsua = new System.Windows.Forms.Button();
			this.btnthem = new System.Windows.Forms.Button();
			this.dtpns = new System.Windows.Forms.DateTimePicker();
			this.cbochucvu = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txttimkiem = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.errorProviderThongtin = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvxuat)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderThongtin)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvxuat
			// 
			this.dgvxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Manv,
			this.Tennv,
			this.Gioitinh,
			this.Ngaysinh,
			this.Quequan,
			this.SDT,
			this.Chucvu,
			this.Column1});
			this.dgvxuat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvxuat.Location = new System.Drawing.Point(0, 288);
			this.dgvxuat.Name = "dgvxuat";
			this.dgvxuat.ReadOnly = true;
			this.dgvxuat.RowHeadersWidth = 62;
			this.dgvxuat.RowTemplate.Height = 28;
			this.dgvxuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvxuat.Size = new System.Drawing.Size(1010, 276);
			this.dgvxuat.TabIndex = 0;
			this.dgvxuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvxuat_CellClick);
			// 
			// Manv
			// 
			this.Manv.DataPropertyName = "Manv";
			this.Manv.HeaderText = "Mã NV";
			this.Manv.MinimumWidth = 8;
			this.Manv.Name = "Manv";
			this.Manv.ReadOnly = true;
			this.Manv.Width = 150;
			// 
			// Tennv
			// 
			this.Tennv.DataPropertyName = "Tennv";
			this.Tennv.HeaderText = "Tên NV";
			this.Tennv.MinimumWidth = 8;
			this.Tennv.Name = "Tennv";
			this.Tennv.ReadOnly = true;
			this.Tennv.Width = 150;
			// 
			// Gioitinh
			// 
			this.Gioitinh.DataPropertyName = "Gioitinh";
			this.Gioitinh.HeaderText = "Sex";
			this.Gioitinh.MinimumWidth = 8;
			this.Gioitinh.Name = "Gioitinh";
			this.Gioitinh.ReadOnly = true;
			this.Gioitinh.Visible = false;
			this.Gioitinh.Width = 150;
			// 
			// Ngaysinh
			// 
			this.Ngaysinh.DataPropertyName = "Ngaysinh";
			this.Ngaysinh.HeaderText = "Ngày Sinh";
			this.Ngaysinh.MinimumWidth = 8;
			this.Ngaysinh.Name = "Ngaysinh";
			this.Ngaysinh.ReadOnly = true;
			this.Ngaysinh.Width = 150;
			// 
			// Quequan
			// 
			this.Quequan.DataPropertyName = "Quequan";
			this.Quequan.HeaderText = "Quê Quán";
			this.Quequan.MinimumWidth = 8;
			this.Quequan.Name = "Quequan";
			this.Quequan.ReadOnly = true;
			this.Quequan.Width = 150;
			// 
			// SDT
			// 
			this.SDT.DataPropertyName = "SDT";
			this.SDT.HeaderText = "SDT";
			this.SDT.MinimumWidth = 8;
			this.SDT.Name = "SDT";
			this.SDT.ReadOnly = true;
			this.SDT.Width = 150;
			// 
			// Chucvu
			// 
			this.Chucvu.DataPropertyName = "Chucvu";
			this.Chucvu.HeaderText = "Chức Vụ";
			this.Chucvu.MinimumWidth = 8;
			this.Chucvu.Name = "Chucvu";
			this.Chucvu.ReadOnly = true;
			this.Chucvu.Width = 150;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Giới Tính";
			this.Column1.HeaderText = "Giới Tính";
			this.Column1.MinimumWidth = 8;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 150;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(26, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã NV";
			// 
			// txtma
			// 
			this.txtma.BackColor = System.Drawing.SystemColors.Window;
			this.txtma.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtma.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtma.Location = new System.Drawing.Point(126, 103);
			this.txtma.Name = "txtma";
			this.txtma.Size = new System.Drawing.Size(200, 21);
			this.txtma.TabIndex = 0;
			// 
			// txtten
			// 
			this.txtten.BackColor = System.Drawing.SystemColors.Window;
			this.txtten.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtten.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtten.Location = new System.Drawing.Point(126, 140);
			this.txtten.Name = "txtten";
			this.txtten.Size = new System.Drawing.Size(200, 21);
			this.txtten.TabIndex = 1;
			this.txtten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtten_KeyPress);
			// 
			// txtque
			// 
			this.txtque.BackColor = System.Drawing.SystemColors.Window;
			this.txtque.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtque.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtque.Location = new System.Drawing.Point(126, 181);
			this.txtque.Name = "txtque";
			this.txtque.Size = new System.Drawing.Size(200, 21);
			this.txtque.TabIndex = 2;
			// 
			// txtsdt
			// 
			this.txtsdt.BackColor = System.Drawing.SystemColors.Window;
			this.txtsdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsdt.Location = new System.Drawing.Point(458, 103);
			this.txtsdt.Name = "txtsdt";
			this.txtsdt.Size = new System.Drawing.Size(179, 21);
			this.txtsdt.TabIndex = 3;
			this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.btnreset);
			this.groupBox1.Controls.Add(this.btntimkiem);
			this.groupBox1.Controls.Add(this.btnhuy);
			this.groupBox1.Controls.Add(this.btnghi);
			this.groupBox1.Controls.Add(this.btnxoa);
			this.groupBox1.Controls.Add(this.btnsua);
			this.groupBox1.Controls.Add(this.btnthem);
			this.groupBox1.Controls.Add(this.dtpns);
			this.groupBox1.Controls.Add(this.cbochucvu);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtsdt);
			this.groupBox1.Controls.Add(this.txttimkiem);
			this.groupBox1.Controls.Add(this.txtma);
			this.groupBox1.Controls.Add(this.txtten);
			this.groupBox1.Controls.Add(this.txtque);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Location = new System.Drawing.Point(0, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1010, 249);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.imageList1;
			this.label5.Location = new System.Drawing.Point(458, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(179, 10);
			this.label5.TabIndex = 21;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "horizontal-rule.png");
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ImageIndex = 0;
			this.label4.ImageList = this.imageList1;
			this.label4.Location = new System.Drawing.Point(126, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 10);
			this.label4.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.imageList1;
			this.label3.Location = new System.Drawing.Point(126, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 10);
			this.label3.TabIndex = 19;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radnu);
			this.groupBox2.Controls.Add(this.radnam);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.groupBox2.Location = new System.Drawing.Point(623, 146);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(150, 56);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Giới Tính";
			// 
			// radnu
			// 
			this.radnu.AutoSize = true;
			this.radnu.Location = new System.Drawing.Point(81, 19);
			this.radnu.Name = "radnu";
			this.radnu.Size = new System.Drawing.Size(57, 24);
			this.radnu.TabIndex = 8;
			this.radnu.TabStop = true;
			this.radnu.Text = "Nữ";
			this.radnu.UseVisualStyleBackColor = true;
			// 
			// radnam
			// 
			this.radnam.AutoSize = true;
			this.radnam.Location = new System.Drawing.Point(6, 19);
			this.radnam.Name = "radnam";
			this.radnam.Size = new System.Drawing.Size(69, 24);
			this.radnam.TabIndex = 7;
			this.radnam.TabStop = true;
			this.radnam.Text = "Nam";
			this.radnam.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.imageList1;
			this.label2.Location = new System.Drawing.Point(126, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 10);
			this.label2.TabIndex = 18;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.ImageIndex = 6;
			this.button1.ImageList = this.imageList2;
			this.button1.Location = new System.Drawing.Point(721, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 43);
			this.button1.TabIndex = 16;
			this.button1.Text = "Xuất Excel";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnreset
			// 
			this.btnreset.BackColor = System.Drawing.Color.White;
			this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnreset.FlatAppearance.BorderSize = 0;
			this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnreset.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnreset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnreset.ImageIndex = 4;
			this.btnreset.ImageList = this.imageList2;
			this.btnreset.Location = new System.Drawing.Point(889, 45);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(121, 51);
			this.btnreset.TabIndex = 12;
			this.btnreset.Text = "Reset";
			this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnreset.UseVisualStyleBackColor = false;
			this.btnreset.Click += new System.EventHandler(this.btbreset_Click);
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "cross (2).png");
			this.imageList2.Images.SetKeyName(1, "folder-download.png");
			this.imageList2.Images.SetKeyName(2, "wrench-alt.png");
			this.imageList2.Images.SetKeyName(3, "trash.png");
			this.imageList2.Images.SetKeyName(4, "refresh.png");
			this.imageList2.Images.SetKeyName(5, "plus.png");
			this.imageList2.Images.SetKeyName(6, "printing.png");
			// 
			// btntimkiem
			// 
			this.btntimkiem.BackColor = System.Drawing.Color.White;
			this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntimkiem.ImageIndex = 0;
			this.btntimkiem.ImageList = this.imageList3;
			this.btntimkiem.Location = new System.Drawing.Point(688, 25);
			this.btntimkiem.Name = "btntimkiem";
			this.btntimkiem.Size = new System.Drawing.Size(49, 33);
			this.btntimkiem.TabIndex = 10;
			this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btntimkiem.UseVisualStyleBackColor = false;
			this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
			// 
			// imageList3
			// 
			this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
			this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList3.Images.SetKeyName(0, "search (1).png");
			// 
			// btnhuy
			// 
			this.btnhuy.BackColor = System.Drawing.Color.White;
			this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnhuy.FlatAppearance.BorderSize = 0;
			this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnhuy.ImageIndex = 0;
			this.btnhuy.ImageList = this.imageList2;
			this.btnhuy.Location = new System.Drawing.Point(889, 147);
			this.btnhuy.Name = "btnhuy";
			this.btnhuy.Size = new System.Drawing.Size(121, 51);
			this.btnhuy.TabIndex = 14;
			this.btnhuy.Text = "Hủy";
			this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnhuy.UseVisualStyleBackColor = false;
			this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
			// 
			// btnghi
			// 
			this.btnghi.BackColor = System.Drawing.Color.White;
			this.btnghi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnghi.FlatAppearance.BorderSize = 0;
			this.btnghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnghi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnghi.ImageIndex = 1;
			this.btnghi.ImageList = this.imageList2;
			this.btnghi.Location = new System.Drawing.Point(889, 96);
			this.btnghi.Name = "btnghi";
			this.btnghi.Size = new System.Drawing.Size(121, 51);
			this.btnghi.TabIndex = 13;
			this.btnghi.Text = "Lưu";
			this.btnghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnghi.UseVisualStyleBackColor = false;
			this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
			// 
			// btnxoa
			// 
			this.btnxoa.BackColor = System.Drawing.Color.White;
			this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnxoa.FlatAppearance.BorderSize = 0;
			this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnxoa.ImageIndex = 3;
			this.btnxoa.ImageList = this.imageList2;
			this.btnxoa.Location = new System.Drawing.Point(889, 198);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(121, 51);
			this.btnxoa.TabIndex = 15;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnxoa.UseVisualStyleBackColor = false;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// btnsua
			// 
			this.btnsua.BackColor = System.Drawing.Color.White;
			this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnsua.FlatAppearance.BorderSize = 0;
			this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnsua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnsua.ImageIndex = 2;
			this.btnsua.ImageList = this.imageList2;
			this.btnsua.Location = new System.Drawing.Point(889, 147);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(121, 51);
			this.btnsua.TabIndex = 10;
			this.btnsua.Text = "Sửa";
			this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnsua.UseVisualStyleBackColor = false;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
			// 
			// btnthem
			// 
			this.btnthem.BackColor = System.Drawing.Color.White;
			this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnthem.FlatAppearance.BorderSize = 0;
			this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnthem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnthem.ImageIndex = 5;
			this.btnthem.ImageList = this.imageList2;
			this.btnthem.Location = new System.Drawing.Point(889, 96);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(121, 51);
			this.btnthem.TabIndex = 9;
			this.btnthem.Text = "Thêm";
			this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnthem.UseVisualStyleBackColor = false;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// dtpns
			// 
			this.dtpns.CustomFormat = "dd/MM/yyyy";
			this.dtpns.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpns.Location = new System.Drawing.Point(458, 186);
			this.dtpns.Name = "dtpns";
			this.dtpns.Size = new System.Drawing.Size(146, 28);
			this.dtpns.TabIndex = 5;
			// 
			// cbochucvu
			// 
			this.cbochucvu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbochucvu.FormattingEnabled = true;
			this.cbochucvu.Items.AddRange(new object[] {
			"Quản lý",
			"Nhân viên"});
			this.cbochucvu.Location = new System.Drawing.Point(458, 142);
			this.cbochucvu.Name = "cbochucvu";
			this.cbochucvu.Size = new System.Drawing.Size(146, 28);
			this.cbochucvu.TabIndex = 4;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.White;
			this.label20.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label20.Location = new System.Drawing.Point(360, 193);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(84, 20);
			this.label20.TabIndex = 1;
			this.label20.Text = "Ngày Sinh";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.White;
			this.label19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label19.Location = new System.Drawing.Point(360, 110);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(44, 20);
			this.label19.TabIndex = 1;
			this.label19.Text = "SDT";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.White;
			this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label16.Location = new System.Drawing.Point(26, 188);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(83, 20);
			this.label16.TabIndex = 1;
			this.label16.Text = "Quê Quán";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.White;
			this.label17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label17.Location = new System.Drawing.Point(360, 147);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(102, 26);
			this.label17.TabIndex = 1;
			this.label17.Text = "Chức Vụ";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.White;
			this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label15.Location = new System.Drawing.Point(26, 147);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(68, 20);
			this.label15.TabIndex = 1;
			this.label15.Text = "Tên NV";
			// 
			// txttimkiem
			// 
			this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttimkiem.Location = new System.Drawing.Point(314, 25);
			this.txttimkiem.Name = "txttimkiem";
			this.txttimkiem.Size = new System.Drawing.Size(376, 28);
			this.txttimkiem.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(1010, 39);
			this.label8.TabIndex = 5;
			this.label8.Text = "Thông Tin Nhân Viên";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorProviderThongtin
			// 
			this.errorProviderThongtin.ContainerControl = this;
			// 
			// Thongtinnv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1010, 564);
			this.Controls.Add(this.dgvxuat);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label8);
			this.Name = "Thongtinnv";
			this.Text = "Thongtinnv";
			((System.ComponentModel.ISupportInitialize)(this.dgvxuat)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderThongtin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvxuat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtma;
		private System.Windows.Forms.TextBox txtten;
		private System.Windows.Forms.TextBox txtque;
		private System.Windows.Forms.TextBox txtsdt;
		private System.Windows.Forms.ComboBox cbochucvu;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radnam;
		private System.Windows.Forms.DateTimePicker dtpns;
		private System.Windows.Forms.RadioButton radnu;
		private System.Windows.Forms.TextBox txttimkiem;
		private System.Windows.Forms.Button btnhuy;
		private System.Windows.Forms.Button btnghi;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Button btnsua;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btntimkiem;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ErrorProvider errorProviderThongtin;
		private System.Windows.Forms.Button btnreset;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ImageList imageList3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tennv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
		private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}