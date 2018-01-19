using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anabeesh.Data
{
    /// <summary>
    /// This is the base class that all entities will inherit from.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// The Id of the entity.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(Order = 1)]
        public long Id { get; set; }

        /// <summary>
        /// Boolean flag to know if the entity is deleted or not.
        /// </summary>
        public bool? IsDeleted { get; set; }


        /// <summary>
        /// Creation Time of the entity.
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Deletion Time of the entity.
        /// </summary>
        public DateTime? DeletionTime { get; set; }

        /// <summary>
        /// Last modification time of the entity.
        /// </summary>
        public DateTime? ModificationTime { get; set; }

    }
}
