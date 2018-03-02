using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;
        private IRestaurantData _sqlrestaurantdata;

        public string CurrentGreeting { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; private set; }

        public GreetingModel(
            IGreeter greeter,
            IRestaurantData SqlRestaurantData)
        {
            _greeter = greeter;
            _sqlrestaurantdata = SqlRestaurantData;
        }
        public void OnGet(string name)
        {
            CurrentGreeting = $"{name} : {_greeter.GetMessageOfTheDay()}";
            Restaurants = _sqlrestaurantdata.GetAll();
        }
    }
}