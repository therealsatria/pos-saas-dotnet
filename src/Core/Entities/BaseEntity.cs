using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    /// <summary>
    /// Base class for all entities in the system
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the BaseEntity class
        /// </summary>
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }

        /// <summary>
        /// Gets or sets the unique identifier
        /// </summary>
        [Key]
        public Guid Id { get; init; }

        /// <summary>
        /// Gets or sets the creation date
        /// </summary>
        [Required]
        public DateTime CreatedAt { get; init; }

        /// <summary>
        /// Gets or sets the last update date
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is soft deleted
        /// </summary>
        [Required]
        public bool IsDeleted { get; set; }
    }
}
