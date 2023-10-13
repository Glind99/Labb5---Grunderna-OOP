using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Labb5___Grunderna_OOP
{
    public class Circle //Class for circel
    {
        public float _pi = 3.141f;
        public int _radie;
       

        public Circle(int radie) //Constructor
        {
            _radie = radie;
        }
        public float getArea() //Method to calculate the Area on a circel and return in so we can call it in the main method
        {
            float area = _radie * _radie * _pi; 

            return area;
        }
        public float getOmkrets() //method to calculate the circumference and return it
        {
            float omkrets = _radie * 2 * _pi;
            return omkrets;
        }
    }
}
