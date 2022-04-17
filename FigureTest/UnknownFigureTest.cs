using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureBLL.Model;
using FigureBLL.Service;
using System.Collections.Generic;

namespace FigureTest
{
    [TestClass]
    public class UnknownFigureTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnknownFigureModel model = new UnknownFigureModel();
            UnknownFigureService service = new UnknownFigureService();

            List<decimal> listarea = new List<decimal>();
            listarea.Add((decimal)10.111);
            listarea.Add((decimal)20.522);
            listarea.Add(30);
            model.BigSquareArea = 150;
            model.LittleSquareArea = listarea;

            bool result = (!service.GetArea(model).Area.Contains("Произошла ошибка")) ? true : false;
            Assert.AreEqual(result, true);
        }
    }
}
