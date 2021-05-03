using System;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class PanelCircle : UserControl
    {
        private static PanelCircle _instance;
        public static PanelCircle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelCircle();
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

        public decimal Radius
        {
            get { return x2.Value; }
            set { x2.Value = value; }
        }

        public PanelCircle()
        {
            InitializeComponent();
        }
    }
}
