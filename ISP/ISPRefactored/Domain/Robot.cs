using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPRefactored.Domain
{
     class Robot: IWorkable
    {
        public void StartWorking()
        {
            Console.WriteLine("Robot started working");
        }
        public void StopWorking()
        {
            Console.WriteLine("Robot Stopped working");
        }
    }
}
