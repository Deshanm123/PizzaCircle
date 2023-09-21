using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaCircle.Model;

namespace PizzaCircle.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get;set; }
        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.Cheese) PizzaPrice += 1;
            if(Pizza.Beef) PizzaPrice += 5;

            if(Pizza.Pineapple) PizzaPrice += 4;
            if(Pizza.TomatoSauce) PizzaPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName ,PizzaPrice});
         }
    }
}
