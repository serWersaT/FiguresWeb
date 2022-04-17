using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureBLL.Interfaces;

namespace FigureBLL.Service
{
    public class DefaultService
    {
        public RoundService roundservice = new RoundService();
        public UnknownFigureService figureservice = new UnknownFigureService();
        public TriangleService triangleservice = new TriangleService();

        public M FuncFigure<M>(IFigure<M> Ifig, M model)
        {
            return Ifig.GetArea(model);
        }
    }
}
