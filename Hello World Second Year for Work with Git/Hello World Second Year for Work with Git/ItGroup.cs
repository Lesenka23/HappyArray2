using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World_Second_Year_for_Work_with_Git
{
    internal class ItGroup
    {
        private string _name;
        private int _studentsCount;
        private string _specialization;

        public ItGroup(string name, int studentsCount, string specialization)
        {
            _name = name;
            _studentsCount = studentsCount;
            _specialization = specialization;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Group name: {_name}");
            Console.WriteLine($"Students count: {_studentsCount}");
            Console.WriteLine($"Specialization: {_specialization}");
        }
    }
}
