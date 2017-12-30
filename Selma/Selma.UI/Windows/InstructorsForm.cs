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
            foreach (var instructor in _repository.GetAll())
            {
                var index = dgvInstructors.Rows.Add(
                    instructor.FirstName,
                    instructor.LastName,
                    instructor.Phone);

                dgvInstructors.Rows[index].Tag = instructor;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddOrEditInstructorForm(true, null, _repository).Show();
        }

        private void DgvInstructors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var instructor = dgvInstructors.Rows[e.RowIndex].Tag as Instructor;

            new AddOrEditInstructorForm(false, instructor, _repository).Show();
        }
    }
}