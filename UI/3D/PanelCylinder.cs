using System;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class PanelCylinder : UserControl
    {
        private static PanelCylinder _instance;
        public static PanelCylinder Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelCylinder();
                return _instance;
            }
        }

        public decimal X
        {
            get { return x1.Value; }
            set { x1.Value = value; }
        }

        public decimal Y
        {
            get { return y1.Value; }
            set { y1.Value = value; }
        }

        public decimal Z
        {
            get { return z1.Value; }
            set { z1.Value = value; }
        }


        public decimal ChieuCao
        {
            get { return canh.Value; }
            set { canh.Value = value; }
        }

        public decimal Radius
        {
            get { return r.Value; }
            set { r.Value = value; }
        }

        public PanelCylinder()
        {
            InitializeComponent();
        }
    }
}
