using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMember.Entities
{
    public class Administrator: Teacher
    {
        public string Title { get; set; }
        public int AccessLevel { get; set; }
        public int StaffSupervised { get; set; }
        public Administrator(string Name, int Age) : base(Name, Age) { }

        public void ShowInformation()
        {
            base.InformationMember();
            Console.WriteLine($"Titulo: {Title}");
            Console.WriteLine($"Nivel de acceso: {AccessLevel}");
            Console.WriteLine($"Personal supervisado: {StaffSupervised}");

        }
    }
}
