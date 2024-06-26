using Microsoft.AspNetCore.Mvc;
using CinemaMVC.Models;

namespace CinemaMVC.Controllers
{
    public class BigliettiController : Controller
    {
        public IActionResult Index()
        {
            return View(Cinema.Biglietti);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                if (Cinema.GetBigliettiVenduti(ticket.Sala) < Cinema.CapienzaSale[ticket.Sala])
                {
                    Cinema.Biglietti.Add(ticket);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Capienza massima raggiunta per " + ticket.Sala);
                }
            }
            return View(ticket);
        }
    }
}
