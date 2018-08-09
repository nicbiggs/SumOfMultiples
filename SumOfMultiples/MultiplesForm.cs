using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SumOfMultiples
{
	public partial class MultiplesForm : Form
	{
		public MultiplesForm()
		{
			InitializeComponent();
		}

		private List<int> Factors
		{
			get
			{
				List<int> factorList = ParseIntegers.GetIntegers(FactorsBox.Text);
				factorList.Sort();
				return factorList;
			}
		}

		private int TotalSum
		{
			get
			{
				if (TotalSumBox.Text.All(c => char.IsDigit(c)))
				{
					return int.Parse(TotalSumBox.Text);
				}
				else
				{
					return -1;
				}
				
			}
			set
			{
				TotalSumBox.Text = value.ToString();
			}
		}

		private void SubmitBtn_Click(object sender, EventArgs e)
		{
			TotalSum = 0;
			MultiplesList.Items.Clear();
			HandleMultiples();
			TotalSum.ToString();
		}

		private void HandleMultiples()
		{
			if (MaxSumBox.Text.All(c => char.IsDigit(c)))
			{
				for (int i = 1; i < int.Parse(MaxSumBox.Text); i++)
				{
					if (IsValueDivisibleToAFactor(i))
					{
						ListAndStoreValue(i);
					}
				}
			}
		}

		private bool IsValueDivisibleToAFactor(int value)
		{
			foreach (int factor in Factors)
			{
				if (value % factor == 0)
				{
					return true;
				}
			}
			return false;
		}

		private void ListAndStoreValue(int value)
		{
			TotalSum += value;
			MultiplesList.Items.Add(new ListViewItem(value.ToString()));
		}


	}
}
