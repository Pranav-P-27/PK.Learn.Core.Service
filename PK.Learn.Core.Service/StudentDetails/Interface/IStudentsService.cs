using PK.Learn.Core.Service.DBModel;

namespace PK.Learn.Core.Service.StudentDetails.Interface
{
    public interface IStudentsService
    {
        Task<IEnumerable<Student>> GetAllAsync();
    }
}
