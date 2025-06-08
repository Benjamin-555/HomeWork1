using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMember.Entities
{
    public class Employee : CommunityMember1
    {
        public int Departament { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string Name, int Age) : base(Name, Age) { }

        public void ShowInformation()
        {
            base.InformationMember();
            Console.WriteLine($"Departamento: {Departament}");
            Console.WriteLine($"Fecha de ingreso: {HireDate}");
        }
    }
}
