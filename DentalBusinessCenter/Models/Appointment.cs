namespace DentalBusinessCenter.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; } = string.Empty; // "08:00", "08:30", etc.
        public string Room { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // Scheduled, Completed, Cancelled
        public string Notes { get; set; } = string.Empty;
        public bool NonPaymentFlag { get; set; }
    }
}
