using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anabeesh.Data.Questions
{
    public class Question : BaseEntity
    {

        public Question()
        {
            Answers = new HashSet<Answer>();
        }

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
        /// Number of answers of the question
        /// </summary>
        [Required]
        public long NumberOfAnswers { get; set; }

        /// <summary>
        /// Number of upvotes of the question
        /// </summary>
        [Required]
        public long Upvotes { get; set; }

        /// <summary>
        /// Number of downvotes of the question
        /// </summary>
        [Required]
        public long Downvotes { get; set; }

        /// <summary>
        /// Foregin key to user
        /// </summary>
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        /// <summary>
        /// Foregin key to Main-Category
        /// </summary>
        [ForeignKey("MainCategory")]
        public long MainCategoryId { get; set; }

        /// <summary>
        /// Foregin key to Sub-Category
        /// </summary>
        [ForeignKey("SubCategory")]
        public long SubCategoryId { get; set; }

        public virtual MainCategory MainCategory { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }


    }
}
