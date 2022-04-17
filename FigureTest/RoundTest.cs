using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureBLL.Model;
using FigureBLL.Service;

namespace FigureTest
{
    [TestClass]
    public class RoundTest
    {
        [TestMethod]
        public void TesGetArea()
        {
            RoundModel model = new RoundModel();
            RoundService service = new RoundService();
            model.Radius = 10;

            bool result = (!service.GetArea(model).Area.Contains("Произошла ошибка")) ? true : false;
            Assert.AreEqual(result, true);
        }
    }
}
