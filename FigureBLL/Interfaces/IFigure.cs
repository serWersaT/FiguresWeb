using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureBLL.Interfaces
{
    public interface IFigure<M>
    {
        M GetArea(M model);
    }
}
