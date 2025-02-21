namespace BTL
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.label1 = new System.Windows.Forms.Label();
			this.txttongtien = new System.Windows.Forms.TextBox();
			this.dtpdate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txttimkiem = new System.Windows.Forms.TextBox();
			this.dgv2 = new System.Windows.Forms.DataGridView();
			this.dgv1 = new System.Windows.Forms.DataGridView();
			this.button3 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(161, 580);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 22);
			this.label1.TabIndex = 20;
			this.label1.Text = "Tổng tiền";
			// 
			// txttongtien
			// 
			this.txttongtien.BackColor = System.Drawing.SystemColors.Info;
			this.txttongtien.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txttongtien.Location = new System.Drawing.Point(262, 580);
			this.txttongtien.Multiline = true;
			this.txttongtien.Name = "txttongtien";
			this.txttongtien.Size = new System.Drawing.Size(178, 22);
			this.txttongtien.TabIndex = 19;
			// 
			// dtpdate
			// 
			this.dtpdate.CustomFormat = "dd/MM/yyyy hh:mm:ss";
			this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpdate.Location = new System.Drawing.Point(949, 172);
			this.dtpdate.Name = "dtpdate";
			this.dtpdate.Size = new System.Drawing.Size(243, 24);
			this.dtpdate.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(805, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Ngày thanh toán";
			// 
			// txttimkiem
			// 
			this.txttimkiem.Location = new System.Drawing.Point(607, 46);
			this.txttimkiem.Multiline = true;
			this.txttimkiem.Name = "txttimkiem";
			this.txttimkiem.Size = new System.Drawing.Size(191, 34);
			this.txttimkiem.TabIndex = 15;
			// 
			// dgv2
			// 
			this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv2.Location = new System.Drawing.Point(165, 340);
			this.dgv2.Margin = new System.Windows.Forms.Padding(4);
			this.dgv2.Name = "dgv2";
			this.dgv2.RowHeadersWidth = 51;
			this.dgv2.Size = new System.Drawing.Size(867, 185);
			this.dgv2.TabIndex = 14;
			// 
			// dgv1
			// 
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.Location = new System.Drawing.Point(442, 117);
			this.dgv1.Margin = new System.Windows.Forms.Padding(4);
			this.dgv1.Name = "dgv1";
			this.dgv1.RowHeadersWidth = 51;
			this.dgv1.Size = new System.Drawing.Size(202, 168);
			this.dgv1.TabIndex = 13;
			this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick_1);
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ImageIndex = 2;
			this.button3.ImageList = this.imageList1;
			this.button3.Location = new System.Drawing.Point(646, 564);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 74);
			this.button3.TabIndex = 23;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icon search.jpg");
			this.imageList1.Images.SetKeyName(1, "icons8-logout-40.png");
			this.imageList1.Images.SetKeyName(2, "icons8-excel-48.png");
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ImageIndex = 1;
			this.button2.ImageList = this.imageList1;
			this.button2.Location = new System.Drawing.Point(1178, 580);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 91);
			this.button2.TabIndex = 22;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(461, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 77);
			this.button1.TabIndex = 21;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(1353, 700);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txttongtien);
			this.Controls.Add(this.dtpdate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txttimkiem);
			this.Controls.Add(this.dgv2);
			this.Controls.Add(this.dgv1);
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lịch sử hóa đơn";
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txttongtien;
		private System.Windows.Forms.DateTimePicker dtpdate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txttimkiem;
		private System.Windows.Forms.DataGridView dgv2;
		private System.Windows.Forms.DataGridView dgv1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
    }
}