using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    [Table("Holiday")]
    public class Holiday
    {
        public Guid Id { get; set; }
        
        public string HtmlLink { get; set; }
        
        public string Summary { get; set; }

        public string Description { get; set; }
        
        public string StartDate { get; set; }
        
        public string EndDate { get; set; }
        
        public string Status { get; set; }
        
        public string CountryCode { get; set; }
    }
}