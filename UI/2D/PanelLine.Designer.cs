
namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    partial class PanelLine
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.x2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm Đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điểm Cuối";
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(115, 71);
            this.y2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(80, 20);
            this.y2.TabIndex = 8;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(115, 23);
            this.y1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(80, 20);
            this.y1.TabIndex = 9;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(7, 24);
            this.x1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(73, 20);
            this.x1.TabIndex = 10;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(7, 71);
            this.x2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(73, 20);
            this.x2.TabIndex = 11;
            // 
            // PanelLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PanelLine";
            this.Size = new System.Drawing.Size(198, 109);
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.NumericUpDown x2;
    }
}
