namespace Q4
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblPeople = new System.Windows.Forms.Label();
			this.lblCar = new System.Windows.Forms.Label();
			this.txtPeople = new System.Windows.Forms.TextBox();
			this.txtCar = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.lblOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPeople
			// 
			this.lblPeople.AutoSize = true;
			this.lblPeople.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPeople.Location = new System.Drawing.Point(29, 105);
			this.lblPeople.Name = "lblPeople";
			this.lblPeople.Size = new System.Drawing.Size(46, 21);
			this.lblPeople.TabIndex = 0;
			this.lblPeople.Text = "人數:";
			// 
			// lblCar
			// 
			this.lblCar.AutoSize = true;
			this.lblCar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblCar.Location = new System.Drawing.Point(265, 105);
			this.lblCar.Name = "lblCar";
			this.lblCar.Size = new System.Drawing.Size(30, 21);
			this.lblCar.TabIndex = 0;
			this.lblCar.Text = "車:";
			// 
			// txtPeople
			// 
			this.txtPeople.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPeople.Location = new System.Drawing.Point(81, 102);
			this.txtPeople.Name = "txtPeople";
			this.txtPeople.Size = new System.Drawing.Size(118, 29);
			this.txtPeople.TabIndex = 1;
			// 
			// txtCar
			// 
			this.txtCar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtCar.Location = new System.Drawing.Point(311, 102);
			this.txtCar.Name = "txtCar";
			this.txtCar.Size = new System.Drawing.Size(118, 29);
			this.txtCar.TabIndex = 1;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCalculate.Location = new System.Drawing.Point(336, 184);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(93, 43);
			this.btnCalculate.TabIndex = 2;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// lblOutput
			// 
			this.lblOutput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblOutput.Location = new System.Drawing.Point(77, 266);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(326, 67);
			this.lblOutput.TabIndex = 3;
			this.lblOutput.Text = "lblOutput";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 421);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtCar);
			this.Controls.Add(this.txtPeople);
			this.Controls.Add(this.lblCar);
			this.Controls.Add(this.lblPeople);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPeople;
		private System.Windows.Forms.Label lblCar;
		private System.Windows.Forms.TextBox txtPeople;
		private System.Windows.Forms.TextBox txtCar;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label lblOutput;
	}
}

