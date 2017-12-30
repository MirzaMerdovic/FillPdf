using System.Collections.Generic;
using Selma.Contracts.Entities;

namespace Selma.DataAccess
{
    public interface IInstructorRepository
    {
        void Create(Instructor instructor);

        Instructor Get(string fullName);

        IEnumerable<Instructor> GetAll();

        void Update(Instructor instructor);

        void Delete(string firstName, string lastName);
    }
}