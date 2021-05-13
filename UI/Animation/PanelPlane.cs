using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        public PanelPlane()
        {
            InitializeComponent();
        }
    }
}
