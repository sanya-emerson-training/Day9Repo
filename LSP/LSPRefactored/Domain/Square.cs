using LSPRefactored.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolation.Domain
{
    class Square : IPolygon
    {
        private int _side;
        public Square(int side)
        { 
        _side = side;
        }

        public void SetSide(int side) 
        {
            _side = side;
        }

     
        public int CalculateArea()
        {
            return _side * _side;
        }
    }
}
