using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPRefactored.Domain
{
     class Manager: ICanWorkandEat
    {
        public void StartEating()
        {
            Console.WriteLine("Manager started eating");
        }

        public void StartWorking()
        {
            Console.WriteLine("Manager started working");
        }

        public void StopEating()
        {
            Console.WriteLine("Manager stopped eating");
        }

        public void StopWorking()
        {
            Console.WriteLine("Manager stopped working");
        }
    }
}
