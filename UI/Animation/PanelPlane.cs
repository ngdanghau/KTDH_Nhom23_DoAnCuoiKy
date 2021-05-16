﻿using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI.Animation
{
    public partial class PanelPlane : UserControl
    {
        private static PanelPlane _instance;
        public static PanelPlane Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelPlane();
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

        public PanelPlane()
        {
            InitializeComponent();
        }
    }
}
