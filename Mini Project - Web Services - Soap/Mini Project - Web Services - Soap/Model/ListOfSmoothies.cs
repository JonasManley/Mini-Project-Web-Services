using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_Project___Web_Services___Soap.Model
{
    public class ListOfSmoothies
    {
        private List<string> _fruits = new List<string> { "pineapple", "banana", "watermelon",
            "peach", "oranges", "mandarins", "mangoes", "strawberries", "raspberries", "blueberries" +
            "passionfruit", "kiwifruit "};
        private List<Smoothie> _smoothies;

        public ListOfSmoothies()
        {
            Smoothie exotic = new Smoothie("exotic", "passionfruit", "kiwifruit", true);
            Smoothie sunday = new Smoothie("sunday", "banana", "oranges", true);
            Smoothie sexOnTheBeach = new Smoothie("sexOnTheBeach", "strawberries", "pineapple", true);
            Smoothie easy = new Smoothie("easy", "pineapple", "banana", true);
            Smoothie strongGuy = new Smoothie("strongGuy", "blueberries", "banana", true);
            Smoothie fitness = new Smoothie("fitness", "banana", "kiwifruit", false);
            Smoothie workHard = new Smoothie("workHard", "mangoes", "peach", false);
            Smoothie payday = new Smoothie("payday", "strawberries", "blueberries", true);
            Smoothie palm = new Smoothie("palm", "watermelon", "peach", false);
            Smoothie beautiful = new Smoothie("beautiful", "passionfruit", "mandarins", true);
            Smoothie women = new Smoothie("women", "mandarins", "pineapple", false);
            Smoothie rainyday = new Smoothie("rainyday", "banana", "peach", false);
            Smoothie painfull = new Smoothie("painfull", "mangoes", "blueberries", true);
            Smoothie bike = new Smoothie("bike", "mandarins", "mandarins", false);
            Smoothie publicttransport = new Smoothie("publicttransport", "mangoes", "kiwifruit", false);


            List<Smoothie> smoothies = new List<Smoothie>();
            smoothies.Add(exotic);
            smoothies.Add(sunday);
            smoothies.Add(sexOnTheBeach);
            smoothies.Add(easy);
            smoothies.Add(strongGuy);
            smoothies.Add(fitness);
            smoothies.Add(workHard);
            smoothies.Add(payday);
            smoothies.Add(palm);
            smoothies.Add(beautiful);
            smoothies.Add(women);
            smoothies.Add(rainyday);
            smoothies.Add(painfull);
            smoothies.Add(bike);
            smoothies.Add(publicttransport);

            _smoothies = smoothies;
        }

        public List<string> fruits() {
            return _fruits;
        }

        public List<Smoothie> Smoothies()
        {
            return _smoothies;
        }

  

    }
}