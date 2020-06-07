using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuWithAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = new RestaurantOrder(new ChildrenMenu());
            var childrenMenu = children.MenuOrder().ServeBehavior();
            Console.WriteLine(childrenMenu);

            var adults = new RestaurantOrder(new AdultsMenu());
            var adultsMenu = adults.MenuOrder().ServeBehavior();
            Console.WriteLine(adultsMenu);

            Console.Read();
        }
    }

    //Abstract Factory
    abstract class TNS_Restaurant
    {
        public abstract Appetizer ServeAppetizer();
        public abstract MainDish ServeMainDish();
        public abstract Dessert ServeDessert(); 
    } 

    class ChildrenMenu : TNS_Restaurant
    {
        public override Appetizer ServeAppetizer()
        {
            return new ChildrenAppetizer();
        }

        public override MainDish ServeMainDish()
        {
            return new ChildrenMainDish();
        }

        public override Dessert ServeDessert()
        {
            return new ChildrenDessert();
        }
    }

    class AdultsMenu : TNS_Restaurant
    {
        public override Appetizer ServeAppetizer()
        {
            return new AdultsAppetizer();
        }

        public override MainDish ServeMainDish()
        {
            return new AdultsMainDish();
        }

        public override Dessert ServeDessert()
        {
            return new AdultsDessert();    
        }
    }

    //Separation of menus
    abstract class Appetizer
    {
        public string KindOfSalad { get; protected set; }

    }

    class ChildrenAppetizer : Appetizer
    {
        public ChildrenAppetizer()
        {
            KindOfSalad = "fruitsalad";
        }
    }

    class AdultsAppetizer : Appetizer
    {
        public AdultsAppetizer()
        {
            KindOfSalad = "ceasar salad";
        }
    }

    abstract class MainDish
    {
        public string Fish { get; protected set; }
    }

    class ChildrenMainDish : MainDish
    {
        public ChildrenMainDish()
        {
            Fish = "fish-sticks";
        }
    }

    class AdultsMainDish: MainDish
    {
        public AdultsMainDish()
        {
            Fish = "swordfish";
        }
    }

    abstract class Dessert
    {
        public string Sweet { get; protected set; }
    }

    class ChildrenDessert : Dessert
    {
        public ChildrenDessert()
        {
            Sweet = "banana with chocolate";
        }
    }

    class AdultsDessert: Dessert
    {
        public AdultsDessert()
        {
            Sweet = "yogurt with honey";
        }
    }
}
