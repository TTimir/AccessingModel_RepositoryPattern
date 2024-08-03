using EX_AccessModel.Models;

namespace EX_AccessModel.Repository
{
    public interface IStudent
    {
        // Abstract Methods
        List<StudModel> getAllStudents();
        StudModel getStudentByID(int id);
    }
}
