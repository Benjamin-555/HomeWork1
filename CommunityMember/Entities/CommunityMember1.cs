using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityMember.Entities
{
    public class CommunityMember1
    {
        private static int _idCounter = 3;
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public CommunityMember1(string Name, int Age)
        {
            Id = _idCounter++;
            this.Name = Name;
            this.Age = Age;
        }
        public void InformationMember()
        {
            Console.WriteLine($"Nombre: {Name} | Edad: {Age} | ID: {Id}");
        }
    }
}
