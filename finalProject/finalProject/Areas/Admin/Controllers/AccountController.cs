using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace finalProject.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LogOut()
        {
            return Redirect("/Home/Index/");
        }
    }
}