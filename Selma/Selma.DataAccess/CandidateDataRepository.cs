using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Selma.Contracts.Entities;

namespace Selma.DataAccess
{
    public class CandidateDataRepository
    {
        public void Create(CandidateDocument data)
        {
            data.CandidateId = Guid.NewGuid().ToString("N");
            
            var parentPath = Helper.GetOrCreateParentPath(data.FirstName.Substring(0, 1));
            var candidatePath = Path.Combine(parentPath, $"{data.LastName} {data.FirstName}.json");

            var json = JsonConvert.SerializeObject(data, Formatting.Indented);

            Helper.SaveCandidate(candidatePath, json);
        }

        public CandidateDocument Get(string firstName, string lastName)
        {
            var parentPath = Helper.GetOrCreateParentPath(lastName.Substring(0, 1));
            var candidateDocumentPath = Path.Combine(parentPath, $"{lastName} {firstName}.json");

            return Get(candidateDocumentPath);
        }

        public CandidateDocument Get(string candidateDocumentPath)
        {
            if (!File.Exists(candidateDocumentPath))
                return null;

            var json = Helper.ReadCandidateJson(candidateDocumentPath);
            var document = JsonConvert.DeserializeObject<CandidateDocument>(json);

            return document;
        }

        public IEnumerable<CandidateDocument> GetAll(string parentPath)
        {
            return
                Directory.GetFiles(parentPath, "*.json", SearchOption.TopDirectoryOnly)
                    .Select(Get)
                    .ToList();
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