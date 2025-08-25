/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 12/7/2023
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Area_Project
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
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtwidthTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void LbloutputClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnCaculateClick(object sender, EventArgs e)
		{
			float length,width, output;
			length = float.Parse(txtLength.Text);
			width = float.Parse(txtWidth.Text);
			output = length*width;
				lbloutput.Text = output.ToString();
		}
		
		void BtnTriangleClick(object sender, EventArgs e)
		{
			float length, width, output;
			length  = float.Parse(txtLength.Text);
			width = float.Parse(txtWidth.Text);
			output = 0.5f*length*width;
			lbloutput.Text = output.ToString();
		}
		
		void TblCircleClick(object sender, EventArgs e)
		{
			float length, output;
			length = float.Parse(txtLength.Text);
			output = 3.14f*length*length;
			lbloutput.Text = output.ToString();
		}
	}
}
