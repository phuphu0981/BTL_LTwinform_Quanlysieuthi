namespace BTL
{
	partial class Form6
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
			this.txtso = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txttenquatang = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dgv1 = new System.Windows.Forms.DataGridView();
			this.Random = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button4 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtso
			// 
			this.txtso.Location = new System.Drawing.Point(372, 163);
			this.txtso.Name = "txtso";
			this.txtso.Size = new System.Drawing.Size(100, 22);
			this.txtso.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(249, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Số ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(246, 209);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "Tên quà tặng";
			// 
			// txttenquatang
			// 
			this.txttenquatang.Location = new System.Drawing.Point(372, 203);
			this.txttenquatang.Name = "txttenquatang";
			this.txttenquatang.Size = new System.Drawing.Size(100, 22);
			this.txttenquatang.TabIndex = 15;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(983, 321);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 34);
			this.button3.TabIndex = 13;
			this.button3.Text = "Xóa";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(983, 246);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 31);
			this.button2.TabIndex = 12;
			this.button2.Text = "Sửa";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(983, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 11;
			this.button1.Text = "Thêm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// dgv1
			// 
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.Location = new System.Drawing.Point(496, 157);
			this.dgv1.Name = "dgv1";
			this.dgv1.RowHeadersWidth = 51;
			this.dgv1.RowTemplate.Height = 24;
			this.dgv1.Size = new System.Drawing.Size(348, 198);
			this.dgv1.TabIndex = 10;
			this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
			// 
			// Random
			// 
			this.Random.AutoSize = true;
			this.Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Random.Location = new System.Drawing.Point(610, 410);
			this.Random.Name = "Random";
			this.Random.Size = new System.Drawing.Size(83, 22);
			this.Random.TabIndex = 19;
			this.Random.Text = "Random";
			// 
			// button5
			// 
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.ImageIndex = 2;
			this.button5.ImageList = this.imageList1;
			this.button5.Location = new System.Drawing.Point(970, 536);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(111, 91);
			this.button5.TabIndex = 20;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icons8-random-48.png");
			this.imageList1.Images.SetKeyName(1, "icons8-excel-48.png");
			this.imageList1.Images.SetKeyName(2, "icons8-logout-40.png");
			// 
			// button4
			// 
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ImageIndex = 0;
			this.button4.ImageList = this.imageList1;
			this.button4.Location = new System.Drawing.Point(602, 450);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 103);
			this.button4.TabIndex = 14;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// button6
			// 
			this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.ImageIndex = 1;
			this.button6.ImageList = this.imageList1;
			this.button6.Location = new System.Drawing.Point(814, 539);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 88);
			this.button6.TabIndex = 21;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(1217, 683);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.Random);
			this.Controls.Add(this.txtso);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txttenquatang);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgv1);
			this.Name = "Form6";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quà tặng";
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtso;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txttenquatang;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dgv1;
		private System.Windows.Forms.Label Random;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ImageList imageList1;
    }
}