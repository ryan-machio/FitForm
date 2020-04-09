using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace RazorPagesFitForm.Models
{
    public class Subscribers
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime SubDate{ get; set; }
        
    }
}
