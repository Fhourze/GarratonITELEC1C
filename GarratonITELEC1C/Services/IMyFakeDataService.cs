using System;
using GarratonITELEC1C.Services;
using GarratonITELEC1C.Models;
namespace GarratonITELEC1C.Services
{
    public interface IMyFakeDataService
    {
        List<Instructor> InstructorList { get; }
    }
}
