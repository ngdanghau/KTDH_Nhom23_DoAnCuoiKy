using KTDH_Nhom23_DoAnCuoiKy.Properties;
using KTDH_Nhom23_DoAnCuoiKy.Variables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static KTDH_Nhom23_DoAnCuoiKy.Variables.Constants;

namespace KTDH_Nhom23_DoAnCuoiKy.UI
{
    public partial class Panel2DModel : UserControl
    {
        public static List<Button> lstBtnCalc = new List<Button>();
        public static List<Image> lstBtn2 = new List<Image>();

        private static Panel2DModel _instance;
        public static Panel2DModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Panel2DModel();
                return _instance;
            }
        }

        public static void reset()
        {
            Init.ShapeCurrent = Shape.Line;
            HandleInputPanel(PanelLine.Instance);
            HandleButton(1, Resources._11_selected);
        }


        public Panel2DModel()
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
        // Click Nút Trong Hình Thì sẽ set cho ShapeCurrent trong Init là hình đang vẽ là gì
        // HandleButton là xử lý nút hiện thị là đang chọn, nếu ko thì thôi.
        private void button4_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Line;
            HandleInputPanel(PanelLine.Instance);
            HandleButton(1, Resources._11_selected);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Circle;
            HandleInputPanel(PanelCircle.Instance);
            HandleButton(0, Resources._1x40_selected);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Rectangle;
            HandleInputPanel(PanelRectangle.Instance);
            HandleButton(3, Resources._3x40_selected);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Triangle;
            HandleInputPanel(PanelTriangle.Instance);
            HandleButton(4, Resources._10_selected);
        }

        private void Panel2DModel_Load(object sender, EventArgs e)
        {
            lstBtnCalc.Add(button1);
            lstBtnCalc.Add(button4);
            lstBtnCalc.Add(button8);
            lstBtnCalc.Add(button9);
            lstBtnCalc.Add(button10);

            lstBtn2.Add(button1.Image);
            lstBtn2.Add(button4.Image);
            lstBtn2.Add(button8.Image);
            lstBtn2.Add(button9.Image);
            lstBtn2.Add(button10.Image);

            Init.ShapeCurrent = Shape.Line;
            HandleButton(1, Resources._11_selected);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Init.ShapeCurrent = Shape.Elip;
            HandleInputPanel(PanelElip.Instance);
            HandleButton(2, Resources._17_selected);
        }
    }
}
