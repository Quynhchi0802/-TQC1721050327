using ĐTQC1721050327.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ĐTQC1721050327.Controllers
{
    public class LectureController : Controller
    {
        private ĐTQCDBContext db = new ĐTQCDBContext();
        StringProcess aukey = new StringProcess();
        // GET: Lecture
        public ActionResult Index()
        {
            return View();
        }
    }
}