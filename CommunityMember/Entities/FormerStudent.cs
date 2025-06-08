using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMember.Entities
{
    public class FormerStudent: Student
    {
        public DateTime GraduationDate { get; set; }
        public string DegreeEarned { get; set; }

        public FormerStudent(string Name, int Age) : base(Name, Age) { }

        public void ShowInformation()
        {
            base.InformationMember();
            Console.WriteLine($"Fecha de graduacion: {GraduationDate.ToShortDateString()}");
            Console.WriteLine($"Grado: {DegreeEarned}");
        }
    }
}

