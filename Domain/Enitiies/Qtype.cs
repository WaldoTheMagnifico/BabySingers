using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Enitiies
{
    public class Qtype
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QtypeID { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Question> question { get; set; }
    }
}
