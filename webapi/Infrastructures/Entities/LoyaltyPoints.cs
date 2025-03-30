using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Infrastructures.Entities
{
    
    /// Represents a customer's loyalty points balance
    
    public class LoyaltyPoints : BaseEntity
    {
        
        /// Initializes a new instance of the LoyaltyPoints class
        
        public LoyaltyPoints()
        {
            Customer = new Customer();
            LoyaltyProgram = new LoyaltyProgram();
        }

        
        /// Gets or sets the customer ID
        
        [Required]
        public Guid LoyaltyProgramId { get; set; }

        
        /// Gets or sets the associated loyalty program
        
        [NotNull]
        public virtual LoyaltyProgram? LoyaltyProgram { get; set; }

        
        /// Gets or sets the customer ID
        
        [Required]
        public Guid CustomerId { get; set; }

        
        /// Gets or sets the points balance
        
        [Required]
        [Range(0, int.MaxValue)]
        public int Balance { get; set; }

        
        /// Gets or sets the associated customer
        
        [NotNull]
        public virtual Customer? Customer { get; set; }
    }
}
