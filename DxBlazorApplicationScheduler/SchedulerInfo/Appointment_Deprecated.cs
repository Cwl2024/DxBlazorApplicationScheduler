using System;

namespace DxBlazorApplicationScheduler.SchedulerInfo
{
    public class Appointment_Deprecated
    {
        public Appointment_Deprecated() { }
        public int AppointmentType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int? Label { get; set; }
        public int Status { get; set; }
        public bool AllDay { get; set; }
        public string Recurrence { get; set; }
        public int? ResourceId { get; set; }
        public string Resources { get; set; }
        public bool Accepted { get; set; }
    }
}
