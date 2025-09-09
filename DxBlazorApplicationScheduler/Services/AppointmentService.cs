using DxBlazorApplicationScheduler.Models;
using Microsoft.EntityFrameworkCore;

namespace DxBlazorApplicationScheduler.Services
{
    public class AppointmentService
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;
        public AppointmentService(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void AddAppointment(Appointment appointment)
        {
            _contextFactory.CreateDbContext().Appointments.Add(appointment);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            _contextFactory.CreateDbContext().Appointments.Update(appointment);
        }

        public void DeleteAppointment(int id)
        {
            var context = _contextFactory.CreateDbContext();
            var appointment = context.Appointments.Find(id);
            if (appointment != null)
            {
                context.Appointments.Remove(appointment);
            }
        }
    }
}
