﻿
namespace KTDH_Nhom23_DoAnCuoiKy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_3D = new System.Windows.Forms.Button();
            this.Btn_2D = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PageSizeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lable_Cursor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowPointName = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPointName)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.Btn_3D);
            this.panel1.Controls.Add(this.Btn_2D);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 50);
            this.panel1.TabIndex = 0;
            // 
            // Btn_3D
            // 
            this.Btn_3D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_3D.FlatAppearance.BorderSize = 0;
            this.Btn_3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_3D.ForeColor = System.Drawing.Color.White;
            this.Btn_3D.Image = global::KTDH_Nhom23_DoAnCuoiKy.Properties.Resources._3d;
            this.Btn_3D.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_3D.Location = new System.Drawing.Point(491, 0);
            this.Btn_3D.Name = "Btn_3D";
            this.Btn_3D.Size = new System.Drawing.Size(60, 50);
            this.Btn_3D.TabIndex = 4;
            this.Btn_3D.Tag = "";
            this.Btn_3D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_3D.UseVisualStyleBackColor = true;
            this.Btn_3D.Click += new System.EventHandler(this.Btn_3D_Click);
            // 
            // Btn_2D
            // 
            this.Btn_2D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_2D.FlatAppearance.BorderSize = 0;
            this.Btn_2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_2D.ForeColor = System.Drawing.Color.White;
            this.Btn_2D.Image = global::KTDH_Nhom23_DoAnCuoiKy.Properties.Resources._2d_selected;
            this.Btn_2D.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_2D.Location = new System.Drawing.Point(425, 0);
            this.Btn_2D.Name = "Btn_2D";
            this.Btn_2D.Size = new System.Drawing.Size(60, 50);
            this.Btn_2D.TabIndex = 3;
            this.Btn_2D.Tag = "";
            this.Btn_2D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_2D.UseVisualStyleBackColor = true;
            this.Btn_2D.Click += new System.EventHandler(this.Btn_2D_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.panel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(810, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 220);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PageSizeLabel);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.Lable_Cursor);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(810, 60);
            this.panel4.TabIndex = 3;
            // 
            // PageSizeLabel
            // 
            this.PageSizeLabel.AutoSize = true;
            this.PageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageSizeLabel.Location = new System.Drawing.Point(26, 9);
            this.PageSizeLabel.Name = "PageSizeLabel";
            this.PageSizeLabel.Size = new System.Drawing.Size(27, 15);
            this.PageSizeLabel.TabIndex = 3;
            this.PageSizeLabel.Text = "0, 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KTDH_Nhom23_DoAnCuoiKy.Properties.Resources.PageSize;
            this.pictureBox2.InitialImage = global::KTDH_Nhom23_DoAnCuoiKy.Properties.Resources.PageSize;
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Lable_Cursor
            // 
            this.Lable_Cursor.AutoSize = true;
            this.Lable_Cursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Cursor.Location = new System.Drawing.Point(26, 34);
            this.Lable_Cursor.Name = "Lable_Cursor";
            this.Lable_Cursor.Size = new System.Drawing.Size(27, 15);
            this.Lable_Cursor.TabIndex = 1;
            this.Lable_Cursor.Text = "0, 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KTDH_Nhom23_DoAnCuoiKy.Properties.Resources.cursor;
            this.pictureBox1.InitialImage = global::KTDH_Nhom23_DoAnCuoiKy.Properties.Resources.cursor;
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 645);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDraw);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopDraw);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Location = new System.Drawing.Point(810, 376);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 377);
            this.panel5.TabIndex = 2;
            // 
            // BtnDraw
            // 
            this.BtnDraw.FlatAppearance.BorderSize = 0;
            this.BtnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDraw.ForeColor = System.Drawing.Color.Coral;
            this.BtnDraw.Image = global::KTDH_Nhom23_DoAnCuoiKy.Properties.Resources.draw;
            this.BtnDraw.Location = new System.Drawing.Point(11, 20);
            this.BtnDraw.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(176, 38);
            this.BtnDraw.TabIndex = 23;
            this.BtnDraw.Tag = "";
            this.BtnDraw.UseVisualStyleBackColor = false;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.FlatAppearance.BorderSize = 0;
            this.BtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearAll.ForeColor = System.Drawing.Color.Coral;
            this.BtnClearAll.Image = global::KTDH_Nhom23_DoAnCuoiKy.Properties.Resources.clear;
            this.BtnClearAll.Location = new System.Drawing.Point(10, 65);
            this.BtnClearAll.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(176, 38);
            this.BtnClearAll.TabIndex = 21;
            this.BtnClearAll.Tag = "";
            this.BtnClearAll.UseVisualStyleBackColor = false;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 237);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Số";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Location = new System.Drawing.Point(810, 276);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(216, 100);
            this.panel6.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowPointName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài Đặt";
            // 
            // ShowPointName
            // 
            this.ShowPointName.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowPointName.Image = global::KTDH_Nhom23_DoAnCuoiKy.Properties.Resources.switch_off;
            this.ShowPointName.Location = new System.Drawing.Point(16, 19);
            this.ShowPointName.Name = "ShowPointName";
            this.ShowPointName.Size = new System.Drawing.Size(44, 20);
            this.ShowPointName.TabIndex = 25;
            this.ShowPointName.TabStop = false;
            this.ShowPointName.Click += new System.EventHandler(this.ShowPointName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(66, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiện Thị Tọa Độ Điểm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnClearAll);
            this.groupBox3.Controls.Add(this.BtnDraw);
            this.groupBox3.Location = new System.Drawing.Point(6, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 116);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hành Động";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 753);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vẽ hình cơ bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPointName)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_2D;
        private System.Windows.Forms.Button Btn_3D;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnClearAll;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lable_Cursor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PageSizeLabel;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ShowPointName;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

