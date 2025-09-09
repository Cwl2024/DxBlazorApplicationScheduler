namespace DxBlazorApplicationScheduler.Services
{
    using DevExpress.Blazor;  // for DxSchedulerAppointmentItem
    using DevExpress.Blazor.Scheduler.Internal;
    using DxBlazorApplicationScheduler.Models;

    // DEPRECATED
    public class AppointmentMapper
    {
        public static Appointment ToModel(DxSchedulerAppointmentItem item)
        {
            return new Appointment
            {
                Id = item.Id is int id ? id : 0,
                StartDate = item.Start,
                EndDate = item.End,
                Caption = item.Subject,
                AllDay = item.AllDay,
                Location = item.Location,
                Description = item.Description,
                Label = item.LabelId is int LabelId ? LabelId : 0,
                Status = (int)item.StatusId,
                //Recurrence = item.RecurrenceInfo != null ? item.RecurrenceInfo.ToString() : "",
                //ResourceId = (int)item.ResourceId
            };
        }

        // Not currently needed since all appointments that need this conversion are from the scheduler to the DB model.

        //public static DxSchedulerAppointmentItem ToAppointmentItem(Appointment model)
        //{
        //    var item = new DxSchedulerAppointmentItem
        //    {
        //        Id = model.Id,
        //        Start = model.StartDate,
        //        End = model.EndDate,
        //        Subject = model.Caption,
        //        AllDay = model.AllDay,
        //        Location = model.Location,
        //        Description = model.Description,
        //        LabelId = model.Label,
        //        StatusId = model.Status,
        //        ResourceId = int.TryParse(model.ResourceId, out var rid) ? rid : (int?)null
        //    };

        //    // Only assign RecurrenceInfo if it's valid
        //    if (!string.IsNullOrWhiteSpace(model.Recurrence))
        //    {
        //        try
        //        {
        //            item.RecurrenceInfo = RecurrenceInfo.Parse(model.Recurrence);
        //        }
        //        catch
        //        {
        //            // Optional: Log or ignore bad recurrence data
        //        }
        //    }

        //    return item;
        //}
    }
}
