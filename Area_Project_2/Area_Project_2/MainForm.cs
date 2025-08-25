/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 12/7/2023
 * Time: 3:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Area_Project_2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnCaculateClick(object sender, EventArgs e)
		{
				float length, width, output = 0.0f;
				if (rdoRectangle.Checked){
					length = float.Parse(txtlength.Text);
					width = float.Parse(txtWidth.Text);
					output = length*width;
				}
				else if(rdoCircle.Checked){
					length = float.Parse(txtlength.Text);
					output = 3.14f*length*length;
				}
				else if(rdoTriangle.Checked){
					length = float.Parse(txtlength.Text);
					width = float.Parse(txtWidth.Text);
					output = 0.5f*length*width;
				}
					lblOutput.Text = output.ToString();
		}
	}
}
