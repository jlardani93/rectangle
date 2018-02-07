using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RectangleProject.Models;

namespace RectangleProject.Controllers
{
    public class RectangleController : Controller
    {

        [HttpPost("/Rectangle/Info")]
        public ActionResult CreateRectangle()
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.SetWidth(Request.Form["width"]);
            myRectangle.SetLength(Request.Form["length"]);
            if (myRectangle.IsSquare()){
                Cube myCube = new Cube(myRectangle);
                return View("Cube", myCube);
            } else {
                return View("Info", myRectangle);
            }
        }

        [HttpGet("/Rectangle/Cubes")]
        public ActionResult Cubes()
        {
            List<Cube> cubeList = Cube.GetCubes();
            return View(cubeList);
        }

        [HttpGet("/Cube/{id}")]
        public ActionResult CubeDetail(int id)
        {
            Cube cube = Cube.Find(id);
            return View("Cube", cube);
        }

        [HttpGet("/Cube/ClearCube")]
        public ActionResult ClearCubes()
        {
            Cube.ClearList();
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
