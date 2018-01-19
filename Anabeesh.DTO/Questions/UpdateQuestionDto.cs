using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anabeesh.DTO.Questions
{
    public class UpdateQuestionDto
    {
        /// <summary>
        /// Question Id
        /// </summary>
        [Required]
        public long Id { get; set; }

        /// <summary>
        /// Question headline
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Headline { get; set; }

        /// <summary>
        /// Question description
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Number of upvotes of the question
        /// </summary>
        [Required]
        public long Upvotes { get; set; }

    }
}
