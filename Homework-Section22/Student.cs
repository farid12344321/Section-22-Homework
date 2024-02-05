using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_Section22
{
    internal class Student
    {

        public Student()
        {
            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; set; }
        public string FullName { get; set; }

        public Dictionary<string,double> Exams = new Dictionary<string,double>();
        public override string ToString()
        {
            return $"{No} - {FullName}";
        }
        public void AddExam(string examName,double point)
        {
            Exams.Add(examName, point);
        }
        public double GetExamResult(string examName)
        {
            foreach (var item in Exams)
            {
                if (examName == item.Key)
                {
                    return item.Value;
                }
            }
            return 0;
        }
        public double GetExamAvg()
        {
            int count = 0;
            double sum = 0;
            foreach (var item in Exams)
            {
                count++;
                sum += item.Value;
            }
            return sum / count;
        }
    }
}
