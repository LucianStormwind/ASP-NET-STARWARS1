using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Question
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        public DateTime Date()
        {
            return DateTime.Now;
        }

        [Required]
        public ApplicationUser Author { get; set; }






    }
}