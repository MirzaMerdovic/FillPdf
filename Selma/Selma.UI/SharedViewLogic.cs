using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Selma.Contracts.Entities;
using Selma.DataAccess;

namespace Selma.UI
{
    public static class SharedViewLogic
    {
        public static void LoadCandidatesTree(TreeView root, ICandidateInfoRepository candidateRepository)
        {
            try
            {
                root.Nodes.Clear();

                var rootDirectory = new DirectoryInfo(Helper.GetOrCreateCandidatePath());

                foreach (var directory in rootDirectory.GetDirectories("*", SearchOption.TopDirectoryOnly))
                {
                    var item = new TreeNode { Name = $"{directory.Name}", Text = directory.Name, Tag = "parent" };
                    root.Nodes.Add(item);

                    LoadCandidates(item, directory, candidateRepository);
                }

                root.ExpandAll();
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: LoadCandidatesTree, {Environment.NewLine} Error: {e.Message}{Environment.NewLine}{e}");
            }
        }

        public static void LoadCandidatesGrid(DataGridView dgvCandidates, IEnumerable nodes)
        {
            try
            {
                dgvCandidates.Rows.Clear();

                foreach (TreeNode child in nodes)
                {
                    var info = (CandidateInfo)child.Tag;

                    var index = dgvCandidates.Rows.Add(info.FirstName, info.LastName);
                    dgvCandidates.Rows[index].Tag = info;
                }
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: LoadCandidatesGrid, {Environment.NewLine} Error: {e.Message}{Environment.NewLine}{e}");
            }
        }

        private static void LoadCandidates(TreeNode parent, FileSystemInfo parentDiectory, ICandidateInfoRepository repository)
        {
            foreach (var document in repository.GetAll(parentDiectory.FullName))
            {
                var item = new TreeNode
                {
                    Text = $"{document.LastName} {document.FirstName}",
                    Tag = document
                };

                parent.Nodes.Add(item);
            }
        }

        public static void LoadExamHistory(IEnumerable<ExamInfo> exams, DataGridView dgvExamHistory)
        {
            dgvExamHistory.Rows.Clear();

            foreach (var exam in exams)
            {
                var index = dgvExamHistory.Rows.Add(
                    exam.Category,
                    exam.TakenOn.Date.ToShortDateString(),
                    exam.IncludesTrafficRegulationsTest,
                    exam.IncludesFirstAidTest,
                    exam.IncludesDrivingTest);

                dgvExamHistory.Rows[index].Tag = exam;
                dgvExamHistory.Rows[index].Cells["clmPrint"].Value = "Print";

                dgvExamHistory.Rows[index].Tag = exam;
                dgvExamHistory.Rows[index].Cells["clmDelete"].Value = "Obrisi";
            }
        }
    }
}