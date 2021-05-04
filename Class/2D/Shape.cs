using System.Collections.Generic;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Shape
    {
        private List<Point> list = new List<Point>();

        public List<Point> List { get => list; set => list = value; }

        public void Symmetry(int type)
        {
            for (int i = 0; i < List.Count; i++)
            {
                List[i] = PhepToan.Symmetry(List[i], type);
            }
        }
    }
}
