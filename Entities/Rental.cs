using Castle.Core.Resource;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VehicleRentalAPI.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int VehicleId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        [JsonIgnore] 
        public virtual Customer Customer { get; set; }
        [JsonIgnore]
        public virtual Vehicle Vehicle { get; set; }

    }
}
