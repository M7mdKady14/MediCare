using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediCare.Core.Entities;

namespace MediCare.Core.Interfaces
{
    public interface IDoctorRepository : IGenericRepository<Doctor, int>
    {
        Task<IEnumerable<Doctor>> GetDoctorsBySpecialization(int specializationId);
    }
}
