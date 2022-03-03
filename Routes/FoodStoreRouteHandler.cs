namespace FoodStoreMinimalApi.Routes
{
    public static class FoodStoreRouteHandler
    {
        public static RouteHandlerBuilder MapGetAllFoodItems(this IEndpointRouteBuilder endpoints)
        {
            return endpoints.MapGet(RoutePatterns.GetAllFoodItems, () =>
            {
                return "Hello World!";
            }).WithName("GelAllFoodItems");
        }
    }
}
