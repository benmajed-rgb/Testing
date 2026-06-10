namespace DentalBusinessCenter.Models
{
    public class PatientVisit
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime VisitDate { get; set; }
        public string Treatment { get; set; } = string.Empty;
        public DateTime? NextVisitDate { get; set; }
        public string NextTreatment { get; set; } = string.Empty;
    }
}
