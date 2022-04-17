using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureBLL.Interfaces;
using FigureBLL.Model;

namespace FigureBLL.Service
{
    public class RoundService : IFigure<RoundModel>
    {
        const double Pi = 3.14;
        public RoundModel GetArea(RoundModel model)
        {
            var result = new RoundModel();
            try
            {
                result.Area = ((Pi * (model.Radius * model.Radius)) > 0) ? (Pi * (model.Radius * model.Radius)).ToString("N2") : "Такого круга не существует";
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
