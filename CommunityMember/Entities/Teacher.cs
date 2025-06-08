using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMember.Entities;

public class Teacher : Employee
{
    public string ExpertiseArea { get; set; }
    public string InstitutionalEmail { get; set; }
    public string OfficeExtension { get; set; }

    public Teacher(string Name, int Age) : base(Name, Age) { }

    public void ShowInformation()
    {
        base.InformationMember();
        Console.WriteLine($"Expero en el area de: {ExpertiseArea}");
        Console.WriteLine($"Email: {InstitutionalEmail}");
        Console.WriteLine($"Extension: {OfficeExtension}");
    }
}
