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
            this.btnDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDate
            // 
            this.btnDate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDate.Location = new System.Drawing.Point(68, 39);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(127, 36);
            this.btnDate.TabIndex = 0;
            this.btnDate.Text = "Test";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 137);
            this.Controls.Add(this.btnDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDate;
	}
}

