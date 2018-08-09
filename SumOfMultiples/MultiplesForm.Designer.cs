namespace SumOfMultiples
{
	partial class MultiplesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SubmitBtn = new System.Windows.Forms.Button();
			this.MultiplesList = new System.Windows.Forms.ListView();
			this.MaxSumBox = new System.Windows.Forms.TextBox();
			this.TotalSumBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.FactorsBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SubmitBtn
			// 
			this.SubmitBtn.Location = new System.Drawing.Point(12, 230);
			this.SubmitBtn.Name = "SubmitBtn";
			this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
			this.SubmitBtn.TabIndex = 0;
			this.SubmitBtn.Text = "Submit";
			this.SubmitBtn.UseVisualStyleBackColor = true;
			this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
			// 
			// MultiplesList
			// 
			this.MultiplesList.Location = new System.Drawing.Point(157, 24);
			this.MultiplesList.Name = "MultiplesList";
			this.MultiplesList.Size = new System.Drawing.Size(164, 229);
			this.MultiplesList.TabIndex = 1;
			this.MultiplesList.UseCompatibleStateImageBehavior = false;
			// 
			// MaxSumBox
			// 
			this.MaxSumBox.Location = new System.Drawing.Point(12, 25);
			this.MaxSumBox.Name = "MaxSumBox";
			this.MaxSumBox.Size = new System.Drawing.Size(100, 20);
			this.MaxSumBox.TabIndex = 2;
			// 
			// TotalSumBox
			// 
			this.TotalSumBox.Enabled = false;
			this.TotalSumBox.Location = new System.Drawing.Point(12, 172);
			this.TotalSumBox.Name = "TotalSumBox";
			this.TotalSumBox.Size = new System.Drawing.Size(100, 20);
			this.TotalSumBox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Max Number:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(154, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "All Multiples:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Total Sum:";
			// 
			// FactorsBox
			// 
			this.FactorsBox.Location = new System.Drawing.Point(12, 90);
			this.FactorsBox.Name = "FactorsBox";
			this.FactorsBox.Size = new System.Drawing.Size(100, 20);
			this.FactorsBox.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 28);
			this.label4.TabIndex = 9;
			this.label4.Text = "List Of Factors (spaced by commas or spaces):";
			// 
			// MultiplesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 266);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.FactorsBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TotalSumBox);
			this.Controls.Add(this.MaxSumBox);
			this.Controls.Add(this.MultiplesList);
			this.Controls.Add(this.SubmitBtn);
			this.Name = "MultiplesForm";
			this.Text = "Find multiples below max number";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SubmitBtn;
		private System.Windows.Forms.ListView MultiplesList;
		private System.Windows.Forms.TextBox MaxSumBox;
		private System.Windows.Forms.TextBox TotalSumBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox FactorsBox;
		private System.Windows.Forms.Label label4;
	}
}

