using CommunityMember.Entities;

namespace HomeWork1;
internal class Program
{
    private static void Main(string[] args)
    {
        //Nombre: Geovanny Benjamin Beato Nivar
        //Matricula: 2023-1079
        //Tarea: Crear app con conceptos de programacion orientada a objetos

        // Creacion de entidades:

        var estudiante1 = new Student("Benjamin", 20);
        estudiante1.Career = "Software Delepment";
        estudiante1.StudentEnrollment = 2023192;
        estudiante1.InstitutionalEmail = "Example@gmail.com";
        estudiante1.Semester = 5;
        estudiante1.IsActive = true;
        estudiante1.ShowInformation();

        Console.WriteLine("");

        var graduado = new FormerStudent("Jose", 20);
        graduado.GraduationDate = DateTime.Now;
        graduado.DegreeEarned = "Desarrollador de software";
        graduado.ShowInformation();

        Console.WriteLine("");

        var postulante = new Employee("Pedro", 30);
        postulante.HireDate = DateTime.Now;
        postulante.Departament = 1;
        postulante.ShowInformation();

        Console.WriteLine("");

        var empleado1 = new Teacher("Pedro", 30);
        empleado1.ExpertiseArea = "Matematicas";
        empleado1.InstitutionalEmail = "example@gmail.com";
        empleado1.ShowInformation();

        Console.WriteLine("");

        var administracion = new Administrative("Ana", 25);
        administracion.Position = "Secretaria";
        administracion.WorkSchedule = "8:00 AM - 4:00 PM";
        administracion.InstitutionalEmail = "example@gmail.com";
        administracion.OfficeExtension = "314";
        administracion.DirectSupervisor = "Jose Ramirez";
        administracion.ShowInformation();

        Console.ReadKey();
    }
}