using KTDH_Nhom23_DoAnCuoiKy.Variables;
using System;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class Translation : Form
    {
        public Translation()
        {
            InitializeComponent();
        }

        public decimal TrX
        {
            get { return TrXBtn.Value; }
            set { TrXBtn.Value = value; }
        }

        public decimal TrY
        {
            get { return TrYBtn.Value; }
            set { TrYBtn.Value = value; }
        }

        public decimal TrZ
        {
            get { return TrZBtn.Value; }
            set { TrZBtn.Value = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Translation_Load(object sender, EventArgs e)
        {
            if (Init.ModeCurrent == Constants.Mode._2DMode)
            {
                TrZBtn.Enabled = false;
            }
            else
            {
                TrZBtn.Enabled = true;
            }
        }
    }
}
