using System;
using System.Collections.Generic;

namespace EventsDemoConsole
{
    public class BootCamp
    {
        private List<Student> studentsList = new List<Student>();
        public string Subject { get; private set; }

        public int MaxNumberOfStudents { get; private set; }

        public EventHandler<Student> EnrollmentFull;
        public BootCamp(string subject, int maxStudents)
        {
            this.Subject = subject;
            this.MaxNumberOfStudents = maxStudents;
        }

        public void AdmitStudents(Student student)
        {
            if(studentsList.Count >= MaxNumberOfStudents)
            {
                EnrollmentFull.Invoke(this, student);
            }
            else
            {
                studentsList.Add(student);
            }
            
        }
    }
}


