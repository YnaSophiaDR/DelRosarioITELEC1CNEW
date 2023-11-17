
using DelRosarioITELEC1C.Models;

namespace DelRosarioITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataServices
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }

        //constructor
        public MyFakeDataService()
        {

            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Yna",LastName = "Del Rosario", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-04-25"), GPA = 1, Email = "ydelrosario@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Sophia",LastName = "Muldong", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2021-01-01"), GPA = 1.5, Email = "smophiadong@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Sophie",LastName = "Padua", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2023-10-25"), GPA = 1.5, Email = "paduasoph3@gmail.com"
                }
            };

            InstructorList = new List<Instructor>() {
            new Instructor()
                {
                Id= 1,
                FirstName="Cayde",
                LastName="Muldong",
                IsTenured=true,
                Rank=Rank.Professor,
                HiringDate=DateTime.Parse("09/25/2023")
            },
            new Instructor()
                {
                    Id= 2,
                FirstName="Saffi",
                LastName="Muldong",
                IsTenured=true,
                Rank=Rank.AssistantProfessor,
                HiringDate=DateTime.Parse("02/22/2022")
            }

            };

        }

    }
}