using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem._4_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>();
            string input = Console.ReadLine();

            while (input != "Output")
            {
                string[] tokens = input.Split();

                string department = tokens[0];
                string doctor = tokens[1] + " " + tokens[2];
                string patientName = tokens[3];
                int room = patients
                    .Count(p => p.Department == department) / 3 + 1;

                patients.Add(new Patient(department, doctor, patientName, room));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();

                if (tokens.Length == 1)
                {
                    foreach (Patient patient in patients
                        .Where(p => p.Department == tokens[0]))
                    {
                        Console.WriteLine(patient.PatientName);
                    }
                }
                else
                {
                    if (int.TryParse(tokens[1], out int room))
                    {
                        foreach (Patient patient in patients
                            .Where(p => p.Department == tokens[0] &&
                            p.Room == room).OrderBy(p => p.PatientName))
                        {
                            Console.WriteLine(patient.PatientName);
                        }
                    }
                    else
                    {
                        foreach (Patient patient in patients
                            .Where(p => p.Doctor == tokens[0] + " " + tokens[1])
                            .OrderBy(p => p.PatientName))
                        {
                            Console.WriteLine(patient.PatientName);
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }
    }

    public class Patient
    {
        public Patient(string department, string doctor, string patientName, int room)
        {
            this.Department = department;
            this.Doctor = doctor;
            this.PatientName = patientName;
            this.Room = room;
        }

        public string Department { get; set; }

        public string Doctor { get; set; }

        public string PatientName { get; set; }

        public int Room { get; set; }
    }
}
