using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation.Domain
{
     class Robot: IWorker
    {
        public void StartWorking()
        {
            Console.WriteLine("Robot started working");
        }
        public void StopWorking()
        {
            Console.WriteLine("Rbot Stopped working");
        }
        public void StartEating()
        {
            throw new Exception("robot doesn't eat");
        }

        public void StopEating()
        {
             throw new Exception("robot doesn't eat");
        }
    }
}
