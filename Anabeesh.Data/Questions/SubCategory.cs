using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anabeesh.Data.Questions
{
    public class SubCategory : BaseEntity
    {

        public SubCategory()
        {
            Questions = new HashSet<Question>();
        }

        /// <summary>
        /// Sub-Category Name
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Foreign key to the main category
        /// </summary>
        [ForeignKey("MainCategory")]
        [Required]
        public long MainCategoryId { get; set; }

        public virtual MainCategory MainCategory { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
