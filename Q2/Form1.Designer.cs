namespace Q2
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
			this.lblDate = new System.Windows.Forms.Label();
			this.btnSibmit = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblDate.Location = new System.Drawing.Point(47, 70);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(50, 21);
			this.lblDate.TabIndex = 0;
			this.lblDate.Text = "Date:";
			// 
			// btnSibmit
			// 
			this.btnSibmit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSibmit.Location = new System.Drawing.Point(200, 163);
			this.btnSibmit.Name = "btnSibmit";
			this.btnSibmit.Size = new System.Drawing.Size(75, 36);
			this.btnSibmit.TabIndex = 1;
			this.btnSibmit.Text = "Submit";
			this.btnSibmit.UseVisualStyleBackColor = true;
			this.btnSibmit.Click += new System.EventHandler(this.btnSibmit_Click);
			// 
			// txtInput
			// 
			this.txtInput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtInput.Location = new System.Drawing.Point(103, 67);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(119, 29);
			this.txtInput.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 271);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.btnSibmit);
			this.Controls.Add(this.lblDate);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Button btnSibmit;
		private System.Windows.Forms.TextBox txtInput;
	}
}

