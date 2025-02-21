namespace BTL
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.pdhoadon = new System.Drawing.Printing.PrintDocument();
			this.ppdhoadon = new System.Windows.Forms.PrintPreviewDialog();
			this.SuspendLayout();
			// 
			// pdhoadon
			// 
			this.pdhoadon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdhoadon_PrintPage);
			// 
			// ppdhoadon
			// 
			this.ppdhoadon.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.ppdhoadon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.ppdhoadon.ClientSize = new System.Drawing.Size(400, 300);
			this.ppdhoadon.Enabled = true;
			this.ppdhoadon.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdhoadon.Icon")));
			this.ppdhoadon.Name = "ppdhoadon";
			this.ppdhoadon.Visible = false;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Drawing.Printing.PrintDocument pdhoadon;
		private System.Windows.Forms.PrintPreviewDialog ppdhoadon;
	}
}