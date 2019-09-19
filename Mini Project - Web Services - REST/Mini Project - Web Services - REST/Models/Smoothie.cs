using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_Project___Web_Services___REST.Models
{
    public class Smoothie
    {
        private string _fruit1;
        private string _fruit2;
        private bool _iceOrNot;
        private string _name;

        public Smoothie()
        {

        }
        public Smoothie(string name, string fruit1, string fruit2, bool iceOrNot)
        {
            _name = name;
            _fruit1 = fruit1;
            _fruit2 = fruit2;
            _iceOrNot = iceOrNot;

        }

        public override string ToString()
        {
            return "Smootihe: " + _name + " with the ingredients: " + _fruit1 + " " + _fruit2 + " " + "ice: " + _iceOrNot;
        }

        public string name
        {
            get { return _name; }
        }
        public string fruit1
        {
            get { return _fruit1; }
        }
        public string fruit2
        {
            get { return _fruit2; }

        }
        public bool iceOrNot
        {
            get { return _iceOrNot; }
        }


        public string recipie
        {
            get { return "ingredients: " + " " + fruit1 + " " + fruit2 + " " + iceOrNot; }
        }
    }
}