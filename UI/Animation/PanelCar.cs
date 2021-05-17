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
        #region Thân xe
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
        #endregion

        #region Bánh xe
        public string C1
        {
            get { return pointC1.Text; }
            set { pointC1.Text = value; }
        }
        public string C2
        {
            get { return pointC2.Text; }
            set { pointC2.Text = value; }
        }
        public string C3
        {
            get { return pointC3.Text; }
            set { pointC3.Text = value; }
        }
        public string C4
        {
            get { return pointC4.Text; }
            set { pointC4.Text = value; }
        }
        public string C5
        {
            get { return pointC5.Text; }
            set { pointC5.Text = value; }
        }
        #endregion

        #region Bánh xe
        public string HT0
        {
            get { return pointHT0.Text; }
            set { pointHT0.Text = value; }
        }

        public string HT1
        {
            get { return pointHT1.Text; }
            set { pointHT1.Text = value; }
        }
        public string HT2
        {
            get { return pointHT2.Text; }
            set { pointHT2.Text = value; }
        }
        public string HT3
        {
            get { return pointHT3.Text; }
            set { pointHT3.Text = value; }
        }
        public string HT4
        {
            get { return pointHT4.Text; }
            set { pointHT4.Text = value; }
        }
        public string HT5
        {
            get { return pointHT5.Text; }
            set { pointHT5.Text = value; }
        }
        public string HT6
        {
            get { return pointHT6.Text; }
            set { pointHT6.Text = value; }
        }
        public string HT7
        {
            get { return pointHT7.Text; }
            set { pointHT7.Text = value; }
        }
        public string HT8
        {
            get { return pointHT8.Text; }
            set { pointHT8.Text = value; }
        }

        public string HT9
        {
            get { return pointHT9.Text; }
            set { pointHT9.Text = value; }
        }

        #endregion
        public PanelCar()
        {
            InitializeComponent();
        }
    }
}
