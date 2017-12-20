using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Selma.Contracts.Entities;

namespace Selma.DataAccess
{
    public class CandidateInfoRepository : ICandidateInfoRepository
    {
        public void Create(CandidateInfo info)
        {
            info.CandidateId = Guid.NewGuid().ToString("N");
            
            var parentPath = Helper.GetOrCreateParentPath(info.LastName.Substring(0, 1));
            var candidatePath = Path.Combine(parentPath, $"{info.LastName} {info.FirstName}.json");

            var json = JsonConvert.SerializeObject(info, Formatting.Indented);

            Helper.SaveCandidate(candidatePath, json);
        }

        public CandidateInfo Get(string firstName, string lastName)
        {
            var parentPath = Helper.GetOrCreateParentPath(lastName.Substring(0, 1));
            var candidateDocumentPath = Path.Combine(parentPath, $"{lastName} {firstName}.json");

            return Get(candidateDocumentPath);
        }

        public CandidateInfo Get(string candidateDocumentPath)
        {
            if (!File.Exists(candidateDocumentPath))
                return null;

            var json = Helper.ReadCandidateJson(candidateDocumentPath);
            var document = JsonConvert.DeserializeObject<CandidateInfo>(json);

            return document;
        }

        public IEnumerable<CandidateInfo> GetAll(string parentPath)
        {
            return
                Directory.GetFiles(parentPath, "*.json", SearchOption.TopDirectoryOnly)
                    .Select(Get)
                    .ToList();
        }

        public void Update(CandidateInfo info)
        {
            Delete(info.FirstName, info.LastName);
            Create(info);
        }

        public void Delete(string firstName, string lastName)
        {
            var parentPath = Helper.GetOrCreateParentPath(lastName.Substring(0, 1));
            var candidatePath = Path.Combine(parentPath, $"{lastName} {firstName}.json");

            if (!File.Exists(candidatePath))
                return;

            File.Delete(candidatePath);
        }
    }
}