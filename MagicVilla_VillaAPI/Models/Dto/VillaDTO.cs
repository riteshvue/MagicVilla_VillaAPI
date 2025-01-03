using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public string Details { get; set; }
        public double Rate { get; set; }

        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; init; }
        public string Amenity { get; set; }


    }
}