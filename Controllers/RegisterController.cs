using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TruckWebProject.Controllers
{
	public class RegisterController : Controller
	{
		DriverManager dm = new DriverManager(new EFDriverRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Driver p)
		{
			DriverValidatior dv = new DriverValidatior();	
			ValidationResult results = dv.Validate(p);
			if(results.IsValid)
			{
                p.DriverStatus = true;
                dm.DriverAdd(p);

                return RedirectToAction("Index", "Comment");
            }
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}
			
		}
	}
}
