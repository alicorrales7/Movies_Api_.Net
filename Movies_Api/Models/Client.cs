using System;
using System.ComponentModel.DataAnnotations;

namespace Movies_Api.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Addres { get; set; }

        [Required]
        public string Phone { get; set; }


    }
}

