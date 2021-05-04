using KTDH_Nhom23_DoAnCuoiKy.Properties;
using KTDH_Nhom23_DoAnCuoiKy.Variables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static KTDH_Nhom23_DoAnCuoiKy.Variables.Constants;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class Panel3DModel : UserControl
    {
        public static List<Button> lstBtnCalc = new List<Button>();
        public static List<Image> lstBtn2 = new List<Image>();

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

        public static void reset()
        {
            Init.ShapeCurrent = Shape.Sphere;
            HandleInputPanel(PanelSphere.Instance);
            HandleButton(0, Resources._13_selected);
        }

        public Panel3DModel()
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
            Init.ShapeCurrent = Shape.Sphere;
            HandleInputPanel(PanelSphere.Instance);
            HandleButton(0, Resources._13_selected);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Cube;
            HandleInputPanel(PanelCube.Instance);
            HandleButton(2, Resources._14_selected);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Cone;
            HandleInputPanel(PanelTriangle.Instance);
            HandleButton(3, Resources._15_selected);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Cylinder;
            HandleInputPanel(PanelCylinder.Instance);
            HandleButton(1, Resources._16_selected);
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

            Init.ShapeCurrent = Shape.Line;
            HandleButton(0, Resources._13_selected);
        }
    }
}
