using System.Collections.Generic;
using Selma.Contracts.Entities;

namespace Selma.DataAccess
{
    public interface IInstructorRepository
    {
        void Create(Instructor instructor);

        IEnumerable<Instructor> GetAll();

        void Update(Instructor instructor);

        void Delete(string firstName, string lastName);
    }
}