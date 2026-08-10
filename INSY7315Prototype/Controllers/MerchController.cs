using Microsoft.AspNetCore.Mvc;
using INSY7315Prototype.Models;

namespace INSY7315Prototype.Controllers
{
    public class MerchController : Controller
    {
        // GET: /Merch
        public IActionResult Index()
        {
            // TODO: replace with real data from your DbContext

            var viewModel = new MerchPageViewModel
            {
                Items = new List<MerchItem>
                {
                    new MerchItem
                    {
                        Id = 1,
                        Name = "Kingdom Cats Logo Tee",
                        Category = "Apparel",
                        Description = "Soft cotton tee with the sanctuary logo on the front.",
                        Price = 220.00m,
                        PhotoUrl = "/images/merch-tee.jpeg",
                        BackPhotoUrl = "/images/merch-tee-back.jpeg",
                        IsNew = true
                    }
                }
            };

            return View(viewModel);
        }
    }
}