/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 12/14/2023
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LeapYear
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 55);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Year";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// txtYear
			// 
			this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtYear.Location = new System.Drawing.Point(283, 88);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(197, 22);
			this.txtYear.TabIndex = 1;
			// 
			// lblOutput
			// 
			this.lblOutput.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lblOutput.Location = new System.Drawing.Point(166, 165);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(220, 28);
			this.lblOutput.TabIndex = 2;
			this.lblOutput.Text = "The Output Is Here";
			this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblOutput.Click += new System.EventHandler(this.Label2Click);
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(166, 250);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(208, 43);
			this.btnCheck.TabIndex = 3;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.BtnCheckClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 315);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "LeapYear";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.Label label1;
	}
}
