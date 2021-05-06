using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI._2D
{
    public partial class PanelDashLine : UserControl
    {
        private static PanelDashLine _instance;
        public static PanelDashLine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelDashLine();
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
        public PanelDashLine()
        {
            InitializeComponent();
        }
    }
}
