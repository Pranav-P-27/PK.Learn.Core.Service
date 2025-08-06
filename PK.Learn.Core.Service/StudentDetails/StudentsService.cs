
using PK.Learn.Core.Service.DBModel;
using PK.Learn.Core.Service.StudentDetails.Interface;

namespace PK.Learn.Core.Service.StudentDetails;

public class StudentsService : IStudentsService
{
    public Task<IEnumerable<Student>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
