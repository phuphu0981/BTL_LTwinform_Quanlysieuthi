namespace BTL
{
	partial class frmHangHoa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
			this.btnSave = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOut = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnUndo = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtMaSP = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtXuatXu = new System.Windows.Forms.TextBox();
			this.cboNcc = new System.Windows.Forms.ComboBox();
			this.txtIn = new System.Windows.Forms.TextBox();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.txtSL = new System.Windows.Forms.TextBox();
			this.txtDv = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.dtpHsd = new System.Windows.Forms.DateTimePicker();
			this.cboLoai = new System.Windows.Forms.ComboBox();
			this.dgvMain = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTk = new System.Windows.Forms.TextBox();
			this.btnTk = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.ImageIndex = 1;
			this.btnSave.ImageList = this.imageList1;
			this.btnSave.Location = new System.Drawing.Point(194, 70);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(165, 48);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icons8-excel-48.png");
			this.imageList1.Images.SetKeyName(1, "icons8-save.gif");
			this.imageList1.Images.SetKeyName(2, "icons8-close-16.png");
			this.imageList1.Images.SetKeyName(3, "icons8-cancel-100.png");
			this.imageList1.Images.SetKeyName(4, "icons8-delete-64.png");
			this.imageList1.Images.SetKeyName(5, "icons8-add-64.png");
			this.imageList1.Images.SetKeyName(6, "icons8-edit-64.png");
			this.imageList1.Images.SetKeyName(7, "icons8-reload-50.png");
			this.imageList1.Images.SetKeyName(8, "icons8-close-64.png");
			this.imageList1.Images.SetKeyName(9, "icons8-find-48.png");
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.ImageIndex = 4;
			this.btnDelete.ImageList = this.imageList1;
			this.btnDelete.Location = new System.Drawing.Point(4, 234);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(165, 48);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.ImageIndex = 6;
			this.btnEdit.ImageList = this.imageList1;
			this.btnEdit.Location = new System.Drawing.Point(4, 152);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(165, 48);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Lấy hàng";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.ImageIndex = 3;
			this.btnCancel.ImageList = this.imageList1;
			this.btnCancel.Location = new System.Drawing.Point(194, 152);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(165, 48);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Hủy ";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOut
			// 
			this.btnOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOut.ImageIndex = 8;
			this.btnOut.ImageList = this.imageList1;
			this.btnOut.Location = new System.Drawing.Point(194, 313);
			this.btnOut.Name = "btnOut";
			this.btnOut.Size = new System.Drawing.Size(165, 48);
			this.btnOut.TabIndex = 1;
			this.btnOut.Text = "Thoát";
			this.btnOut.UseVisualStyleBackColor = true;
			this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.ImageIndex = 5;
			this.btnAdd.ImageList = this.imageList1;
			this.btnAdd.Location = new System.Drawing.Point(4, 70);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(165, 48);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.btnUndo);
			this.groupBox1.Controls.Add(this.btnExcel);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.btnOut);
			this.groupBox1.Controls.Add(this.btnEdit);
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(818, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(359, 378);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tác vụ";
			// 
			// btnUndo
			// 
			this.btnUndo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUndo.ImageIndex = 7;
			this.btnUndo.ImageList = this.imageList1;
			this.btnUndo.Location = new System.Drawing.Point(6, 312);
			this.btnUndo.Name = "btnUndo";
			this.btnUndo.Size = new System.Drawing.Size(163, 48);
			this.btnUndo.TabIndex = 3;
			this.btnUndo.Text = "Quay lại";
			this.btnUndo.UseVisualStyleBackColor = true;
			this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.AutoSize = true;
			this.btnExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.ImageIndex = 0;
			this.btnExcel.ImageList = this.imageList1;
			this.btnExcel.Location = new System.Drawing.Point(194, 234);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(165, 48);
			this.btnExcel.TabIndex = 2;
			this.btnExcel.Text = "Xuất";
			this.btnExcel.UseVisualStyleBackColor = true;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 22);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mã sản phầm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tên sản phẩm";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(446, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 22);
			this.label5.TabIndex = 3;
			this.label5.Text = "Giá nhập";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(446, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 22);
			this.label6.TabIndex = 3;
			this.label6.Text = "Giá bán";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(446, 204);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 22);
			this.label7.TabIndex = 3;
			this.label7.Text = "Số lượng ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(446, 332);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 22);
			this.label8.TabIndex = 3;
			this.label8.Text = "Đơn vị";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(446, 268);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(108, 22);
			this.label9.TabIndex = 3;
			this.label9.Text = "Hạn sử dụng";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(20, 339);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 22);
			this.label10.TabIndex = 3;
			this.label10.Text = "Xuất xứ";
			// 
			// txtMaSP
			// 
			this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaSP.Location = new System.Drawing.Point(160, 81);
			this.txtMaSP.Name = "txtMaSP";
			this.txtMaSP.Size = new System.Drawing.Size(100, 28);
			this.txtMaSP.TabIndex = 4;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(160, 145);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(241, 28);
			this.txtName.TabIndex = 4;
			// 
			// txtXuatXu
			// 
			this.txtXuatXu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtXuatXu.Location = new System.Drawing.Point(160, 337);
			this.txtXuatXu.Name = "txtXuatXu";
			this.txtXuatXu.Size = new System.Drawing.Size(121, 28);
			this.txtXuatXu.TabIndex = 4;
			// 
			// cboNcc
			// 
			this.cboNcc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboNcc.FormattingEnabled = true;
			this.cboNcc.Location = new System.Drawing.Point(160, 273);
			this.cboNcc.Name = "cboNcc";
			this.cboNcc.Size = new System.Drawing.Size(241, 28);
			this.cboNcc.TabIndex = 5;
			// 
			// txtIn
			// 
			this.txtIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIn.Location = new System.Drawing.Point(571, 76);
			this.txtIn.Name = "txtIn";
			this.txtIn.Size = new System.Drawing.Size(100, 28);
			this.txtIn.TabIndex = 4;
			// 
			// txtOut
			// 
			this.txtOut.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOut.Location = new System.Drawing.Point(571, 140);
			this.txtOut.Name = "txtOut";
			this.txtOut.Size = new System.Drawing.Size(100, 28);
			this.txtOut.TabIndex = 4;
			// 
			// txtSL
			// 
			this.txtSL.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSL.Location = new System.Drawing.Point(571, 198);
			this.txtSL.Name = "txtSL";
			this.txtSL.Size = new System.Drawing.Size(100, 28);
			this.txtSL.TabIndex = 4;
			// 
			// txtDv
			// 
			this.txtDv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDv.Location = new System.Drawing.Point(571, 330);
			this.txtDv.Name = "txtDv";
			this.txtDv.Size = new System.Drawing.Size(100, 28);
			this.txtDv.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 275);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nhà cung cấp";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(20, 211);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 22);
			this.label11.TabIndex = 3;
			this.label11.Text = "Loại hàng hóa";
			// 
			// dtpHsd
			// 
			this.dtpHsd.CustomFormat = "dd/MM/yyyy";
			this.dtpHsd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHsd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHsd.Location = new System.Drawing.Point(571, 269);
			this.dtpHsd.Name = "dtpHsd";
			this.dtpHsd.Size = new System.Drawing.Size(138, 28);
			this.dtpHsd.TabIndex = 6;
			// 
			// cboLoai
			// 
			this.cboLoai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboLoai.FormattingEnabled = true;
			this.cboLoai.Location = new System.Drawing.Point(160, 209);
			this.cboLoai.Name = "cboLoai";
			this.cboLoai.Size = new System.Drawing.Size(172, 28);
			this.cboLoai.TabIndex = 5;
			this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
			// 
			// dgvMain
			// 
			this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn1,
			this.dataGridViewTextBoxColumn2,
			this.Column10,
			this.dataGridViewTextBoxColumn3,
			this.dataGridViewTextBoxColumn4,
			this.dataGridViewTextBoxColumn5,
			this.dataGridViewTextBoxColumn6,
			this.dataGridViewTextBoxColumn7,
			this.dataGridViewTextBoxColumn8,
			this.dataGridViewTextBoxColumn9});
			this.dgvMain.Location = new System.Drawing.Point(3, 606);
			this.dgvMain.Name = "dgvMain";
			this.dgvMain.RowHeadersWidth = 51;
			this.dgvMain.RowTemplate.Height = 24;
			this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMain.Size = new System.Drawing.Size(1208, 247);
			this.dgvMain.TabIndex = 0;
			this.dgvMain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSP";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã sản phầm";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 125;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSP";
			this.dataGridViewTextBoxColumn2.HeaderText = "Tên sản phẩm";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 125;
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "LoaiSP";
			this.Column10.HeaderText = "Loại hàng hóa";
			this.Column10.MinimumWidth = 6;
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 125;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "MaNcc";
			this.dataGridViewTextBoxColumn3.HeaderText = "Mã nhà cung cấp";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 125;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "XuatXu";
			this.dataGridViewTextBoxColumn4.HeaderText = "Xuất cứ";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 125;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "GiaNhap";
			this.dataGridViewTextBoxColumn5.HeaderText = "Giá nhập";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 80;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "GiaXuat";
			this.dataGridViewTextBoxColumn6.HeaderText = "Giá bán";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 80;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "SoLuong";
			this.dataGridViewTextBoxColumn7.HeaderText = "Số lượng còn ";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 125;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "HanSuDung";
			this.dataGridViewTextBoxColumn8.HeaderText = "Hạn sử dụng";
			this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Width = 125;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "DonVi";
			this.dataGridViewTextBoxColumn9.HeaderText = "Đơn vị";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Width = 125;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtpHsd);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtDv);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtSL);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.cboLoai);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txtName);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtOut);
			this.groupBox2.Controls.Add(this.txtMaSP);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.cboNcc);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtXuatXu);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtIn);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 152);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(717, 378);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin sản phầm";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 556);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(179, 22);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tìm kiếm sản phẩm : ";
			// 
			// txtTk
			// 
			this.txtTk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTk.Location = new System.Drawing.Point(213, 554);
			this.txtTk.Name = "txtTk";
			this.txtTk.Size = new System.Drawing.Size(241, 28);
			this.txtTk.TabIndex = 4;
			// 
			// btnTk
			// 
			this.btnTk.AutoSize = true;
			this.btnTk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTk.ImageIndex = 9;
			this.btnTk.ImageList = this.imageList1;
			this.btnTk.Location = new System.Drawing.Point(514, 556);
			this.btnTk.Name = "btnTk";
			this.btnTk.Size = new System.Drawing.Size(155, 32);
			this.btnTk.TabIndex = 8;
			this.btnTk.Text = "Tìm kiếm";
			this.btnTk.UseVisualStyleBackColor = true;
			this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Tomato;
			this.label12.Location = new System.Drawing.Point(250, 38);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(705, 68);
			this.label12.TabIndex = 9;
			this.label12.Text = "THÔNG TIN SẢN PHẨM";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(818, 565);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(151, 22);
			this.lblTotal.TabIndex = 10;
			this.lblTotal.Text = "Tổng số sản phẩm";
			// 
			// frmHangHoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1208, 846);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnTk);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvMain);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHangHoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý sản phẩm";
			this.Load += new System.EventHandler(this.frmHangHoa_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOut;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtMaSP;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtXuatXu;
		private System.Windows.Forms.ComboBox cboNcc;
		private System.Windows.Forms.TextBox txtIn;
		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.TextBox txtSL;
		private System.Windows.Forms.TextBox txtDv;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker dtpHsd;
		private System.Windows.Forms.ComboBox cboLoai;
		private System.Windows.Forms.DataGridView dgvMain;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTk;
		private System.Windows.Forms.Button btnTk;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Button btnUndo;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
	}
}