namespace CurrencyRate
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cBFromCurrency = new System.Windows.Forms.ComboBox();
			this.cBToCurrency = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.convertButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите сумму";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 116);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Результат";
			// 
			// cBFromCurrency
			// 
			this.cBFromCurrency.FormattingEnabled = true;
			this.cBFromCurrency.Location = new System.Drawing.Point(191, 62);
			this.cBFromCurrency.Margin = new System.Windows.Forms.Padding(4);
			this.cBFromCurrency.Name = "cBFromCurrency";
			this.cBFromCurrency.Size = new System.Drawing.Size(422, 30);
			this.cBFromCurrency.TabIndex = 2;
			// 
			// cBToCurrency
			// 
			this.cBToCurrency.FormattingEnabled = true;
			this.cBToCurrency.Location = new System.Drawing.Point(191, 142);
			this.cBToCurrency.Margin = new System.Windows.Forms.Padding(4);
			this.cBToCurrency.Name = "cBToCurrency";
			this.cBToCurrency.Size = new System.Drawing.Size(422, 30);
			this.cBToCurrency.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 62);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(115, 30);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Location = new System.Drawing.Point(16, 142);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(133, 23);
			this.textBox2.TabIndex = 5;
			// 
			// convertButton
			// 
			this.convertButton.Location = new System.Drawing.Point(191, 222);
			this.convertButton.Margin = new System.Windows.Forms.Padding(4);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(232, 57);
			this.convertButton.TabIndex = 6;
			this.convertButton.Text = "Конвертировать";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(626, 292);
			this.Controls.Add(this.convertButton);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.cBToCurrency);
			this.Controls.Add(this.cBFromCurrency);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(648, 348);
			this.MinimumSize = new System.Drawing.Size(648, 348);
			this.Name = "Form1";
			this.Text = "Конвертер валют";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cBFromCurrency;
		private System.Windows.Forms.ComboBox cBToCurrency;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button convertButton;
	}
}

