

namespace MediCare.Core.Entities
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime DateCreated { get; set; }
        public string AttachedFileUrl { get; set;}
        public string Diagnosis { get; set; }
        public Patient Patient { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    }
}
