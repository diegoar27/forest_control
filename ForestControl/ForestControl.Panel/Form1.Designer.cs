
namespace ForestControl.Panel
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbData = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btProcess = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbData
			// 
			this.tbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbData.Location = new System.Drawing.Point(12, 32);
			this.tbData.Multiline = true;
			this.tbData.Name = "tbData";
			this.tbData.Size = new System.Drawing.Size(750, 265);
			this.tbData.TabIndex = 0;
			this.tbData.Text = "5 5\r\n3 3 E\r\nL\r\n3 3 E\r\nMMRMMRMRRM\r\n1 2 N\r\nLMLMLMLMMLMLMLMLMM";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Insert data:";
			// 
			// btProcess
			// 
			this.btProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btProcess.Location = new System.Drawing.Point(668, 307);
			this.btProcess.Name = "btProcess";
			this.btProcess.Size = new System.Drawing.Size(94, 29);
			this.btProcess.TabIndex = 2;
			this.btProcess.Text = "Process";
			this.btProcess.UseVisualStyleBackColor = true;
			this.btProcess.Click += new System.EventHandler(this.OnClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 348);
			this.Controls.Add(this.btProcess);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbData);
			this.Name = "Form1";
			this.Text = "Forest control";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btProcess;
	}
}

