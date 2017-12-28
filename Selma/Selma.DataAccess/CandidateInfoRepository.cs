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
            try
            {
                var parentPath = Helper.GetOrCreateParentPath(info.LastName.Substring(0, 1));
                var candidatePath = Path.Combine(parentPath, $"{info.LastName} {info.FirstName}.json");

                info.CandidateId = Guid.NewGuid().ToString("N");
                
                Helper.SaveJson(candidatePath, info);
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: ICandidateInfoRepository.Create {Environment.NewLine} Error: {e.Message}{Environment.NewLine}{e}");
            }
        }

        public CandidateInfo Get(string firstName, string lastName)
        {
            try
            {
                var parentPath = Helper.GetOrCreateParentPath(lastName.Substring(0, 1));
                var candidateDocumentPath = Path.Combine(parentPath, $"{lastName} {firstName}.json");

                return Get(candidateDocumentPath);
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: ICandidateInfoRepository.Get({firstName}, {lastName}) {Environment.NewLine} Error: {e.Message}{Environment.NewLine}{e}");

                return null;
            }
        }

        public CandidateInfo Get(string candidateDocumentPath)
        {
            try
            {
                if (!File.Exists(candidateDocumentPath))
                    return null;

                var json = Helper.ReadJson(candidateDocumentPath);
                var document = JsonConvert.DeserializeObject<CandidateInfo>(json);

                return document;
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: ICandidateInfoRepository.Get({candidateDocumentPath}) {Environment.NewLine} Error: {e.Message}{Environment.NewLine}{e}");

                return null;
            }
        }

        public IEnumerable<CandidateInfo> GetAll(string parentPath)
        {
            try
            {
                if (!Directory.Exists(parentPath))
                    return Enumerable.Empty<CandidateInfo>();

                var files = Directory.GetFiles(parentPath, "*.json", SearchOption.TopDirectoryOnly);

                return files.Select(Get).ToList();
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: ICandidateInfoRepository.GetAll {Environment.NewLine} Error: {e.Message}{Environment.NewLine}{e}");
            }

            return Enumerable.Empty<CandidateInfo>();
        }

        public void Update(CandidateInfo info)
        {
            try
            {
                Delete(info.FirstName, info.LastName);
                Create(info);
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: ICandidateInfoRepository.Update {Environment.NewLine} Error: {e.Message}{Environment.NewLine}{e}");
            }
        }

        public void Delete(string firstName, string lastName)
        {
            try
            {
                var parentPath = Helper.GetOrCreateParentPath(lastName.Substring(0, 1));
                var candidatePath = Path.Combine(parentPath, $"{lastName} {firstName}.json");

                if (!File.Exists(candidatePath))
                    return;

                File.Delete(candidatePath);
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: ICandidateInfoRepository.Delete({firstName}, {lastName}) {Environment.NewLine} Error: {e.Message}{Environment.NewLine}{e}");
            }
        }
    }
}