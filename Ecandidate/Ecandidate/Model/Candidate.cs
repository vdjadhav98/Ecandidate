using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace evoting.Models
{
    public class Candidate
    {
        

        [Key]
        [Required]
        public string CandidateId { get; set; }

        [Required]
        public string CandidateName { get; set; }
        
        [Required]
        [EmailAddress]
        public string CandidateEmail { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{10}$")]
        public double CandidateMobile { get; set; }

       
    }
}
