using ASPdotNetCoreWebApp.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPdotNetCoreWebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly IDMS_RCRpdfService _DMS_RCRpdfService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMemberService memberService, IDMS_RCRpdfService dMS_RCRpdfService)
        {
            _logger = logger;
            _memberService = memberService;
            _DMS_RCRpdfService = dMS_RCRpdfService;
        }

        public IActionResult Index()
        {
            //var asdf = await _memberService.GetAllMembers();

            var asdfadas = _DMS_RCRpdfService.GetAllMembers();
            //_memberService.GetAllMembers().ToList()
            //    .ForEach(member => {
            //        member.Address = "123";
            //    });
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult NewMember()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SubmitContactForm(MemberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState)
                {
                    foreach (var err in error.Value.Errors)
                    {
                        Console.WriteLine($"Error in field {error.Key}: {err.ErrorMessage}");
                    }
                }
            }

            if (ModelState.IsValid)
            {
                // Process form submission (e.g., save data to database, send email)
                return RedirectToAction("Success");
            }

            // If the model is not valid, return to the form view with validation messages
            return View("Index", model);
        }

        public IActionResult Success()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
