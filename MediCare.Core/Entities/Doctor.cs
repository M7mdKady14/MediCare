
using System.ComponentModel;

namespace MediCare.Core.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SpecializationId { get; set; }
        public decimal ConsultationFee { get; set; }
        public string ProfilePictureUrl { get; set; }
        public ApplicationUser User { get; set; }
        public Specialization Specialization { get; set; }
        public ICollection<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();


    }
}
