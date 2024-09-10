using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRecords;

namespace StudentRecords
{
    public partial class AddStudentForm : Form
    {
        public Student Student { get; private set; }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student = new Student
            {
                FirstName = txtBoxFirst.Text,
                MiddleName = txtBoxMiddle.Text,
                LastName = txtBoxLast.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Email = txtBoxEmail.Text,
                StatusInCanada = cmbStatus.SelectedItem.ToString(),
                Address = txtBoxAddress.Text,
                PhoneNumber = txtBoxPhone.Text
            };

            foreach (DataGridViewRow row in dgvAcademicRecords.Rows)
            {
                if (row.IsNewRow) continue; 

                try
                {
                    string courseName = row.Cells["Course"].Value.ToString();
                    int mark = int.Parse(row.Cells["Mark"].Value.ToString());
                    int credit = int.Parse(row.Cells["Credit"].Value.ToString());

                    Student.MarksAndCredits.Add(new MarkCredit(mark, credit));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing row: {ex.Message}");
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvAcademicRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
