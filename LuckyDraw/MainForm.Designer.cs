/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 12/14/2023
 * Time: 3:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LuckyDraw
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
			this.btn = new System.Windows.Forms.Button();
			this.lblOutput = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(148, 226);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(165, 60);
			this.btn.TabIndex = 0;
			this.btn.Text = "Test Your Luck !";
			this.btn.UseVisualStyleBackColor = true;
			this.btn.Click += new System.EventHandler(this.BtnClick);
			// 
			// lblOutput
			// 
			this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput.Location = new System.Drawing.Point(125, 167);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(218, 56);
			this.lblOutput.TabIndex = 1;
			this.lblOutput.Text = "Test Your Luck";
			this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(223, 48);
			this.label2.TabIndex = 2;
			this.label2.Text = "Your Lucky Number is";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Visible = false;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// txtNum
			// 
			this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNum.Location = new System.Drawing.Point(250, 101);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(189, 22);
			this.txtNum.TabIndex = 3;
			this.txtNum.Visible = false;
			this.txtNum.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 298);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.btn);
			this.Name = "MainForm";
			this.Text = "LuckyDraw";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button btn;
	}
}
