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
        public string Sunshine10
        {
            get { return pointSunshine10.Text; }
            set { pointSunshine10.Text = value; }
        }
        public string Sunshine11
        {
            get { return pointSunshine11.Text; }
            set { pointSunshine11.Text = value; }
        }
        public string Sunshine12
        {
            get { return pointSunshine12.Text; }
            set { pointSunshine12.Text = value; }
        }
        public string Sunshine20
        {
            get { return pointSunshine20.Text; }
            set { pointSunshine20.Text = value; }
        }
        public string Sunshine21
        {
            get { return pointSunshine21.Text; }
            set { pointSunshine21.Text = value; }
        }
        public string Sunshine22
        {
            get { return pointSunshine22.Text; }
            set { pointSunshine22.Text = value; }
        }
        public string Sunshine30
        {
            get { return pointSunshine30.Text; }
            set { pointSunshine30.Text = value; }
        }
        public string Sunshine31
        {
            get { return pointSunshine31.Text; }
            set { pointSunshine31.Text = value; }
        }
        public string Sunshine32
        {
            get { return pointSunshine32.Text; }
            set { pointSunshine32.Text = value; }
        }
        public string Sunshine40
        {
            get { return pointSunshine40.Text; }
            set { pointSunshine40.Text = value; }
        }
        public string Sunshine41
        {
            get { return pointSunshine41.Text; }
            set { pointSunshine41.Text = value; }
        }
        public string Sunshine42
        {
            get { return pointSunshine42.Text; }
            set { pointSunshine42.Text = value; }
        }
        #endregion
        public PanelSun()
        {
            InitializeComponent();
        }
    }
}
