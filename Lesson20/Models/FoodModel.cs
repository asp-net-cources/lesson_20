using Lesson20.Data.Models;

namespace Lesson20.Models;

public class FoodModel : ProductModel
{
    public new ProductType ProductType { get; } = ProductType.Food;
}
