using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaCircle.Model;

namespace PizzaCircle.Pages
{
    public class PizzaModel : PageModel
    {

        public List<PizzasModel> LocalPizzaList = new List<PizzasModel>()
        {
            new PizzasModel()
            {
               ImageTitle = "Margerita",
               PizzaName =  "Margerita",
               BasePrice = 2,
               TomatoSauce = true,
               Cheese = true,
               Pineapple = false,
               Beef= false,
               FinalPrice = 10
            },
            new PizzasModel()
            {
               ImageTitle = "Bolognese",
               PizzaName =  "Bolognese",
               BasePrice = 3,
               TomatoSauce = false,
               Cheese = true,
               Pineapple = true,
               Beef= false,
               FinalPrice = 8
            },
            new PizzasModel()
            {
               ImageTitle = "Vegetarian",
               PizzaName =  "Vegetarian",
               BasePrice = 3,
               TomatoSauce = true,
               Cheese = false,
               Pineapple = false,
               Beef= false,
               FinalPrice = 7
            },
            new PizzasModel()
            {
               ImageTitle = "Hawaiian",
               PizzaName =  "Hawaiian",
               BasePrice = 3,
               TomatoSauce = true,
               Cheese = false,
               Pineapple = false,
               Beef= true,
               FinalPrice = 7
            }
        };
        public void OnGet()
        {
        }
    }
}
