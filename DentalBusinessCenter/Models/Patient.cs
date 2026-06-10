namespace DentalBusinessCenter.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string PrsNumber { get; set; } = string.Empty;
        public string QuadraMedNumber { get; set; } = string.Empty;
        public string FullNameEn { get; set; } = string.Empty;
        public string FullNameAr { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string NationalId { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // Regular, Pedo, Hygienist, OR, VIP
        public DateTime DateOfFirstVisit { get; set; }
        public string AssignedDoctorIds { get; set; } = string.Empty; // comma-separated
        public bool HasNonPayment { get; set; }
    }
}
