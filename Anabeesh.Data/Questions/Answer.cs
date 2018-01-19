using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anabeesh.Data.Questions
{
    public class Answer : BaseEntity
    {
        [Required]
        public string Body { get; set; }

        [ForeignKey("ApplicationUser")]
        [Required]
        public string UserId { get; set; }

        [ForeignKey("Question")]
        [Required]
        public long QuestionsId { get; set; }

        public virtual Question Question { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
