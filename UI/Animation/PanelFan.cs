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
    public partial class PanelFan : UserControl
    {
        private static PanelFan _instance;
        public static PanelFan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelFan();
                return _instance;
            }
        }
        public PanelFan()
        {
            InitializeComponent();
        }
    }
}
