using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    [Table("country")]
    public class Country
    {
        public Guid Id { get; set; }
        
        public string Code { get; set; }

        public string Name { get; set; }
        
        public string Region { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}