using Oops.Models;
using System.Collections.Generic;

namespace Oops.Services
{
    public interface IPersonService
    {
        void MarkAttendance(bool present);

        List<Attendance> GetAttendance(int id);
    }
}
