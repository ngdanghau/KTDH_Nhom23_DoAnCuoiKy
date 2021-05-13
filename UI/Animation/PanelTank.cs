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
    public partial class PanelTank : UserControl
    {
        private static PanelTank _instance;
        public static PanelTank Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelTank();
                return _instance;
            }
        }
        public PanelTank()
        {
            InitializeComponent();
        }
    }
}
