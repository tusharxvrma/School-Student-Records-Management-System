using System;

namespace StudentRecords
{
    public class MarkCredit
    {
        public int Mark { get; set; }
        public int Credit { get; set; }

        public MarkCredit(int mark, int credit)
        {
            Mark = mark;
            Credit = credit;
        }
    }
}

