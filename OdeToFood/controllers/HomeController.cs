using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;

        }
        public IActionResult Index()
        {
            //return Content("Hello from HomeController");
            //return new ObjectResult(model);

            //var model = new Restaurant { Id = 1, Name = "Beyda' pizza" };
            var model = _restaurantData.GetAll();
            return View(model);
        }
    }
}
