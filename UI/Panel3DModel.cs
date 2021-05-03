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
    public partial class Panel3DModel : UserControl
    {
        private static Panel3DModel _instance;
        public static Panel3DModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Panel3DModel();
                return _instance;
            }
        }
        public Panel3DModel()
        {
            InitializeComponent();
        }
    }
}
