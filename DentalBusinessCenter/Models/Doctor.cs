namespace DentalBusinessCenter.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        public string AssignedRoom { get; set; } = string.Empty; // VIP 1, VIP 2, Chair 4, OR, etc.
        public string ClinicType { get; set; } = string.Empty; // BC, Pedo, OR
    }
}
