using System;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class PanelTriangle : UserControl
    {
        private static PanelTriangle _instance;
        public static PanelTriangle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelTriangle();
                return _instance;
            }
        }

        public decimal X1
        {
            get { return x1.Value; }
            set { x1.Value = value; }
        }

        public decimal Y1
        {
            get { return y1.Value; }
            set { y1.Value = value; }
        }

        public decimal X2
        {
            get { return x2.Value; }
            set { x2.Value = value; }
        }

        public decimal Y2
        {
            get { return y2.Value; }
            set { y2.Value = value; }
        }

        public decimal X3
        {
            get { return x3.Value; }
            set { x3.Value = value; }
        }

        public decimal Y3
        {
            get { return y3.Value; }
            set { y3.Value = value; }
        }

        public PanelTriangle()
        {
            InitializeComponent();
        }
    }
}
