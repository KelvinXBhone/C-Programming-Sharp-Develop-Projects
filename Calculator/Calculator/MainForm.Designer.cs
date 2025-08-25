/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 11/30/2023
 * Time: 2:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculator
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.btnSubstract = new System.Windows.Forms.Button();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.labelTopic = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(71, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Number 1";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(71, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Number 2";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(248, 91);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(163, 20);
			this.txtNum1.TabIndex = 2;
			this.txtNum1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(248, 132);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(163, 20);
			this.txtNum2.TabIndex = 3;
			this.txtNum2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// lblOutput
			// 
			this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput.Location = new System.Drawing.Point(109, 178);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(328, 46);
			this.lblOutput.TabIndex = 4;
			this.lblOutput.Text = "Output ";
			this.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(42, 244);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(81, 50);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnDivide
			// 
			this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDivide.Location = new System.Drawing.Point(405, 245);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(81, 50);
			this.btnDivide.TabIndex = 6;
			this.btnDivide.Text = "/";
			this.btnDivide.UseVisualStyleBackColor = true;
			this.btnDivide.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnSubstract
			// 
			this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubstract.Location = new System.Drawing.Point(173, 245);
			this.btnSubstract.Name = "btnSubstract";
			this.btnSubstract.Size = new System.Drawing.Size(81, 50);
			this.btnSubstract.TabIndex = 8;
			this.btnSubstract.Text = "-";
			this.btnSubstract.UseVisualStyleBackColor = true;
			this.btnSubstract.Click += new System.EventHandler(this.Button4Click);
			// 
			// btnMultiply
			// 
			this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiply.Location = new System.Drawing.Point(293, 245);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.Size = new System.Drawing.Size(81, 50);
			this.btnMultiply.TabIndex = 7;
			this.btnMultiply.Text = "*";
			this.btnMultiply.UseVisualStyleBackColor = true;
			this.btnMultiply.Click += new System.EventHandler(this.Button3Click);
			// 
			// labelTopic
			// 
			this.labelTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTopic.Location = new System.Drawing.Point(110, 7);
			this.labelTopic.Name = "labelTopic";
			this.labelTopic.Size = new System.Drawing.Size(340, 57);
			this.labelTopic.TabIndex = 9;
			this.labelTopic.Text = "Khun Calculator";
			this.labelTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 335);
			this.Controls.Add(this.labelTopic);
			this.Controls.Add(this.btnSubstract);
			this.Controls.Add(this.btnMultiply);
			this.Controls.Add(this.btnDivide);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelTopic;
		private System.Windows.Forms.Button btnSubstract;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
