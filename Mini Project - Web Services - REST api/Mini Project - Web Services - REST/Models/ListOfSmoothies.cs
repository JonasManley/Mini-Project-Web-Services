﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_Project___Web_Services___REST.Models
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
            Smoothie exotic1 = new Smoothie("exotic", "kiwifruit", "passionfruit", true);
            Smoothie sunday = new Smoothie("sunday", "banana", "oranges", true);
            Smoothie sunday1 = new Smoothie("sunday", "oranges", "banana", true);
            Smoothie sexOnTheBeach = new Smoothie("sexOnTheBeach", "strawberries", "pineapple", true);
            Smoothie easy = new Smoothie("easy", "pineapple", "banana", true);
            Smoothie strongGuy = new Smoothie("strongGuy", "blueberries", "banana", true);
            Smoothie fitness = new Smoothie("fitness", "banana", "kiwifruit", false);
            Smoothie workHard = new Smoothie("workHard", "mangoes", "peach", false);
            Smoothie strongmix = new Smoothie("dummy", "banana", "apple", true);

            List<Smoothie> smoothies = new List<Smoothie>();
            smoothies.Add(exotic);
            smoothies.Add(exotic1);
            smoothies.Add(sunday);
            smoothies.Add(sunday1);
            smoothies.Add(sexOnTheBeach);
            smoothies.Add(easy);
            smoothies.Add(strongGuy);
            smoothies.Add(fitness);
            smoothies.Add(workHard);
            smoothies.Add(strongmix);

            _smoothies = smoothies;
        }

        public List<string> fruits()
        {
            return _fruits;
        }

        public List<Smoothie> Smoothies()
        {
            return _smoothies;
        }
    }
}