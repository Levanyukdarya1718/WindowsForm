﻿namespace Clock
{
    partial class ChooseFontForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFontForm));
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.labelChooseFont = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.cbFonts = new System.Windows.Forms.ComboBox();
            this.labelExample = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(349, 37);
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(59, 22);
            this.nudFontSize.TabIndex = 0;
            this.nudFontSize.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // labelChooseFont
            // 
            this.labelChooseFont.AutoSize = true;
            this.labelChooseFont.Location = new System.Drawing.Point(14, 9);
            this.labelChooseFont.Name = "labelChooseFont";
            this.labelChooseFont.Size = new System.Drawing.Size(83, 16);
            this.labelChooseFont.TabIndex = 1;
            this.labelChooseFont.Text = "ChooseFont:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(242, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(333, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(349, 15);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(65, 16);
            this.labelFontSize.TabIndex = 4;
            this.labelFontSize.Text = "Font Size:";
            // 
            // cbFonts
            // 
            this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(14, 35);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(325, 24);
            this.cbFonts.TabIndex = 5;
            this.cbFonts.SelectedIndexChanged += new System.EventHandler(this.cbFonts_SelectedIndexChanged);
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExample.Location = new System.Drawing.Point(12, 73);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(176, 46);
            this.labelExample.TabIndex = 6;
            this.labelExample.Text = "Example";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(333, 65);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ChooseFontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 193);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.cbFonts);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelChooseFont);
            this.Controls.Add(this.nudFontSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseFontForm";
            this.Text = "ChooseFont";
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Label labelChooseFont;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Button btnApply;
    }
}