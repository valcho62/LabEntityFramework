﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopSystem.Models
{
    public class Category
    {

        private ICollection<Book> books;

        public Category()
        {
            this.books = new HashSet<Book>();
        }
        [Key]
        public int Id { get; set; }

       
        [Required]
        public string Name { get; set; }

        public ICollection<Book> Book
        {
            get { return this.books; }
            set { this.books = value; }
        }

       
    }
}