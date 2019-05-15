using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Enitiies
{
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string Answer { get; set; }
        public int QtypeID { get; set; }
        public string FlipPics { get; set; }
        public Qtype qtype { get; set; }
        public Song song { get; set; }
    }
}
