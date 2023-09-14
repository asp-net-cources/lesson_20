using Lesson20.Data.Models;

namespace Lesson20.Models;

public class BookModel : ProductModel
{
    public new ProductType ProductType { get; } = ProductType.Book;
}
