using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Selma.Contracts.Entities;

namespace Selma.DataAccess
{
    public class InstructorRepository : IInstructorRepository
    {
        public void Create(Instructor instructor)
        {
            try
            {
                var path = Helper.GetOrCreateInstructorsPath();
                var instructorPath = Path.Combine(path, $"{instructor.FirstName} {instructor.LastName}.json");

                Helper.SaveJson(instructorPath, instructor);
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: IInstructorRepository.Create {Environment.NewLine}Error: {e.Message}{Environment.NewLine}{e}");
            }
        }

        public Instructor Get(string fullName)
        {
            var instructorPath = Path.Combine(Helper.GetOrCreateInstructorsPath(), $"{fullName}.json");

            if (!File.Exists(instructorPath))
                return null;

            var json = Helper.ReadJson(instructorPath);
            var instructor = JsonConvert.DeserializeObject<Instructor>(json);

            return instructor;
        }

        public IEnumerable<Instructor> GetAll()
        {
            var instructors = new List<Instructor>();

            try
            {
                instructors.AddRange(
                    Directory.GetFiles(
                            Helper.GetOrCreateInstructorsPath(),
                            "*",
                            SearchOption.TopDirectoryOnly)
                        .Select(path => JsonConvert.DeserializeObject<Instructor>(Helper.ReadJson(path))));
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: IInstructorRepository.GetAll {Environment.NewLine}Error: {e.Message}{Environment.NewLine}{e}");
            }

            return instructors;
        }

        public void Update(Instructor instructor)
        {
            try
            {
                Delete(instructor.FirstName, instructor.LastName);
                Create(instructor);
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: IInstructorRepository.Update {Environment.NewLine}Error: {e.Message}{Environment.NewLine}{e}");
            }
        }

        public void Delete(string firstName, string lastName)
        {
            try
            {
                var instructorPath = Path.Combine(Helper.GetOrCreateInstructorsPath(), $"{firstName} {lastName}.json");

                if (!File.Exists(instructorPath))
                    return;

                File.Delete(instructorPath);
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: IInstructorRepository.Delete({firstName}, {lastName}) {Environment.NewLine}Error: {e.Message}{Environment.NewLine}{e}");
            }
        }
    }
}