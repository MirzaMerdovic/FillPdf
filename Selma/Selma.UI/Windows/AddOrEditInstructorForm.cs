using System;
using System.Windows.Forms;
using Selma.Contracts.Entities;
using Selma.DataAccess;

namespace Selma.UI.Windows
{
    public partial class AddOrEditInstructorForm : Form
    {
        private readonly IInstructorRepository _repository;

        private readonly DataGridView _dgvInstructors;

        public AddOrEditInstructorForm(bool isAdd, Instructor instructor, IInstructorRepository repository, DataGridView dgvInstructors)
        {
            InitializeComponent();

            SetControls(isAdd);
            BindData(instructor);

            _repository = repository;
            _dgvInstructors = dgvInstructors;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _repository.Create(new Instructor
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            });

            SharedViewLogic.LoadInstructors(_dgvInstructors, _repository);

            Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            _repository.Update(new Instructor
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            });

            SharedViewLogic.LoadInstructors(_dgvInstructors, _repository);

            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _repository.Delete(txtFirstName.Text.Trim(), txtLastName.Text.Trim());

            SharedViewLogic.LoadInstructors(_dgvInstructors, _repository);

            Close();
        }

        private void SetControls(bool isAdd)
        {
            btnAdd.Visible = btnAdd.Enabled = isAdd;
            btnEdit.Visible = btnEdit.Enabled = !isAdd;
            btnDelete.Visible = btnDelete.Enabled = !isAdd;
        }

        private void BindData(Instructor instructor)
        {
            if (instructor == null)
                return;

            txtFirstName.Text = instructor.FirstName;
            txtLastName.Text = instructor.LastName;
            txtPhone.Text = instructor.Phone;
        }
    }
}