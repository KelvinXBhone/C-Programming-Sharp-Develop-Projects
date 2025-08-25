/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 2/8/2024
 * Time: 2:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TestCaseProject
{
	partial class DynamicForm
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
			this.lblOutput = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(59, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Number";
			// 
			// lblOutput
			// 
			this.lblOutput.Location = new System.Drawing.Point(59, 133);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(218, 46);
			this.lblOutput.TabIndex = 1;
			this.lblOutput.Text = "Index =";
			this.lblOutput.Click += new System.EventHandler(this.LblOutputClick);
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(280, 68);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(258, 20);
			this.txtInput.TabIndex = 2;
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(211, 232);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(193, 56);
			this.AddBtn.TabIndex = 3;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtnClick);
			// 
			// DynamicForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 325);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.label1);
			this.Name = "DynamicForm";
			this.Text = "DynamicForm";
			this.Load += new System.EventHandler(this.DynamicFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Label label1;
	}
}
