﻿namespace BTL.custom
{
	partial class CustomTextBox
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(10, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(230, 19);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// CustomTextBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "CustomTextBox";
			this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.Size = new System.Drawing.Size(250, 30);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomTextBox_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
	}
}
