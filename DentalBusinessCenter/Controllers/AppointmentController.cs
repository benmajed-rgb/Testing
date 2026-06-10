using DentalBusinessCenter.Filters;
using DentalBusinessCenter.Models;
using DentalBusinessCenter.Services;
using Microsoft.AspNetCore.Mvc;

namespace DentalBusinessCenter.Controllers
{
    [AuthorizeRole("Admin", "Receptionist", "Doctor")]
    public class AppointmentController : Controller
    {
        public IActionResult Index(int? year, int? month)
        {
            var today = DateTime.Today;
            int y = year ?? today.Year;
            int m = month ?? today.Month;
            var firstDay = new DateTime(y, m, 1);
            var lastDay = firstDay.AddMonths(1).AddDays(-1);

            var appointments = DataStore.Appointments
                .Where(a => a.AppointmentDate >= firstDay && a.AppointmentDate <= lastDay)
                .ToList();

            ViewBag.Year = y;
            ViewBag.Month = m;
            ViewBag.MonthName = firstDay.ToString("MMMM yyyy");
            ViewBag.FirstDayOfWeek = (int)firstDay.DayOfWeek;
            ViewBag.DaysInMonth = lastDay.Day;
            ViewBag.Appointments = appointments;
            ViewBag.Patients = DataStore.Patients;
            ViewBag.Doctors = DataStore.Doctors;
            return View();
        }

        public IActionResult Daily(DateTime? date, int? doctorId, string? room)
        {
            var d = date?.Date ?? DateTime.Today;
            var appts = DataStore.Appointments.Where(a => a.AppointmentDate.Date == d);
            if (doctorId.HasValue) appts = appts.Where(a => a.DoctorId == doctorId.Value);
            if (!string.IsNullOrWhiteSpace(room)) appts = appts.Where(a => a.Room == room);

            var slots = new List<string>();
            for (int h = 8; h <= 17; h++)
                for (int mm = 0; mm < 60; mm += 30)
                    if (!(h == 17 && mm > 0)) slots.Add($"{h:D2}:{mm:D2}");

            ViewBag.Date = d;
            ViewBag.Slots = slots;
            ViewBag.AppointmentList = appts.ToList();
            ViewBag.Doctors = DataStore.Doctors;
            ViewBag.Rooms = new[] { "VIP 1", "VIP 2", "VIP 3", "Chair 1", "Chair 2", "Chair 3", "OR", "CBCT Room" };
            ViewBag.SelectedDoctorId = doctorId;
            ViewBag.SelectedRoom = room;
            ViewBag.Patients = DataStore.Patients;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Patients = DataStore.Patients;
            ViewBag.Doctors = DataStore.Doctors;
            ViewBag.Rooms = new[] { "VIP 1", "VIP 2", "VIP 3", "Chair 1", "Chair 2", "Chair 3", "OR", "CBCT Room" };
            ViewBag.Slots = GetTimeSlots();
            return View(new Appointment { AppointmentDate = DateTime.Today, Status = "Scheduled" });
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            DataStore.AddAppointment(appointment);
            return RedirectToAction("Index");
        }

        public IActionResult NonPayment()
        {
            var appts = DataStore.Appointments
                .Where(a => a.NonPaymentFlag)
                .OrderByDescending(a => a.AppointmentDate)
                .ToList();
            ViewBag.Patients = DataStore.Patients;
            ViewBag.Doctors = DataStore.Doctors;
            return View(appts);
        }

        private static List<string> GetTimeSlots()
        {
            var slots = new List<string>();
            for (int h = 8; h <= 17; h++)
                for (int mm = 0; mm < 60; mm += 30)
                    if (!(h == 17 && mm > 0)) slots.Add($"{h:D2}:{mm:D2}");
            return slots;
        }
    }
}
