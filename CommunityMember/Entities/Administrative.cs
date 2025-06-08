using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMember.Entities
{
    public class Administrative: Employee
    {
        public string Position { get; set; }
        public string OfficeExtension { get; set; }
        public string WorkSchedule { get; set; }
        public string InstitutionalEmail { get; set; }
        public string DirectSupervisor { get; set; }
        public Administrative(string Name, int Age) : base(Name, Age) { }

        public void ShowInformation()
        {
            base.InformationMember();
            Console.WriteLine($"Posicion: {Position}");
            Console.WriteLine($"Extension: {OfficeExtension}");
            Console.WriteLine($"Schedule: {WorkSchedule}");
            Console.WriteLine($"Email: {InstitutionalEmail}");
            Console.WriteLine($"Supervisor: {DirectSupervisor}");
        }
    }
}
