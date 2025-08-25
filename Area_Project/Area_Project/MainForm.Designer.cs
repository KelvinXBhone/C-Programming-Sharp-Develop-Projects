/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 12/7/2023
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Area_Project
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.length = new System.Windows.Forms.Label();
			this.Width = new System.Windows.Forms.Label();
			this.lbloutput = new System.Windows.Forms.Label();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.btnCaculate = new System.Windows.Forms.Button();
			this.btnTriangle = new System.Windows.Forms.Button();
			this.tblCircle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// length
			// 
			this.length.Location = new System.Drawing.Point(48, 71);
			this.length.Name = "length";
			this.length.Size = new System.Drawing.Size(100, 32);
			this.length.TabIndex = 0;
			this.length.Text = "Length / Base / Radius";
			this.length.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.length.UseMnemonic = false;
			this.length.Click += new System.EventHandler(this.Label1Click);
			// 
			// Width
			// 
			this.Width.Location = new System.Drawing.Point(48, 129);
			this.Width.Name = "Width";
			this.Width.Size = new System.Drawing.Size(100, 23);
			this.Width.TabIndex = 1;
			this.Width.Text = "Width / Height";
			this.Width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbloutput
			// 
			this.lbloutput.Location = new System.Drawing.Point(76, 189);
			this.lbloutput.Name = "lbloutput";
			this.lbloutput.Size = new System.Drawing.Size(235, 46);
			this.lbloutput.TabIndex = 2;
			this.lbloutput.Text = "Output";
			this.lbloutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbloutput.Click += new System.EventHandler(this.LbloutputClick);
			// 
			// txtLength
			// 
			this.txtLength.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLength.Location = new System.Drawing.Point(184, 74);
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(142, 29);
			this.txtLength.TabIndex = 3;
			this.txtLength.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// txtWidth
			// 
			this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWidth.Location = new System.Drawing.Point(184, 129);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(142, 29);
			this.txtWidth.TabIndex = 4;
			this.txtWidth.TextChanged += new System.EventHandler(this.TxtwidthTextChanged);
			// 
			// btnCaculate
			// 
			this.btnCaculate.Location = new System.Drawing.Point(12, 250);
			this.btnCaculate.Name = "btnCaculate";
			this.btnCaculate.Size = new System.Drawing.Size(118, 48);
			this.btnCaculate.TabIndex = 5;
			this.btnCaculate.Text = "Caculate Rectangle";
			this.btnCaculate.UseVisualStyleBackColor = true;
			this.btnCaculate.Click += new System.EventHandler(this.BtnCaculateClick);
			// 
			// btnTriangle
			// 
			this.btnTriangle.Location = new System.Drawing.Point(148, 250);
			this.btnTriangle.Name = "btnTriangle";
			this.btnTriangle.Size = new System.Drawing.Size(112, 48);
			this.btnTriangle.TabIndex = 6;
			this.btnTriangle.Text = "Caculate Triangle";
			this.btnTriangle.UseVisualStyleBackColor = true;
			this.btnTriangle.Click += new System.EventHandler(this.BtnTriangleClick);
			// 
			// tblCircle
			// 
			this.tblCircle.Location = new System.Drawing.Point(274, 252);
			this.tblCircle.Name = "tblCircle";
			this.tblCircle.Size = new System.Drawing.Size(104, 46);
			this.tblCircle.TabIndex = 7;
			this.tblCircle.Text = "Caculate Circle";
			this.tblCircle.UseVisualStyleBackColor = true;
			this.tblCircle.Click += new System.EventHandler(this.TblCircleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 310);
			this.Controls.Add(this.tblCircle);
			this.Controls.Add(this.btnTriangle);
			this.Controls.Add(this.btnCaculate);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.txtLength);
			this.Controls.Add(this.lbloutput);
			this.Controls.Add(this.Width);
			this.Controls.Add(this.length);
			this.Name = "MainForm";
			this.Text = "Area_Project";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button tblCircle;
		private System.Windows.Forms.Button btnTriangle;
		private System.Windows.Forms.Button btnCaculate;
		private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.Label lbloutput;
		private System.Windows.Forms.Label Width;
		private System.Windows.Forms.Label length;
	}
}
