using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb5___Grunderna_OOP
{
    internal class Triangel //Class for triangle
    {
        public int _Bas;
        public int _Hight;

        public Triangel(int bas, int hight)
        {
            _Bas = bas;
            _Hight = hight;
        }
        
        public float TriangleArea() //method for the area and return in.
        {
            float triangleArea = _Bas * _Hight / 2;
            return triangleArea;
        }


    }
}
