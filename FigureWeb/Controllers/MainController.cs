using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FigureBLL.Model;
using FigureBLL.Service;

namespace FigureWeb.Controllers
{
    public class MainController : Controller
    {
        DefaultService service = new DefaultService();
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAreaRound(RoundModel model)
        {
            return Json(service.FuncFigure<RoundModel>(service.roundservice, model));
        }

        [HttpPost]
        public JsonResult GetAreaTriangle(TriangleModel model)
        {
            return Json(service.FuncFigure<TriangleModel>(service.triangleservice, model));
        }

        [HttpPost]
        public JsonResult GetAreaUnnowFigure(UnknownFigureModel model)
        {
            return Json(service.FuncFigure<UnknownFigureModel>(service.figureservice, model));
        }
    }
}