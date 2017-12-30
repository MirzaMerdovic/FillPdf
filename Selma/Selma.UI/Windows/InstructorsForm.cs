using System;
using System.Windows.Forms;
using Selma.Contracts.Entities;
using Selma.DataAccess;

namespace Selma.UI.Windows
{
    public partial class InstructorsForm : Form
    {
        private readonly IInstructorRepository _repository;

        public InstructorsForm(IInstructorRepository repository)
        {
            InitializeComponent();

            _repository = repository;
        }

        private void InstructorsForm_Load(object sender, EventArgs e)
        {
            SharedViewLogic.LoadInstructors(dgvInstructors, _repository);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddOrEditInstructorForm(true, null, _repository, dgvInstructors).Show();
        }

        private void DgvInstructors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var instructor = dgvInstructors.Rows[e.RowIndex].Tag as Instructor;

            new AddOrEditInstructorForm(false, instructor, _repository, dgvInstructors).Show();
        }
    }
}