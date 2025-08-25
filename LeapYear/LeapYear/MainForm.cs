/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 12/14/2023
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LeapYear
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
		
		void BtnCheckClick(object sender, EventArgs e)
		{
			int year, remainder1, remainder2, remainder3;
			year = int.Parse(txtYear.Text);
			
			remainder1 = year % 4;
			remainder2 = year % 100;
			remainder3 = year % 400;
			
			if((remainder1 == 0 && remainder2 != 0) || remainder3==0)
				lblOutput.Text = "It is a leap year";
			else
				lblOutput.Text = "It is not a leap year";
		}
	}
}
