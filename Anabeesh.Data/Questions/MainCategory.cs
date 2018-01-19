using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anabeesh.Data.Questions
{
    public class MainCategory : BaseEntity
    {

        public MainCategory()
        {
            SubCategories = new HashSet<SubCategory>();
            Questions = new HashSet<Question>();
        }

        /// <summary>
        /// Main-Category Name
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

    }
}
