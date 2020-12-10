using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CommonModel.Models;
using CommonModel.Repositories;

namespace CommonModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Common model = new Common();

            model.UserList = UserRepository.GetUsers();
            model.BookList = BookRepository.GetBooks();
            
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
