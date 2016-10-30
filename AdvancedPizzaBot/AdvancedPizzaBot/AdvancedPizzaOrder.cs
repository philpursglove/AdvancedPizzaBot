using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.FormFlow;

namespace AdvancedPizzaBot
{
    public enum Crust
    {
        ThinAndCrispy = 1,
        DeepPan,
        StuffedCrust,
        GlutenFree
    }

    public enum Topping
    {
        CheeseAndTomato = 1,
        CreateYourOwn,
        AmericanHot,
        MightyMeaty,
        TandooriChicken
    }

    public enum Chicken
    {
        BBQWings = 1,
        BuffaloWings,
        SpicyBites
    }

    public enum Side
    {
        GarlicBread = 1,
        DoughBalls
    }

    public enum Dessert
    {
        ChocolateCookies = 1,
        PeanutButterCookies,
        IceCream
    }

    public class AdvancedPizzaOrder
    {
        public Crust Crust { get; set; }
        public Topping Topping { get; set; }
        [Optional]
        public List<Chicken> Chicken { get; set; }
        [Optional]
        public List<Side> Sides { get; set; }

        [Optional]
        public List<Dessert> Desserts { get; set; }
    }

    public enum Sauce
    {
        Tomato = 1,
        BBQ
    }

    public enum Cheese
    {
        Mozzarella = 1,
        LowFatMozzarella
    }

    public enum CustomTopping
    {
        
    }

    public class CreateYourOwn
    {
        public Sauce Sauce { get; set; }
        public Cheese Cheese { get; set; }
        public List<CustomTopping> CustomToppings { get; set; }
    }
}