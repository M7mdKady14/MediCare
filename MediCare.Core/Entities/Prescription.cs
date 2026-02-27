
namespace MediCare.Core.Entities
{
    public class Prescription
    {
        public int Id { get; set; }
        public int MedicalRecordId { get; set; }
        public MedicalRecord Record { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public string Duration { get; set; }
    }
}
