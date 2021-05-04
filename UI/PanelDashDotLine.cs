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
    public partial class PanelDashDotLine : UserControl
    {
        private static PanelDashDotLine _instance;
        public static PanelDashDotLine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelDashDotLine();
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
        public PanelDashDotLine()
        {
            InitializeComponent();
        }
    }
}
