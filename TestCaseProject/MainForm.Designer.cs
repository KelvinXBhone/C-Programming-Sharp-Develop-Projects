/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 2/8/2024
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TestCaseProject
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
			this.txtInput = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.AddBtn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(55, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "EnterName";
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(248, 54);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(235, 20);
			this.txtInput.TabIndex = 1;
			// 
			// lblOutput
			// 
			this.lblOutput.Location = new System.Drawing.Point(55, 123);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(169, 30);
			this.lblOutput.TabIndex = 2;
			this.lblOutput.Text = "index=";
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(55, 207);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(153, 49);
			this.AddBtn.TabIndex = 3;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtnClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(290, 207);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 49);
			this.button1.TabIndex = 4;
			this.button1.Text = "To Dynamic Form";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 282);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "TestCaseProject";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label label1;
	}
}
