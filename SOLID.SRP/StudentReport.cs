using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SOLID.SRP
{
    public class StudentReport
    {
        private List<StudentReportEntry> _entries;

        public StudentReport()
        {
            _entries = new List<StudentReportEntry>();
        }

        public void AddEntry(StudentReportEntry entry) => _entries.Add(entry);

        public void RemoveEntry(int index) => _entries.RemoveAt(index);

       public override string ToString() => string.Join(Environment.NewLine,
            _entries.Select(x => $"StudentId: {x.Id}, Student Name: {x.Name}, Subject: {x.Subject}, Grade: {x.Grade}"));
    }

}