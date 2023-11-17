using DelRosarioITELEC1C.Models;
namespace DelRosarioITELEC1C.Services
{
    public interface IMyFakeDataServices
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
