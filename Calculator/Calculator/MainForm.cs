/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 11/30/2023
 * Time: 2:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int num1,num2, result;
			num1=int.Parse(txtNum1.Text);
			num2=int.Parse(txtNum2.Text);
			
			result= num1*num2;
			
			lblOutput.Text= result.ToString();			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int num1,num2, result;
			num1=int.Parse(txtNum1.Text);
			num2=int.Parse(txtNum2.Text);
			
			result= num1-num2;
			
			lblOutput.Text= result.ToString();			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//long = long numbers / int = small numbers
			int num1,num2, result;
			num1=int.Parse(txtNum1.Text);
			num2=int.Parse(txtNum2.Text);
			
			result= num1/num2;
			
			lblOutput.Text= result.ToString();			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			int num1,num2, result;
			num1=int.Parse(txtNum1.Text);
			num2=int.Parse(txtNum2.Text);
			
			result= num1+num2;
			
			lblOutput.Text= result.ToString();		
		}
	}
}
