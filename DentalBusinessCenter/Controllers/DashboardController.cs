using DentalBusinessCenter.Filters;
using DentalBusinessCenter.Services;
using Microsoft.AspNetCore.Mvc;

namespace DentalBusinessCenter.Controllers
{
    [AuthorizeRole("Admin", "Receptionist", "Doctor")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var (todayAppointments, activePatients, alerts, doctorCount) = DataStore.GetDashboardStats();
            ViewBag.TodayAppointments = todayAppointments;
            ViewBag.ActivePatients = activePatients;
            ViewBag.Alerts = alerts;
            ViewBag.DoctorCount = doctorCount;

            var today = DateTime.Today;
            var weekStart = today.AddDays(-(int)today.DayOfWeek);

            // Weekly appointments: top 5 doctors
            var top5Doctors = DataStore.Doctors.Take(5).ToList();
            var weeklyData = top5Doctors.Select(d => new
            {
                Name = d.FullName.Replace("Dr. ", ""),
                Count = DataStore.Appointments.Count(a => a.DoctorId == d.Id && a.AppointmentDate >= weekStart && a.AppointmentDate <= weekStart.AddDays(6))
            }).ToList();

            ViewBag.ChartLabels = System.Text.Json.JsonSerializer.Serialize(weeklyData.Select(x => x.Name).ToArray());
            ViewBag.ChartData = System.Text.Json.JsonSerializer.Serialize(weeklyData.Select(x => x.Count).ToArray());

            var recentAppts = DataStore.Appointments
                .OrderByDescending(a => a.AppointmentDate)
                .Take(5)
                .Select(a => new
                {
                    Appointment = a,
                    Patient = DataStore.Patients.FirstOrDefault(p => p.Id == a.PatientId),
                    Doctor = DataStore.Doctors.FirstOrDefault(d => d.Id == a.DoctorId)
                }).ToList();

            ViewBag.RecentAppointments = recentAppts;
            return View();
        }
    }
}
