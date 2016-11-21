

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BookShopSystem.Models
{
    public enum EditionT
    {
        Normal,Promo,Gold
    }

    public enum AgeRestriction
    {
        Minor,Teen,Adult
    }
    public class Book
    {
        private ICollection<Category> category;


        public Book()
        {
            this.category = new HashSet<Category>();
        }
        [Key]
        public int Id { get; set; }

        [MinLength(1),MaxLength(50),Required]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public EditionT EditionType { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Copies { get; set; }

        public DateTime ReleaseDate { get; set; }
        [Required]
        public virtual ICollection<Category> CategoryId
        {
            get { return this.category; }
            set { this.category = value; }
        }

        public virtual Author Author { get; set; }
        public AgeRestriction Agerestriction { get; set; }
    }
}
