/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 12/7/2023
 * Time: 3:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Area_Project_2
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoTriangle = new System.Windows.Forms.RadioButton();
			this.rdoCircle = new System.Windows.Forms.RadioButton();
			this.rdoRectangle = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtlength = new System.Windows.Forms.TextBox();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.btnCaculate = new System.Windows.Forms.Button();
			this.lblOutput = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoTriangle);
			this.groupBox1.Controls.Add(this.rdoCircle);
			this.groupBox1.Controls.Add(this.rdoRectangle);
			this.groupBox1.Location = new System.Drawing.Point(26, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(514, 106);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Choose A Shape";
			// 
			// rdoTriangle
			// 
			this.rdoTriangle.Location = new System.Drawing.Point(402, 44);
			this.rdoTriangle.Name = "rdoTriangle";
			this.rdoTriangle.Size = new System.Drawing.Size(77, 45);
			this.rdoTriangle.TabIndex = 2;
			this.rdoTriangle.TabStop = true;
			this.rdoTriangle.Text = "Triangle";
			this.rdoTriangle.UseVisualStyleBackColor = true;
			// 
			// rdoCircle
			// 
			this.rdoCircle.Location = new System.Drawing.Point(220, 39);
			this.rdoCircle.Name = "rdoCircle";
			this.rdoCircle.Size = new System.Drawing.Size(83, 54);
			this.rdoCircle.TabIndex = 1;
			this.rdoCircle.TabStop = true;
			this.rdoCircle.Text = "Circle";
			this.rdoCircle.UseVisualStyleBackColor = true;
			// 
			// rdoRectangle
			// 
			this.rdoRectangle.Location = new System.Drawing.Point(29, 44);
			this.rdoRectangle.Name = "rdoRectangle";
			this.rdoRectangle.Size = new System.Drawing.Size(87, 37);
			this.rdoRectangle.TabIndex = 0;
			this.rdoRectangle.TabStop = true;
			this.rdoRectangle.Text = "Rectangle";
			this.rdoRectangle.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(100, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Length";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label2.Location = new System.Drawing.Point(100, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 31);
			this.label2.TabIndex = 2;
			this.label2.Text = "Width";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// txtlength
			// 
			this.txtlength.Location = new System.Drawing.Point(284, 179);
			this.txtlength.Name = "txtlength";
			this.txtlength.Size = new System.Drawing.Size(186, 20);
			this.txtlength.TabIndex = 3;
			// 
			// txtWidth
			// 
			this.txtWidth.Location = new System.Drawing.Point(284, 236);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(186, 20);
			this.txtWidth.TabIndex = 4;
			// 
			// btnCaculate
			// 
			this.btnCaculate.Location = new System.Drawing.Point(55, 285);
			this.btnCaculate.Name = "btnCaculate";
			this.btnCaculate.Size = new System.Drawing.Size(191, 42);
			this.btnCaculate.TabIndex = 5;
			this.btnCaculate.Text = "Caculate";
			this.btnCaculate.UseVisualStyleBackColor = true;
			this.btnCaculate.Click += new System.EventHandler(this.BtnCaculateClick);
			// 
			// lblOutput
			// 
			this.lblOutput.Location = new System.Drawing.Point(301, 285);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(191, 42);
			this.lblOutput.TabIndex = 6;
			this.lblOutput.Text = "Output";
			this.lblOutput.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 339);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.btnCaculate);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.txtlength);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Area_Project_2";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button lblOutput;
		private System.Windows.Forms.Button btnCaculate;
		private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.TextBox txtlength;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdoRectangle;
		private System.Windows.Forms.RadioButton rdoCircle;
		private System.Windows.Forms.RadioButton rdoTriangle;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
