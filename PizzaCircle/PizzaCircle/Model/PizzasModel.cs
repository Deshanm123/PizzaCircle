﻿namespace PizzaCircle.Model
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string  PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pineapple { get; set; }
        public bool Beef { get; set; }
        public float FinalPrice { get; set; }



    }
}
