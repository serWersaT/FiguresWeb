using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureBLL.Model;
using FigureBLL.Service;

namespace FigureTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TesGetArea()
        {
            TriangleModel model = new TriangleModel();
            TriangleService service = new TriangleService();
            model.SideA = 10;
            model.SideB = 15;
            model.SideC = 20;

            bool result = (!service.GetArea(model).Area.Contains("Произошла ошибка")) ? true : false;
            Assert.AreEqual(result, true);
        }
    }
}
