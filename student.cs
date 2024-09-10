using System;
using System.Collections.Generic;

namespace StudentRecords
{
    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string StatusInCanada { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public List<MarkCredit> MarksAndCredits { get; set; }  

        public Student()
        {
            MarksAndCredits = new List<MarkCredit>();
        }

        public int TotalCreditsPassed()
        {
            int totalCredits = 0;
            foreach (var item in MarksAndCredits)
            {
                totalCredits += item.Credit;
            }
            return totalCredits;
        }

        public double AverageMark()
        {
            int totalMarks = 0;
            int totalCredits = 0;

            foreach (var item in MarksAndCredits)
            {
                totalMarks += item.Mark * item.Credit;
                totalCredits += item.Credit;
            }

            return totalCredits > 0 ? (double)totalMarks / totalCredits : 0.0;
        }
    }
}
