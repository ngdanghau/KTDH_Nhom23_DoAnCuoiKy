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
    public partial class PanelCar : UserControl
    {
        private static PanelCar _instance;
        public static PanelCar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelCar();
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

        public PanelCar()
        {
            InitializeComponent();
        }
    }
}
