/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 2/8/2024
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestCaseProject
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int [ ] nums;
		int curIndex;
		
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
		
		
		
		void AddBtnClick(object sender, EventArgs e)
		{
			if (curIndex ==10)
			{
				MessageBox.Show("You Have Filled Array");
				return;
			}
			int num = Int32.Parse(txtInput.Text);
			nums[curIndex]=num;
			curIndex = curIndex + 1;
			
			lblOutput.Text = curIndex.ToString();
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			nums = new int[10];
			curIndex=0;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			DynamicForm df= new DynamicForm();
			df.ShowDialog();
		}
	}
}
