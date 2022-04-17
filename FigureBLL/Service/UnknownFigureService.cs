using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureBLL.Interfaces;
using FigureBLL.Model;

namespace FigureBLL.Service
{
    public class UnknownFigureService : IFigure<UnknownFigureModel>
    {
        public UnknownFigureModel GetArea(UnknownFigureModel model)
        {
            var result = new UnknownFigureModel();
            decimal sumlittlearea = 0;
            try
            {
                foreach (var x in model.LittleSquareArea)
                {
                    sumlittlearea += x;
                }

                result.Area = ((model.BigSquareArea - sumlittlearea) <= 0) ? "Площадь не может быть отрицательным числом" : (model.BigSquareArea - sumlittlearea).ToString("N2");
                return result;
            }
            catch (Exception ex)
            {
                result.Area = "Произошла ошибка: " + ex.ToString();
                return result;
            }
        }
    }
}
