using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CommunityMember.Entities
{
    public class Student : CommunityMember1
    {
        public int StudentEnrollment { get; set; }
        public int Semester { get; set; }
        public string Career { get; set; }
        public string InstitutionalEmail { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsActive { get; set; }
        public Student(string Name, int Age) : base(Name, Age) {  }

        public void ShowInformation()
        {
            base.InformationMember();
            Console.WriteLine($"Matricula: {StudentEnrollment}");
            Console.WriteLine($"Carrera: {Career}");
            Console.WriteLine($"Semestre: {Semester}");
            Console.WriteLine($"Email: {InstitutionalEmail}");
            Console.WriteLine($"Fecha de ingreso: {DateTime.ToShortDateString()}");
            Console.WriteLine($"Estado: {(IsActive ? "Activo" : "Inactivo")}");
        }
    }
}
