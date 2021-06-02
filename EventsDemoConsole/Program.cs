using System;


namespace EventsDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BootCamp fullStackEngineer = new BootCamp("C# & Angular Fullstack", 2);
            
            fullStackEngineer.EnrollmentFull += Subscribers.EnrollmentFullAlert;
            fullStackEngineer.AdmitStudents(new Student { Name = "Saraswoti" });
            fullStackEngineer.AdmitStudents(new Student { Name = "Tulasi" });
            fullStackEngineer.AdmitStudents(new Student { Name = "Niraj" });
            fullStackEngineer.AdmitStudents(new Student { Name = "Nirajala" });


            BootCamp frontendEngineer = new BootCamp("Angular Frontend Dev", 3);

            frontendEngineer.EnrollmentFull += Subscribers.EnrollmentFullAlert;
            frontendEngineer.AdmitStudents(new Student { Name = "Saras" });
            frontendEngineer.AdmitStudents(new Student { Name = "Tula" });
            frontendEngineer.AdmitStudents(new Student { Name = "Nira" });
            frontendEngineer.AdmitStudents(new Student { Name = "Nirajl" });

        }

        
    }
}


