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
        [Range(0, 1000)]
        public Decimal Price { get; set; }
        [Range(0, 100)]
        [Display(Name = "Page Count")]
        public int PageCount { get; set; }
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }
        [Display(Name = "Publisher")]
        public int PublisherId { get; set; }
        public virtual Publisher? Publisher { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }

    public class Publisher 
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
        public virtual List<Book>? Books { get; set; }=new List<Book>();
    }
}
