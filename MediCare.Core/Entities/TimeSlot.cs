using MediCare.Core.Enums;

namespace MediCare.Core.Entities
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public AvailabilityStatus Status { get; set; }
    }
}
