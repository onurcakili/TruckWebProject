using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace TruckWebProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {
            var values = cm.GetCommentListWithCategory();
            return View(values);
        }
    }
}
