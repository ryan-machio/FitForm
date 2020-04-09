using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RazorPagesFitForm.Models
{
    public class Subscribers
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }

        [Display(Name = "Subscribe Date")]
        [DataType(DataType.Date)]
        public DateTime SubDate{ get; set; }
    }
}
