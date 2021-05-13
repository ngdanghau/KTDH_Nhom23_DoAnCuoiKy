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

        public decimal Radius
        {
            get { return x2.Value; }
            set { x2.Value = value; }
        }

        public string HourO
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }

        public string HourA
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }

        public string MinuteO
        {
            get { return label7.Text; }
            set { label7.Text = value; }
        }

        public string MinuteB
        {
            get { return label6.Text; }
            set { label6.Text = value; }
        }

        public string SecondO
        {
            get { return label9.Text; }
            set { label9.Text = value; }
        }

        public string SecondC
        {
            get { return label8.Text; }
            set { label8.Text = value; }
        }

        public PanelClock()
        {
            InitializeComponent();
        }
    }
}
