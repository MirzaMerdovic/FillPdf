using System.Collections.Generic;
using Selma.Contracts.Entities;

namespace Selma.DataAccess
{
    public interface ICandidateInfoRepository
    {
        void Create(CandidateInfo info);

        CandidateInfo Get(string firstName, string lastName);

        CandidateInfo Get(string candidateDocumentPath);

        IEnumerable<CandidateInfo> GetAll(string parentPath);

        void Update(CandidateInfo info);

        void Delete(string firstName, string lastName);
    }
}