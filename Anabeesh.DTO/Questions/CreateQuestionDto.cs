using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Anabeesh.DTO.Questions
{
    public class CreateQuestionDto
    {

        public long Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Headline { get; set; }

        /// <summary>
        /// Question description
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Foregin key to user
        /// </summary>
        [Required]
        public string UserId { get; set; }

        /// <summary>
        /// Foregin key to Main-Category
        /// </summary>
        [Required]
        public long MainCategoryId { get; set; }

        /// <summary>
        /// Foregin key to Sub-Category
        /// </summary>
        [Required]
        public long SubCategoryId { get; set; }
    }
}
