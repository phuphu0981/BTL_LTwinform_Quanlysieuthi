using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.custom
{
	[DefaultEvent("_TextChanged")]
	public partial class CustomTextBox : UserControl
	{
		
		public CustomTextBox()
		{
			InitializeComponent();
		}
	
		
			public event EventHandler _TextChanged;

			private void textBox1_TextChanged(object sender, EventArgs e)
			{
				if (_TextChanged != null)
				{
					_TextChanged.Invoke(sender, e);
				}
			}
			private Color borderColor = Color.MediumSlateBlue;
			private int borderSize = 2;
			private bool underlinedStyle = false;
			private Color borderFocusColor = Color.HotPink;
			private bool isFocused = false;

			private int borderRadius = 0;
			private Color placeHodercolor = Color.DarkGray;
			private string Placeholdertext = "";
			private bool isPlaceholder = false;
			private bool isPasswordchar = false;


			[Category("custom")]
			public Color BorderColor
			{
				get => borderColor;
				set
				{
					borderColor = value;
					this.Invalidate();
				}
			}


			[Category("custom")]
			public int BorderSize
			{
				get => borderSize;
				set
				{
					borderSize = value;
					this.Invalidate();
				}
			}

			[Category("custom")]
			public bool Passworchar
			{
				get
				{ return textBox1.UseSystemPasswordChar; }
				set
				{
					
					textBox1.UseSystemPasswordChar = value;
				}
			}

			[Category("custom")]
			public bool MultyLine
			{
				get
				{
					return textBox1.Multiline;
				}
				set
				{
					textBox1.Multiline = value;
				}
			}


			[Category("custom")]
			public string Placeholdertext1
			{
				get
				{
					return Placeholdertext;
				}
				set
				{
					Placeholdertext = value;
					textBox1.Text = "";
					SetPlaceholder();

				}
			}


			[Category("custom")]
			public override Color BackColor
			{
				get => base.BackColor; set
				{
					base.BackColor = value;
					textBox1.BackColor = value;
				}
			}


			[Category("custom")]
			public override Color ForeColor
			{
				get => base.ForeColor; set
				{
					base.ForeColor = value;
					textBox1.ForeColor = value;
				}
			}


			[Category("custom")]
			public override Font Font
			{
				get => base.Font;
				set
				{
					base.Font = value;
					textBox1.Font = value;
					if (this.DesignMode)
					{
						UpdateControlHeight();
					}
				}
			}


			[Category("custom")]
			public string Texts
			{

				get
				{
					if (isPlaceholder) return "";
					else return textBox1.Text;
				}
				set
				{
					textBox1.Text = value;
					SetPlaceholder();
				}
			}


			[Category("custom")]
			public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }


			[Category("custom")]
			public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }


			[Category("custom")]
			public int BorderRadius
			{
				get => borderRadius; set
				{
					borderRadius = value;
					this.Invalidate();
				}
			}


			[Category("custom")]
			public Color PlaceHodercolor1
			{
				get => placeHodercolor; set
				{
					placeHodercolor = value;
					if (isPlaceholder) textBox1.ForeColor = value;
				}
			}


			private void SetPlaceholder()
			{
				if (string.IsNullOrWhiteSpace(textBox1.Text) && Placeholdertext != "")
				{
					isPlaceholder = true;
					textBox1.Text = Placeholdertext;
					textBox1.ForeColor = placeHodercolor;
					if (isPasswordchar)
					{
						textBox1.UseSystemPasswordChar = false;
					}
				}
			}

			private void RemovePlaceholder()
			{
				if (string.IsNullOrWhiteSpace(textBox1.Text) && Placeholdertext1 != "")
				{
					isPlaceholder = false;
					textBox1.Text = "";
					textBox1.ForeColor = this.ForeColor;
					if (isPasswordchar)
					{
						textBox1.UseSystemPasswordChar = true;
					}
				}
			}

			//Private methods
			private void UpdateControlHeight()
			{
				if (textBox1.Multiline == false)
				{
					int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
					textBox1.Multiline = true;
					textBox1.MinimumSize = new Size(0, txtHeight);
					textBox1.Multiline = false;

					this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
				}
			}
			//Overridden methods

			protected override void OnPaint(PaintEventArgs e)
			{
				base.OnPaint(e);
				Graphics graph = e.Graphics;
				if (borderRadius > 1)
				{
					var rectBorderSmooth = this.ClientRectangle;
					var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
					int smoothSize = borderSize > 0 ? borderSize : 1;

					using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
					using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
					using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
					using (Pen penBorder = new Pen(borderColor, borderSize))
					{
						this.Region = new Region(pathBorderSmooth);
						if (borderRadius > 15) SetTextBoxRoundedRegion();
						graph.SmoothingMode = SmoothingMode.AntiAlias;
						penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
						if (isFocused) penBorder.Color = BorderFocusColor;//Set Border color in focus. Otherwise, normal border color

						if (underlinedStyle)
						{ //Line Style
							graph.DrawPath(penBorderSmooth, pathBorderSmooth);
							graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
							graph.SmoothingMode = SmoothingMode.None;
						}
						else //Normal Style
						{
							graph.DrawPath(penBorderSmooth, pathBorderSmooth);
							graph.DrawPath(penBorder, pathBorder);

						}
					}

				}
				else
				{
					using (Pen penBorder = new Pen(borderColor, borderSize))
					{
						//draw border
						this.Region = new Region(this.ClientRectangle);
						penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
						if (isFocused) penBorder.Color = BorderFocusColor;//Set Border color in focus. Otherwise, normal border color

						if (underlinedStyle) //Line Style
							graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
						else //Normal Style
							graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
					}
				}

			}

			private void SetTextBoxRoundedRegion()
			{
				GraphicsPath pathTxt;
				if (MultyLine)
				{
					pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
					textBox1.Region = new Region(pathTxt);
				}
				else
				{
					pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
					textBox1.Region = new Region(pathTxt);
				}

			}

			private GraphicsPath GetFigurePath(Rectangle rect, int radius)
			{
				GraphicsPath path = new GraphicsPath();
				float curversize = radius * 2F;

				path.StartFigure();
				path.AddArc(rect.X, rect.Y, curversize, curversize, 180, 90);
				path.AddArc(rect.Right - curversize, rect.Y, curversize, curversize, 270, 90);
				path.AddArc(rect.Right - curversize, rect.Bottom - curversize, curversize, curversize, 0, 90);
				path.AddArc(rect.X, rect.Bottom - curversize, curversize, curversize, 90, 90);
				path.CloseFigure();
				return path;

			}

			protected override void OnResize(EventArgs e)
			{
				base.OnResize(e);
				if (this.DesignMode)
					UpdateControlHeight();
			}

			protected override void OnLoad(EventArgs e)
			{
				base.OnLoad(e);
				UpdateControlHeight();
			}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{
			if(_TextChanged != null)
			{
				_TextChanged.Invoke(sender, e);
			}
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			isFocused = true;
			this.Invalidate();
			SetPlaceholder();
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			isFocused = false;
			this.Invalidate();
			RemovePlaceholder();
		}

		private void CustomTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.OnKeyPress(e);
		}
	}
}
