using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemoConsole
{
    public static class Subscribers
    {
        public static void EnrollmentFullAlert(object sender, Student e)
        {

            var senderObj = (BootCamp)sender;
            Console.WriteLine($"Sorry Admission is full for {senderObj.Subject} .So cannot wee cannot admit you {e.Name} ");
        }
    }
}
