using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new StudentReport();
            report.AddEntry(new StudentReportEntry { Id = "1", Name = "Lucia M", Subject="Spanish", Grade=78d });
            report.AddEntry(new StudentReportEntry { Id = "1", Name = "Lucia M", Subject="French", Grade= 85d });

            var saver = new FileSaver();
            saver.SaveToFile(@"C:\cursos\csharp\SOLID\SOLID.SRP\Reports", "StudentsReport.txt", report);
        }
    }
}
