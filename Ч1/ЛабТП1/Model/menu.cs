using System;
using System.Collections.Generic;
using System.Text;

namespace ЛабТП1.Model
{
    public class menu
    {
        public List<interfacefood> MyMenu = new List<interfacefood>();

        public menu()
        {
            interfacefood cake = new desert("пирог", 300, 200, 15, 250);
            interfacefood icecream = new desert("мороженное", 150, 100, 5, 100);
            interfacefood pie = new desert("торт", 350, 250, 20, 250);
            interfacefood chocolate = new desert("шоколад", 100, 50, 5, 100);

            interfacefood coffe = new drink("кофе", 100, 40, 10, 200);
            interfacefood tea = new drink("чай", 100, 40, 10, 200);
            interfacefood juice = new drink("сок", 100, 40, 10, 200);
            interfacefood compote = new drink("компот", 100, 40, 10, 200);

            interfacefood ceasar = new salat("цезарь", 300, 200, 15, 250);
            interfacefood grecian = new salat("греческий салат", 300, 200, 15, 250);
            interfacefood olivier = new salat("оливье", 300, 200, 15, 250);
            interfacefood crab = new salat("крабовый салат", 300, 200, 15, 250);

            interfacefood tartalet = new snack("тарталетки", 100, 40, 10, 200);
            interfacefood toast = new snack("гренки", 100, 40, 10, 200);
            interfacefood onion = new snack("луковые кольца", 100, 40, 10, 200);
            interfacefood sandwich= new snack("бутерброт", 100, 40, 10, 200);

            MyMenu.Add(cake);
            MyMenu.Add(icecream);
            MyMenu.Add(pie);
            MyMenu.Add(chocolate);
            MyMenu.Add(coffe);
            MyMenu.Add(tea);
            MyMenu.Add(juice);
            MyMenu.Add(compote);
            MyMenu.Add(ceasar);
            MyMenu.Add(grecian);
            MyMenu.Add(olivier);
            MyMenu.Add(crab);
            MyMenu.Add(tartalet);
            MyMenu.Add(toast);
            MyMenu.Add(onion);
            MyMenu.Add(sandwich);
        }
    }
}
