namespace MenuWithAbstractFactory
{
    // Client

    class RestaurantOrder
    {
        private TNS_Restaurant _restaurant;

        public RestaurantOrder(TNS_Restaurant restaurant)
        {
            _restaurant = restaurant;
        }

        public Menu MenuOrder()
        {
            var appetizer = _restaurant.ServeAppetizer();
            var mainDish = _restaurant.ServeMainDish();
            var dessert = _restaurant.ServeDessert();

            return new Menu(appetizer, mainDish, dessert);
        }
    }
}
