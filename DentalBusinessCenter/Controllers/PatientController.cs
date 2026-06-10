using DentalBusinessCenter.Filters;
using DentalBusinessCenter.Models;
using DentalBusinessCenter.Services;
using Microsoft.AspNetCore.Mvc;

namespace DentalBusinessCenter.Controllers
{
    [AuthorizeRole("Admin", "Receptionist", "Doctor")]
    public class PatientController : Controller
    {
        public IActionResult Index(string? search, string? category, bool nonPaymentOnly = false, int page = 1)
        {
            const int pageSize = 20;
            var role = HttpContext.Session.GetString("UserRole");
            var doctorIdStr = HttpContext.Session.GetString("DoctorId");

            IEnumerable<Patient> patients = DataStore.Patients;

            if (role == "Doctor" && int.TryParse(doctorIdStr, out int docId))
            {
                patients = patients.Where(p => p.AssignedDoctorIds.Split(',').Contains(docId.ToString()));
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                var s = search.ToLower();
                patients = patients.Where(p => p.FullNameEn.ToLower().Contains(s) || p.FullNameAr.Contains(s) || p.PrsNumber.ToLower().Contains(s) || p.Mobile.Contains(s));
            }
            if (!string.IsNullOrWhiteSpace(category))
                patients = patients.Where(p => p.Category == category);
            if (nonPaymentOnly)
                patients = patients.Where(p => p.HasNonPayment);

            var total = patients.Count();
            var paged = patients.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.Search = search;
            ViewBag.Category = category;
            ViewBag.NonPaymentOnly = nonPaymentOnly;
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)total / pageSize);
            ViewBag.Total = total;
            ViewBag.Doctors = DataStore.Doctors;
            return View(paged);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Doctors = DataStore.Doctors;
            return View(new Patient());
        }

        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            patient.DateOfFirstVisit = DateTime.Today;
            DataStore.AddPatient(patient);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var patient = DataStore.Patients.FirstOrDefault(p => p.Id == id);
            if (patient == null) return NotFound();
            ViewBag.Doctors = DataStore.Doctors;
            ViewBag.Visits = DataStore.PatientVisits.Where(v => v.PatientId == id).OrderByDescending(v => v.VisitDate).ToList();
            ViewBag.Appointments = DataStore.Appointments.Where(a => a.PatientId == id).OrderByDescending(a => a.AppointmentDate).ToList();
            return View(patient);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var patient = DataStore.Patients.FirstOrDefault(p => p.Id == id);
            if (patient == null) return NotFound();
            ViewBag.Doctors = DataStore.Doctors;
            return View(patient);
        }

        [HttpPost]
        public IActionResult Edit(int id, Patient patient)
        {
            patient.Id = id;
            DataStore.UpdatePatient(patient);
            return RedirectToAction("Details", new { id });
        }
    }
}
