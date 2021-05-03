using System;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class PanelRectangle : UserControl
    {
        private static PanelRectangle _instance;
        public static PanelRectangle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelRectangle();
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

        public decimal A_Edge
        {
            get { return x2.Value; }
            set { x2.Value = value; }
        }

        public decimal B_Edge
        {
            get { return y2.Value; }
            set { y2.Value = value; }
        }

        public PanelRectangle()
        {
            InitializeComponent();
        }
    }
}
