﻿namespace Clock
{
	partial class AlarmForm
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
			this.lbAlarms = new System.Windows.Forms.ListBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbAlarms
			// 
			this.lbAlarms.FormattingEnabled = true;
			this.lbAlarms.ItemHeight = 29;
			this.lbAlarms.Location = new System.Drawing.Point(24, 24);
			this.lbAlarms.Margin = new System.Windows.Forms.Padding(5);
			this.lbAlarms.Name = "lbAlarms";
			this.lbAlarms.Size = new System.Drawing.Size(946, 613);
			this.lbAlarms.TabIndex = 0;
			this.lbAlarms.DoubleClick += new System.EventHandler(this.lbAlarms_DoubleClick);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(988, 24);
			this.btnOK.Margin = new System.Windows.Forms.Padding(5);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(168, 58);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(988, 92);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(168, 58);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(988, 161);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(168, 58);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// AlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1172, 671);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lbAlarms);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "AlarmForm";
			this.Text = "Alarms";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbAlarms;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
	}
}