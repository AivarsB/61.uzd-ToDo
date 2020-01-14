using System;
using System.Collections.Generic;
using System.Text;

namespace _61.uzd_ToDo
{
    class ToDo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public WeekDayEnum WeekDay { get; set; }
        public bool Done { get; set; }
    }
}
// Izveidot jaunu klasi ToDo, kurā ir proprties: 
// Name, Description, WeekDay (šis properties ir ar datu tipu WeekDayEnum), Done (bool). 