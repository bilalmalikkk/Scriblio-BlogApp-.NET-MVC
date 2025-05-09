using System;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string? Title { get; set; }

        [Required]
        public string? Content { get; set; }

        public string? Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
    }
}
