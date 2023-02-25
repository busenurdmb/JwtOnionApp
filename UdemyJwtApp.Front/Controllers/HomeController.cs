using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UdemyJwtApp.Front.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
<<<<<<< HEAD
        [Authorize(Roles = "Admin")]
=======
        [Authorize(Roles ="Admin")]
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        public string AdminPage()
        {
            return "Admin Page";
        }
<<<<<<< HEAD
        [Authorize(Roles = "Member")]
=======
        [Authorize(Roles ="Member")]
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        public string MemberPage()
        {
            return "Member Page";
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
