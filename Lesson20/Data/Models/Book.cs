﻿namespace Lesson20.Data.Models;

public class Book
{
    public string Name { get; set; }
    public new ProductType ProductType { get; } = ProductType.Book;
}
