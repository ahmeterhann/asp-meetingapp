using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
{
        //localhost/home
        public  IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            int UserCount = ViewBag.UserCount = Repository.Users.Where(info=>info.WillAttend==true).Count();

            //ViewBag.Selamlama = saat < 12 ? "Günaydın" : "İyi Günler";;
            //ViewBag.UserName = "Erhan";

            ViewData["Selamlama"] = saat < 12 ? "Günaydın" : "İyi Günler"; ;
            //ViewData["UserName"] = "Erhan";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul",
                Date = DateTime.Now,
                NumberOfPeople = UserCount
            };

            return View(meetingInfo);
        }
        
    }
}