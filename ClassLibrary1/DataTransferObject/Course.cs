using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasusAutomationFramework.DataTransferObject
{
    public class Course 
    {
        public enum coursetypenum 
        {
            MyItLabAuthoredCourse =1,
            MyItLabSIM5MasterCourse = 2
        }

        public coursetypenum coursetype { get ; set;}
        public String name { get; set; }
        public String isCreated { get; set; }
    }

    }
