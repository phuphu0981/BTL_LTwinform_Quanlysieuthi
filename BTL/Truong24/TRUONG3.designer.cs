namespace BTL
{
	partial class frmNcc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNcc));
			this.dgvMain = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.txtFind = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAdd = new System.Windows.Forms.TextBox();
			this.txtPN = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvMain
			// 
			this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2,
			this.Column3,
			this.Column4});
			this.dgvMain.Location = new System.Drawing.Point(-3, 514);
			this.dgvMain.Name = "dgvMain";
			this.dgvMain.RowHeadersWidth = 51;
			this.dgvMain.RowTemplate.Height = 24;
			this.dgvMain.Size = new System.Drawing.Size(1020, 225);
			this.dgvMain.TabIndex = 0;
			this.dgvMain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaNcc";
			this.Column1.HeaderText = "Mã nhà cung cấp";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 150;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenNcc";
			this.Column2.HeaderText = "Tên nhà cung cấp";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column2.Width = 200;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Sdt";
			this.Column3.HeaderText = "Thông tin liên lạc";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "DiaChi";
			this.Column4.HeaderText = "Địa chỉ";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column4.Width = 250;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 165);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã nhà cung cấp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(31, 253);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên nhà cung cấp";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 341);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 22);
			this.label3.TabIndex = 1;
			this.label3.Text = "Thông tin liên lạc";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(31, 429);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 22);
			this.label4.TabIndex = 1;
			this.label4.Text = "Địa chỉ";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.btnFind);
			this.groupBox1.Controls.Add(this.txtFind);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(642, 177);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(330, 250);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TÌM KIẾM THÔNG TIN";
			// 
			// btnFind
			// 
			this.btnFind.AutoSize = true;
			this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFind.ImageIndex = 10;
			this.btnFind.ImageList = this.imageList1;
			this.btnFind.Location = new System.Drawing.Point(110, 164);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(134, 42);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "Tìm kiếm";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icons8-find-48.png");
			this.imageList1.Images.SetKeyName(1, "icons8-close-64.png");
			this.imageList1.Images.SetKeyName(2, "icons8-reload-50.png");
			this.imageList1.Images.SetKeyName(3, "icons8-close-16.png");
			this.imageList1.Images.SetKeyName(4, "icons8-cancel-100.png");
			this.imageList1.Images.SetKeyName(5, "icons8-delete-64.png");
			this.imageList1.Images.SetKeyName(6, "icons8-add-64.png");
			this.imageList1.Images.SetKeyName(7, "icons8-edit-64.png");
			this.imageList1.Images.SetKeyName(8, "icons8-save.gif");
			this.imageList1.Images.SetKeyName(9, "icons8-excel-48.png");
			this.imageList1.Images.SetKeyName(10, "icons8-find-48.png");
			// 
			// txtFind
			// 
			this.txtFind.Location = new System.Drawing.Point(74, 101);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(204, 30);
			this.txtFind.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(47, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(257, 22);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tìm kiếm theo tên nhà cung cấp";
			// 
			// btnAdd
			// 
			this.btnAdd.AutoSize = true;
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.ImageIndex = 6;
			this.btnAdd.ImageList = this.imageList1;
			this.btnAdd.Location = new System.Drawing.Point(472, 137);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(138, 32);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.AutoSize = true;
			this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.ImageIndex = 7;
			this.btnEdit.ImageList = this.imageList1;
			this.btnEdit.Location = new System.Drawing.Point(472, 187);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(138, 32);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.AutoSize = true;
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.ImageIndex = 5;
			this.btnDelete.ImageList = this.imageList1;
			this.btnDelete.Location = new System.Drawing.Point(472, 237);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(138, 32);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = true;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.ImageIndex = 8;
			this.btnSave.ImageList = this.imageList1;
			this.btnSave.Location = new System.Drawing.Point(472, 287);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(138, 32);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.ImageIndex = 3;
			this.btnCancel.ImageList = this.imageList1;
			this.btnCancel.Location = new System.Drawing.Point(472, 337);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(138, 32);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Hủy ";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(215, 250);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(232, 30);
			this.txtName.TabIndex = 4;
			// 
			// txtAdd
			// 
			this.txtAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdd.Location = new System.Drawing.Point(215, 426);
			this.txtAdd.Name = "txtAdd";
			this.txtAdd.Size = new System.Drawing.Size(232, 30);
			this.txtAdd.TabIndex = 4;
			// 
			// txtPN
			// 
			this.txtPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPN.Location = new System.Drawing.Point(215, 338);
			this.txtPN.Name = "txtPN";
			this.txtPN.Size = new System.Drawing.Size(131, 30);
			this.txtPN.TabIndex = 4;
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(215, 162);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(122, 30);
			this.txtID.TabIndex = 4;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(638, 448);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(137, 22);
			this.lblTotal.TabIndex = 5;
			this.lblTotal.Text = "Số nhà cung cấp";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Tomato;
			this.label6.Location = new System.Drawing.Point(68, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(848, 68);
			this.label6.TabIndex = 6;
			this.label6.Text = "THÔNG TIN NHÀ CUNG CẤP";
			// 
			// btnBack
			// 
			this.btnBack.AutoSize = true;
			this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.ImageIndex = 2;
			this.btnBack.ImageList = this.imageList1;
			this.btnBack.Location = new System.Drawing.Point(472, 437);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(138, 32);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "Quay lại";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnExport
			// 
			this.btnExport.AutoSize = true;
			this.btnExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExport.ImageIndex = 9;
			this.btnExport.ImageList = this.imageList1;
			this.btnExport.Location = new System.Drawing.Point(472, 387);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(138, 32);
			this.btnExport.TabIndex = 8;
			this.btnExport.Text = "Xuất";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// frmNcc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1017, 740);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtPN);
			this.Controls.Add(this.txtAdd);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNcc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý Nhà cung cấp";
			this.Load += new System.EventHandler(this.frmNcc_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvMain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAdd;
		private System.Windows.Forms.TextBox txtPN;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}