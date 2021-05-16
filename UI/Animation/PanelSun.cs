using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI.Animation
{
    public partial class PanelSun : UserControl
    {
        private static PanelSun _instance;
        public static PanelSun Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelSun();
                return _instance;
            }
        }

        public decimal X
        {
            get { return xBegin.Value; }
            set { xBegin.Value = value; }
        }

        public decimal Y
        {
            get { return yBegin.Value; }
            set { yBegin.Value = value; }
        }


        public PanelSun()
        {
            InitializeComponent();
        }
    }
}
