using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuition_Fee_Calculator
{
    class Student
    {
        public double Tuition { get; set; }
        public string StudentName { get; set; }
        public string Status { get; set; }
        public double miscellanous { get; set; }
        public int Year { get; set; }
        public int Units;
        private double TotalTuition;

        public Student()
        {
            Tuition = 0;
            StudentName = "";
            Status = "Athlete";
            Year = 0;
            Units = 0;
            miscellanous = 0;
        }

        public Student(double Tui, string sn, string stat, int y, int u, double misc)
        {
            Tuition = Tui;
            StudentName = sn;
            Status = stat;
            Year = y;
            Units = u;
            miscellanous = misc;
        }

        public Student(Student stud)
        {
            Tuition = stud.Tuition;
            StudentName = stud.StudentName;
            Status = stud.Status;
            Year = stud.Year;
            Units = stud.Units;
            miscellanous = stud.miscellanous;
        }

        ~Student()
        { 
            
        }

        private void calcMisc()
        {
            if (Year == 1) miscellanous += 1000;
            else if (Year == 2 && Year == 5) miscellanous += 2000;
            else if (Year == 3) miscellanous += 3000;
            else if (Year == 4) miscellanous += 4000;
        }

        private void calcStatus()
        {
            if (Status == "Regular")
            {
                Tuition = (Units * 600);
            }
            else if (Status == "Athlete")
            {
                Tuition = (Units * 600) / 2;
            }
            else if (Status == "Scholar")
            {
                Tuition = 0;
            }
        }

        public string getStatus()
        {
            calcStatus();
            return Status;
        }

        public double getTotalTuition()
        { 
            calcTotalTuition();
            return TotalTuition;
        }

        private void calcTotalTuition()
        {
            calcMisc();
            calcStatus();

            TotalTuition = Tuition + miscellanous;
        }
    }
}
