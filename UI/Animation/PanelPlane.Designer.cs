﻿namespace KTDH_Nhom23_DoAnCuoiKy.UI.Animation
{
    partial class PanelPlane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.xBegin = new System.Windows.Forms.NumericUpDown();
            this.yBegin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBegin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm bắt đầu";
            // 
            // xBegin
            // 
            this.xBegin.Location = new System.Drawing.Point(4, 54);
            this.xBegin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xBegin.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.xBegin.Name = "xBegin";
            this.xBegin.Size = new System.Drawing.Size(73, 20);
            this.xBegin.TabIndex = 13;
            this.xBegin.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // yBegin
            // 
            this.yBegin.Location = new System.Drawing.Point(116, 54);
            this.yBegin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yBegin.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.yBegin.Name = "yBegin";
            this.yBegin.Size = new System.Drawing.Size(80, 20);
            this.yBegin.TabIndex = 12;
            this.yBegin.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "x";
            // 
            // PanelPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xBegin);
            this.Controls.Add(this.yBegin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelPlane";
            this.Size = new System.Drawing.Size(202, 105);
            ((System.ComponentModel.ISupportInitialize)(this.xBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBegin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown xBegin;
        private System.Windows.Forms.NumericUpDown yBegin;
        private System.Windows.Forms.Label label2;
    }
}
