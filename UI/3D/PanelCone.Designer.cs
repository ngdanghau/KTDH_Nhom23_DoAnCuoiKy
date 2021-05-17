
namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    partial class PanelCone
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
            this.canh = new System.Windows.Forms.NumericUpDown();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.z1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            this.SuspendLayout();
            // 
            // canh
            // 
            this.canh.Location = new System.Drawing.Point(7, 72);
            this.canh.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.canh.Name = "canh";
            this.canh.Size = new System.Drawing.Size(62, 20);
            this.canh.TabIndex = 19;
            this.canh.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
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
            this.x1.Size = new System.Drawing.Size(47, 20);
            this.x1.TabIndex = 18;
            this.x1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(79, 24);
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
            this.y1.Size = new System.Drawing.Size(46, 20);
            this.y1.TabIndex = 17;
            this.y1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(149, 24);
            this.z1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.z1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(46, 20);
            this.z1.TabIndex = 16;
            this.z1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chiều Cao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tọa Độ Gốc";
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(111, 72);
            this.r.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(62, 20);
            this.r.TabIndex = 21;
            this.r.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bán Kính";
            // 
            // PanelCone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.r);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.canh);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PanelCone";
            this.Size = new System.Drawing.Size(198, 147);
            ((System.ComponentModel.ISupportInitialize)(this.canh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown canh;
        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.NumericUpDown z1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown r;
        private System.Windows.Forms.Label label5;
    }
}
