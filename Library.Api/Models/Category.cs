﻿namespace Library.Api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public HashSet<Book> Books { get; set; } 
    }
}
