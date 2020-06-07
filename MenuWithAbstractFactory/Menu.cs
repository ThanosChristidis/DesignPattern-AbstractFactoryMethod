namespace MenuWithAbstractFactory
{
    //Restaurant has menu

    class Menu
    {
        
        public Appetizer Appetizer { get; }
        public MainDish MainDish { get; }
        public Dessert Dessert { get; }

        public Menu(Appetizer appetizer, MainDish mainDish,Dessert dessert)
        {
            Appetizer = appetizer;
            MainDish = mainDish;
            Dessert = dessert;
        }

        public string ServeBehavior()
        {
            return $"\tThe menu includes {Appetizer.KindOfSalad}, {MainDish.Fish} and {Dessert.Sweet}!";
        }
    }
}
