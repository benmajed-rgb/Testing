using DentalBusinessCenter.Filters;
using DentalBusinessCenter.Services;
using Microsoft.AspNetCore.Mvc;

namespace DentalBusinessCenter.Controllers
{
    [AuthorizeRole("Admin", "Receptionist")]
    public class ReportController : Controller
    {
        public IActionResult PatientAnalytics()
        {
            var today = DateTime.Today;
            // Patients by category
            var categories = new[] { "Regular", "VIP", "Pedo", "OR", "Hygienist" };
            var catCounts = categories.Select(c => DataStore.Patients.Count(p => p.Category == c)).ToArray();

            // Monthly registrations (last 12 months)
            var months = Enumerable.Range(0, 12).Select(i => today.AddMonths(-11 + i)).ToList();
            var monthLabels = months.Select(m => m.ToString("MMM yyyy")).ToArray();
            var monthCounts = months.Select(m =>
                DataStore.Patients.Count(p => p.DateOfFirstVisit.Year == m.Year && p.DateOfFirstVisit.Month == m.Month)
            ).ToArray();

            ViewBag.CategoryLabels = System.Text.Json.JsonSerializer.Serialize(categories);
            ViewBag.CategoryCounts = System.Text.Json.JsonSerializer.Serialize(catCounts);
            ViewBag.MonthLabels = System.Text.Json.JsonSerializer.Serialize(monthLabels);
            ViewBag.MonthCounts = System.Text.Json.JsonSerializer.Serialize(monthCounts);
            ViewBag.TotalPatients = DataStore.Patients.Count;
            return View();
        }

        public IActionResult DoctorPerformance()
        {
            var today = DateTime.Today;
            var firstOfMonth = new DateTime(today.Year, today.Month, 1);
            var doctors = DataStore.Doctors.Take(15).ToList();
            var data = doctors.Select(d => new
            {
                Doctor = d,
                TotalPatients = DataStore.Patients.Count(p => p.AssignedDoctorIds.Split(',').Contains(d.Id.ToString())),
                MonthlyAppts = DataStore.Appointments.Count(a => a.DoctorId == d.Id && a.AppointmentDate >= firstOfMonth),
                TotalAppts = DataStore.Appointments.Count(a => a.DoctorId == d.Id),
                CompletedAppts = DataStore.Appointments.Count(a => a.DoctorId == d.Id && a.Status == "Completed")
            }).ToList();

            ViewBag.DoctorLabels = System.Text.Json.JsonSerializer.Serialize(data.Select(x => x.Doctor.FullName.Replace("Dr. ", "")).ToArray());
            ViewBag.ApptCounts = System.Text.Json.JsonSerializer.Serialize(data.Select(x => x.TotalAppts).ToArray());
            ViewBag.DoctorData = data;
            return View();
        }

        public IActionResult RoomOccupancy()
        {
            var rooms = new[] { "VIP 1", "VIP 2", "VIP 3", "Chair 1", "Chair 2", "Chair 3", "OR", "CBCT Room" };
            var today = DateTime.Today;
            var firstOfMonth = new DateTime(today.Year, today.Month, 1);
            int workDays = Enumerable.Range(0, today.Day)
                .Count(d => firstOfMonth.AddDays(d).DayOfWeek != DayOfWeek.Friday && firstOfMonth.AddDays(d).DayOfWeek != DayOfWeek.Saturday);
            int slotsPerDay = 18;

            var data = rooms.Select(r => {
                var used = DataStore.Appointments.Count(a => a.Room == r && a.AppointmentDate >= firstOfMonth && a.AppointmentDate <= today);
                var total = workDays * slotsPerDay;
                return new { Room = r, Used = used, Total = total, Pct = total > 0 ? (int)Math.Round((double)used / total * 100) : 0 };
            }).ToList();

            ViewBag.RoomLabels = System.Text.Json.JsonSerializer.Serialize(rooms);
            ViewBag.RoomUsed = System.Text.Json.JsonSerializer.Serialize(data.Select(x => x.Used).ToArray());
            ViewBag.RoomData = data;
            return View();
        }
    }
}
