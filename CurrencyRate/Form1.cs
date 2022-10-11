using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CurrencyRate
{
	public partial class Form1 : Form
	{
		CurConv curConv;

		public Form1()
		{
			InitializeComponent();
			curConv = new CurConv();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Dictionary<string,string> symbolData =  curConv.GetSymbols();
			cBFromCurrency.Items.Clear();
			cBToCurrency.Items.Clear();

			cBFromCurrency.DataSource = new BindingSource(symbolData, null);
			cBFromCurrency.DisplayMember = "Value";
			cBFromCurrency.ValueMember = "Key";
			cBFromCurrency.SelectedIndex = 0;

			cBToCurrency.DataSource = new BindingSource(symbolData, null);
			cBToCurrency.DisplayMember = "Value";
			cBToCurrency.ValueMember = "Key";
			cBToCurrency.SelectedIndex = -1;
		}

		private void convertButton_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Введите сумму.");

			}
			else
			{
				if (cBFromCurrency.Text == cBToCurrency.Text)
				{
					MessageBox.Show("Выберете другую валюту для конвертации.");
				}
				else
				{
					string fromCurrency = ((KeyValuePair<string, string>)cBFromCurrency.SelectedItem).Key;
					string toCurrency = ((KeyValuePair<string, string>)cBToCurrency.SelectedItem).Key;
					double currencyAmount = double.Parse(textBox1.Text);
					double result = curConv.Convert(fromCurrency, toCurrency, currencyAmount);
					textBox2.Text = result.ToString();
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1 == null)
			{
				MessageBox.Show("Расчет не может быть произведен");
			}
		}
	}
}
