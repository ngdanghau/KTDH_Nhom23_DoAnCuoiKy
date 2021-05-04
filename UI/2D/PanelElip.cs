using System;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class PanelElip : UserControl
    {
        private static PanelElip _instance;
        public static PanelElip Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelElip();
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

        public decimal MajorAxis
        {
            get { return x2.Value; }
            set { x2.Value = value; }
        }

        public decimal MinorAxis
        {
            get { return y2.Value; }
            set { y2.Value = value; }
        }

        public PanelElip()
        {
            InitializeComponent();
        }
    }
}
