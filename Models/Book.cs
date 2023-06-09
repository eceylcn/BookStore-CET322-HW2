﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
        public int ?PublisherId { get; set; }
        public virtual Publisher? Publisher { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }

    public class Publisher : ViewComponent
    {
        
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public virtual List <Book> Books { get; set; } = new List<Book>();
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book>? Books { get; set; }
    }
}
