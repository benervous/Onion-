using System.ComponentModel.DataAnnotations;

namespace Hangar.Orchestrators.Plane.Contract
{
    public class UpdateDescription
    {
        [Required]
        public string Description { get; set; }
    }
}