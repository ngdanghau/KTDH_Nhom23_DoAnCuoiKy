using System;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class PanelCube : UserControl
    {
        private static PanelCube _instance;
        public static PanelCube Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelCube();
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


        public decimal Edge
        {
            get { return canh.Value; }
            set { canh.Value = value; }
        }

        public PanelCube()
        {
            InitializeComponent();
        }
    }
}
