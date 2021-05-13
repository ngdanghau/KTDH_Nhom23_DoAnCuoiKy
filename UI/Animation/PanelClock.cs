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
    public partial class PanelClock : UserControl
    {
        private static PanelClock _instance;
        public static PanelClock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelClock();
                return _instance;
            }
        }

        public PanelClock()
        {
            InitializeComponent();
        }
    }
}
