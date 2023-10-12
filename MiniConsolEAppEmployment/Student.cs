using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsolEAppEmployment
{
    public class Student : Human
    {
        public int Grade { get; set; }
        public int GroupNo { get; set; }

        public Student(string name, string surname, int age, int grade, int groupNo)
            : base(name, surname, age)
        {
            this.Grade = grade;
            this.GroupNo = groupNo;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Sinif: {this.Grade}, Qrup: {this.GroupNo}");
        }
    }

}
