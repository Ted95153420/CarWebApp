using System;
using System.ComponentModel.DataAnnotations;

namespace CarPriceComparison.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EMail { get; set; }
        [Required]
        [StringLength(4096, MinimumLength =10)]
        public string Message { get; set; }
    }
}