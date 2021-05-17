using System.Collections.Generic;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI.Animation
{
    public partial class PanelSun : UserControl
    {
        private static PanelSun _instance;
        public static PanelSun Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelSun();
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
        #region Đĩa mặt trời
        public string DiscSun
        {
            get { return pointDiscSun.Text; }
            set { pointDiscSun.Text = value; }
        }
        #endregion

        #region Ánh mặt trời
        public string Sunshine1_1
        {
            get { return pointSunshine10.Text; }
            set { pointSunshine10.Text = value; }
        }
        public string Sunshine1_2
        {
            get { return pointSunshine12.Text; }
            set { pointSunshine12.Text = value; }
        }
        public string Sunshine1_3
        {
            get { return pointSunshine11.Text; }
            set { pointSunshine11.Text = value; }
        }



        public string Sunshine2_1
        {
            get { return pointSunshine20.Text; }
            set { pointSunshine20.Text = value; }
        }
        public string Sunshine2_2
        {
            get { return pointSunshine22.Text; }
            set { pointSunshine22.Text = value; }
        }
        public string Sunshine2_3
        {
            get { return pointSunshine21.Text; }
            set { pointSunshine21.Text = value; }
        }



        public string Sunshine3_1
        {
            get { return pointSunshine30.Text; }
            set { pointSunshine30.Text = value; }
        }
        public string Sunshine3_2
        {
            get { return pointSunshine32.Text; }
            set { pointSunshine32.Text = value; }
        }
        public string Sunshine3_3
        {
            get { return pointSunshine31.Text; }
            set { pointSunshine31.Text = value; }
        }


        public string Sunshine4_1
        {
            get { return pointSunshine40.Text; }
            set { pointSunshine40.Text = value; }
        }
        public string Sunshine4_2
        {
            get { return pointSunshine42.Text; }
            set { pointSunshine42.Text = value; }
        }
        public string Sunshine4_3
        {
            get { return pointSunshine41.Text; }
            set { pointSunshine41.Text = value; }
        }

        public string Sunshine5_1
        {
            get { return label12.Text; }
            set { label12.Text = value; }
        }
        public string Sunshine5_2
        {
            get { return label10.Text; }
            set { label10.Text = value; }
        }
        public string Sunshine5_3
        {
            get { return label11.Text; }
            set { label11.Text = value; }
        }

        
        public string Sunshine6_1
        {
            get { return label16.Text; }
            set { label16.Text = value; }
        }
        public string Sunshine6_2
        {
            get { return label14.Text; }
            set { label14.Text = value; }
        }
        public string Sunshine6_3
        {
            get { return label15.Text; }
            set { label15.Text = value; }
        }



        public string Sunshine7_1
        {
            get { return label40.Text; }
            set { label40.Text = value; }
        }
        public string Sunshine7_2
        {
            get { return label38.Text; }
            set { label38.Text = value; }
        }
        public string Sunshine7_3
        {
            get { return label39.Text; }
            set { label39.Text = value; }
        }


        public string Sunshine8_1
        {
            get { return label36.Text; }
            set { label36.Text = value; }
        }
        public string Sunshine8_2
        {
            get { return label34.Text; }
            set { label34.Text = value; }
        }
        public string Sunshine8_3
        {
            get { return label35.Text; }
            set { label35.Text = value; }
        }

        public string Sunshine9_1
        {
            get { return label32.Text; }
            set { label32.Text = value; }
        }
        public string Sunshine9_2
        {
            get { return label30.Text; }
            set { label30.Text = value; }
        }
        public string Sunshine9_3
        {
            get { return label31.Text; }
            set { label31.Text = value; }
        }

        public string Sunshine10_1
        {
            get { return label37.Text; }
            set { label37.Text = value; }
        }
        public string Sunshine10_2
        {
            get { return label29.Text; }
            set { label29.Text = value; }
        }
        public string Sunshine10_3
        {
            get { return label33.Text; }
            set { label33.Text = value; }
        }

        public string Sunshine11_1
        {
            get { return label24.Text; }
            set { label24.Text = value; }
        }
        public string Sunshine11_2
        {
            get { return label22.Text; }
            set { label22.Text = value; }
        }
        public string Sunshine11_3
        {
            get { return label23.Text; }
            set { label23.Text = value; }
        }

        public string Sunshine12_1
        {
            get { return label20.Text; }
            set { label20.Text = value; }
        }
        public string Sunshine12_2
        {
            get { return label18.Text; }
            set { label18.Text = value; }
        }
        public string Sunshine12_3
        {
            get { return label19.Text; }
            set { label19.Text = value; }
        }

        #endregion
        public PanelSun()
        {
            InitializeComponent();
        }
    }
}
