using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anabeesh.DTO.Questions
{
    public class GetQuestionDto
    {

        public long Id { get; set; }

        /// <summary>
        /// Question headline (Title)
        /// </summary>
        public string Headline { get; set; }

        /// <summary>
        /// Question description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Number of answers of the question
        /// </summary>
        public long NumberOfAnswers { get; set; }

        /// <summary>
        /// Number of upvotes of the question
        /// </summary>
        public long Upvotes { get; set; }

        /// <summary>
        /// Number of downvotes of the question
        /// </summary>
        public long Downvotes { get; set; }

        /// <summary>
        /// Foregin key to user
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Foregin key to Main-Category
        /// </summary>
        public long MainCategoryId { get; set; }

        /// <summary>
        /// Foregin key to Sub-Category
        /// </summary>
        public long SubCategoryId { get; set; }
    }
}
