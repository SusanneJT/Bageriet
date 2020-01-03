using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    
    public class Rating
    {
        [BindNever]
        public int RatingId { get; set; }

        public int BreadId { get; set; }
        public Bread Bread { get; set; }

        [Required(ErrorMessage = "Vänligen ange ett betyg mellan 1 till 5")]
        [Range(1, 5)]
        [Display(Name = "Betyg:")]
        public int Grade { get; set; }

        [StringLength(200)]
        [Display(Name = "Kommentar:")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Vänligen ange ditt namn")]
        [Display(Name = "Namn:")]
        [StringLength(50)]
        public string AuthorName { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email:")]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
        ErrorMessage = "Epostadressen är angiven i fel format")]
        public string Email { get; set; }

    }
}
