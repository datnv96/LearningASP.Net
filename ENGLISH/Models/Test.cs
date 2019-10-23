using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ENGLISH.Models
{
    public class Test
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer1 { get; set; }
        [Required]
        public string Answer2 { get; set; }
        [Required]
        public string Answer3 { get; set; }
        [Required]
        public string Answer4 { get; set; }
        [Required]
        public int RightAnswer { get; set; }
        public string Notification { get; set; }
    }
}
