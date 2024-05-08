using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Controllers
{
    public class ProgramsController : Controller
    {
        [HttpGet]
        public IActionResult HospitalList()
        {
            return View();
        }
    }
}
