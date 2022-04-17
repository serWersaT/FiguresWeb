using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureBLL.Interfaces;
using FigureBLL.Model;

namespace FigureBLL.Service
{
    public class TriangleService : IFigure<TriangleModel>
    {
        public TriangleModel GetArea(TriangleModel model)
        {
            var result = new TriangleModel();
            try
            {
                var Pperimetr = (model.SideA + model.SideB + model.SideC) / 2;
                result.Area = (IsTriangle(model) == true) ? (Math.Sqrt(Pperimetr * (Pperimetr - model.SideA) * (Pperimetr - model.SideB) * (Pperimetr - model.SideB))).ToString("N2") :
                    "Такого треугольника не существует";
                result.IsRectangular = IsRectangular(model);
                return result;
            }
            catch (Exception ex)
            {
                result.Area = "Произошла ошибка: " + ex.ToString();
                result.IsRectangular = false;
                return result;
            }
        }

        private bool IsRectangular(TriangleModel model)
        {
            if ((model.SideA * model.SideA + model.SideB * model.SideB == model.SideC * model.SideC) ||
                (model.SideA * model.SideA + model.SideC * model.SideC == model.SideB * model.SideB) ||
                (model.SideC * model.SideC + model.SideB * model.SideB == model.SideA * model.SideA))
                return true;
            else return false;

        }

        private bool IsTriangle(TriangleModel model)
        {
            bool result = false;
            if (model.SideA >= model.SideB && model.SideA >= model.SideC && model.SideB + model.SideC > model.SideA) result = true;
            if (model.SideB >= model.SideA && model.SideB >= model.SideC && model.SideA + model.SideC > model.SideB) result = true;
            if (model.SideC >= model.SideA && model.SideC >= model.SideB && model.SideA + model.SideB > model.SideC) result = true;
            return result;
        }
    }
}
