using EX_AccessModel.Models;

namespace EX_AccessModel.Repository
{
    public class StudentRepository : IStudent // Important
    {
        // Abstract method body derives from interface.
        public List<StudModel> getAllStudents()
        {
            return DataSource();
        }

        public StudModel getStudentByID(int id)
        {
            return DataSource().Where(x => x.StudID == id).FirstOrDefault();
        }

        // created a seperate class to get data
        private List<StudModel> DataSource()
        {
            return new List<StudModel>
            {
                new StudModel { StudID=01, Name="Raj", Age=21, Field="BA" },
                new StudModel { StudID=02, Name="Ayush", Age=20, Field="BSC" },
                new StudModel { StudID=03, Name="Smit", Age=22, Field="BBA" },
                new StudModel { StudID=04, Name="Ram", Age=22, Field="BCA" },
            };
        }
    }
}
