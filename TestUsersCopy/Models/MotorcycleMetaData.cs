using System.ComponentModel.DataAnnotations;

namespace TestUsersCopy.Models
{
    public class MotorcycleMetaData
    {
        [Required]
        [StringLength(20)]
        public string Model { get; set; }
        //[Required]
        //[Range(1, 6)]
        public double Price { get; set; }

    }

    [MetadataType(typeof(MotorcycleMetaData))]
    public partial class Motorcycle
    {
    }
}