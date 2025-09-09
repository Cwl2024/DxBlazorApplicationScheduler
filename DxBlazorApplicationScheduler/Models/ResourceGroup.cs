
using System.ComponentModel.DataAnnotations;

namespace DxBlazorApplicationScheduler.Models
{
    public class ResourceGroup
    {
        [Key]
        public int ResourceGroupId { get; set; }
        public int ResourceId { get; set; }
        public Resource Resource { get; set; } = null!;

        public int GroupId { get; set; }
        public AppGroup Group { get; set; } = null!;

        // Additional criteria
        public bool IsOwner { get; set; } = false;
    }
}
