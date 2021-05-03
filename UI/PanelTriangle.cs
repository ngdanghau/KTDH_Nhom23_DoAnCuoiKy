using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public PanelTriangle()
        {
            InitializeComponent();
        }
    }
}
