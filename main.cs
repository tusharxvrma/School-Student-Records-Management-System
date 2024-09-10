using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StudentRecords; 

namespace StudentRecords
{
    public partial class MainForm : Form
    {
        private List<Student> students;

        public MainForm()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            using (var addStudentForm = new AddStudentForm())
            {
                if (addStudentForm.ShowDialog() == DialogResult.OK)
                {
                    students.Add(addStudentForm.Student); 
                }
            }
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No student data available to calculate reports.");
                return;
            }

            double totalMarksSum = 0;
            int totalCredits = 0;
            List<double> marksList = new List<double>();

            foreach (var student in students)
            {
                foreach (var item in student.MarksAndCredits) 
                {
                    double mark = item.Mark;
                    int credit = item.Credit;

                    totalMarksSum += mark * credit;
                    totalCredits += credit;
                    marksList.Add(mark);
                }
            }

            double mean = totalCredits > 0 ? totalMarksSum / totalCredits : 0.0;

            // Calculate standard deviation
            double sumOfSquares = 0.0;
            foreach (double mark in marksList)
            {
                sumOfSquares += Math.Pow(mark - mean, 2);
            }
            double standardDeviation = marksList.Count > 1 ? Math.Sqrt(sumOfSquares / (marksList.Count - 1)) : 0.0;

            MessageBox.Show($"Mean of Marks: {mean:F2}\nStandard Deviation: {standardDeviation:F2}",
                            "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var student in students)
                    {
                        writer.WriteLine($"{student.FirstName},{student.MiddleName},{student.LastName},{student.DateOfBirth},{student.Email},{student.StatusInCanada},{student.Address},{student.PhoneNumber}");

                        foreach (var record in student.MarksAndCredits)
                        {
                            writer.WriteLine($"{record.Mark},{record.Credit}");
                        }

                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Data saved successfully!");
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                students.Clear();

                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    Student student = null;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            if (student != null)
                            {
                                students.Add(student);
                                student = null;
                            }
                        }
                        else
                        {
                            var data = line.Split(',');

                            if (data.Length == 8)
                            {
                                student = new Student
                                {
                                    FirstName = data[0],
                                    MiddleName = data[1],
                                    LastName = data[2],
                                    DateOfBirth = DateTime.Parse(data[3]),
                                    Email = data[4],
                                    StatusInCanada = data[5],
                                    Address = data[6],
                                    PhoneNumber = data[7]
                                };
                            }
                            else if (data.Length == 2 && student != null)
                            {
                                int mark = int.Parse(data[0]);
                                int credit = int.Parse(data[1]);
                                student.MarksAndCredits.Add(new MarkCredit(mark, credit));
                            }
                        }
                    }

                    if (student != null)
                    {
                        students.Add(student);
                    }
                }

                MessageBox.Show("Data loaded successfully!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

