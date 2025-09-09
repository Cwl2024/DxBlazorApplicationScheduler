namespace DxBlazorApplicationScheduler.Models
{
    public class AppGroup
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<ResourceGroup> ResourceGroups { get; set; } = new List<ResourceGroup>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
