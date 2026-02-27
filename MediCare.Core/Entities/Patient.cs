
namespace MediCare.Core.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Allergies { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
