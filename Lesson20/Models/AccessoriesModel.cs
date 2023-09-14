using Lesson20.Data.Models;

namespace Lesson20.Models;

public class AccessoriesModel : ProductModel
{
    public new ProductType ProductType { get; } = ProductType.Accessories;
}
