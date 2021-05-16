using KTDH_Nhom23_DoAnCuoiKy.Properties;
using KTDH_Nhom23_DoAnCuoiKy.UI.Animation;
using KTDH_Nhom23_DoAnCuoiKy.Variables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static KTDH_Nhom23_DoAnCuoiKy.Variables.Constants;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class PanelAnimateModel : UserControl
    {
        public static List<Button> lstBtnCalc = new List<Button>();
        public static List<Image> lstBtn2 = new List<Image>();

        private static PanelAnimateModel _instance;
        public static PanelAnimateModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PanelAnimateModel();
                return _instance;
            }
        }

        public static void reset()
        {
            Init.ShapeCurrent = Shape.Clock;
            HandleInputPanel(PanelClock.Instance);
            HandleButton(0, Resources._19_selected);
        }

        public PanelAnimateModel()
        {
            InitializeComponent();
        }

        static void HandleButton(int index, Bitmap image)
        {
            for (int i = 0; i < lstBtnCalc.Count; i++)
            {
                if (i == index)
                {
                    lstBtnCalc[i].Image = image;
                }
                else
                {
                    lstBtnCalc[i].Image = lstBtn2[i];
                }
            }
        }

        static void HandleInputPanel(Control Panel)
        {
            if (!Form1.GroupBoxInput.Controls.Contains(Panel))
            {
                Form1.GroupBoxInput.Controls.Add(Panel);
                Panel.Dock = DockStyle.Fill;
                Panel.BringToFront();
            }
            else
            {
                Panel.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Clock;
            HandleInputPanel(PanelClock.Instance);
            HandleButton(0, Resources._19_selected);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Car;
            HandleInputPanel(PanelCar.Instance);
            HandleButton(2, Resources._18_selected);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Plane;
            HandleInputPanel(PanelPlane.Instance);
            HandleButton(3, Resources._20_selected);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Sun;
            HandleInputPanel(PanelSun.Instance);
            HandleButton(1, Resources._21_selected);
        }

        private void Panel3DModel_Load(object sender, EventArgs e)
        {
            lstBtnCalc.Add(button1);
            lstBtnCalc.Add(button5);
            lstBtnCalc.Add(button9);
            lstBtnCalc.Add(button10);

            lstBtn2.Add(button1.Image);
            lstBtn2.Add(button5.Image);
            lstBtn2.Add(button9.Image);
            lstBtn2.Add(button10.Image);

            Init.ShapeCurrent = Shape.Clock;
            HandleButton(0, Resources._19_selected);
        }
    }
}
