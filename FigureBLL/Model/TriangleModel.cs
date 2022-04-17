using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureBLL.Model
{
    public class TriangleModel
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public string Area { get; set; }
        public bool IsRectangular { get; set; }
    }
}
