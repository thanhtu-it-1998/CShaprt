using RoleBaseAppAccess.CustomFiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoleBaseAppAccess.Controllers
{
    public class UsersController:Controller
    {
        [AuthLog(Roles = "user")]
        public ActionResult Index()
        {
            return View();
        }
    }
}