using DentalBusinessCenter.Filters;
using DentalBusinessCenter.Services;
using Microsoft.AspNetCore.Mvc;

namespace DentalBusinessCenter.Controllers
{
    [AuthorizeRole("Admin", "Receptionist", "Doctor")]
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            var doctors = DataStore.Doctors;
            return View(doctors);
        }

        public IActionResult Details(int id)
        {
            var doctor = DataStore.Doctors.FirstOrDefault(d => d.Id == id);
            if (doctor == null) return NotFound();
            var patients = DataStore.Patients
                .Where(p => p.AssignedDoctorIds.Split(',').Contains(id.ToString()))
                .ToList();
            var visits = DataStore.PatientVisits.Where(v => v.DoctorId == id).ToList();
            ViewBag.Patients = patients;
            ViewBag.Visits = visits;
            ViewBag.AppointmentCount = DataStore.Appointments.Count(a => a.DoctorId == id);
            return View(doctor);
        }
    }
}
