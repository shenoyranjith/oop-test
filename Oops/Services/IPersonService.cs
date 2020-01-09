using Oops.Models;
using System.Collections.Generic;

namespace Oops.Services
{
    public interface IPersonService
    {
        void MarkAttendance(Person person, Attendance attendance);

        List<Attendance> GetAttendance(int id);
    }
}
