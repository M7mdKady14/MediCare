using MediCare.Core.Enums;

namespace MediCare.Core.Entities
{
    public class AppointmentLog
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Reason { get; set; }
        public AppointmentChangeType ChangeType { get; set; }
        public Appointment Appointment { get; set; }
    }
}
