using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.UI.Animation
{
    public partial class PanelPlane : UserControl
    {
        private static PanelPlane _instance;
        public static PanelPlane Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelPlane();
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
        #region thân máy bay
        public string A
        {
            get { return pointA.Text; }
            set { pointA.Text = value; }
        }
        public string B
        {
            get { return pointB.Text; }
            set { pointB.Text = value; }
        }
        public string C
        {
            get { return pointC.Text; }
            set { pointC.Text = value; }
        }
        public string D
        {
            get { return pointD.Text; }
            set { pointD.Text = value; }
        }
        public string E
        {
            get { return pointE.Text; }
            set { pointE.Text = value; }
        }
        public string F
        {
            get { return pointF.Text; }
            set { pointF.Text = value; }
        }
        public string G
        {
            get { return pointG.Text; }
            set { pointG.Text = value; }
        }
        public string H
        {
            get { return pointH.Text; }
            set { pointH.Text = value; }
        }
        public string M
        {
            get { return pointM.Text; }
            set { pointM.Text = value; }
        }
        public string N
        {
            get { return pointN.Text; }
            set { pointN.Text = value; }
        }
        #endregion

        #region cánh máy bay
        public string O
        {
            get { return pointO.Text; }
            set { pointO.Text = value; }
        }
        public string P
        {
            get { return pointP.Text; }
            set { pointP.Text = value; }
        }
        public string Q
        {
            get { return pointQ.Text; }
            set { pointQ.Text = value; }
        }
        public string R
        {
            get { return pointR.Text; }
            set { pointR.Text = value; }
        }
        #endregion

        #region họa tiết
        public string CR1
        {
            get { return pointCR1.Text; }
            set { pointCR1.Text = value; }
        }
        public string CR2
        {
            get { return pointCR2.Text; }
            set { pointCR2.Text = value; }
        }
        public string CR3
        {
            get { return pointCR3.Text; }
            set { pointCR3.Text = value; }
        }
        public string CR4
        {
            get { return pointCR4.Text; }
            set { pointCR4.Text = value; }
        }
        #endregion
        public PanelPlane()
        {
            InitializeComponent();
        }
    }
}
