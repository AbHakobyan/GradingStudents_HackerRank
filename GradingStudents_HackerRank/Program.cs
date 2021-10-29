using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents_HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 84, 94, 21, 0, 18, 100, 18, 62, 30, 61, 53, 0, 43, 2, 29, 53, 61, 40, 14 };
            List<int> caps = gradingStudents(list);
            foreach (var item in caps)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> list = new List<int> { 40,45,50,55,60,65,70,75,80,85,90,95,100,105};
            List<int> caps = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] > grades[i])
                    {
                        if (list[j] - grades[i] < 3)
                        {
                            caps.Add(list[j]);
                            break;
                        }
                        else
                        {
                            caps.Add(grades[i]);
                            break;
                        }
                    }
                }
            }
            return caps;
        }
    }
}
