using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    class Car
    {
        // Fields

        private string _year;
        private string _make;
        private int _speed;

        // Constructor, initalizies values
        public Car()
        {
            _year = "";
            _make = "";
            _speed = 0;
        }

        // Year Method/Property
        // The value parameter is automatically created by the compiler.
        // It also sets itself as the same data type that the method/property are.
        // Since the compiler automatically creates the "value" parameter
        // we do not need to declare/initalize it. 
        public string GetYear
        {
            set { _year = value; }
            get { return _year;  }
        }

        // Make Method/Property
        public string GetMake
        {
            set { _make = value; }
            get { return _make;  }
        }

        // Speed Method/Property
        // Always initalized to 0
        // The "value" and therefore the "_speed" property are always initalized 0 when the accelerate button is hit
        // As that is what was initalized above and thus never changes. 
        // However at the end of the calculations from Accelerate "GetSpeed" and it's "_speed" property are equal to the reault
        // of said calculations. But are then re initalized to 0 after the accelerate button is hit again. 
        public int GetSpeed
        {
            set { _speed = value; }
            get { return _speed; }
        }

        public int Accelerate(int spdResult)
        {
            // Every iteration of the loop "GetSpeed" is always equal to 0
            // For example:
            // GetSpeed = 0 + 5 + 0 = 0
            // GetSpeed = 0 + 5 + 5 = 10
            // GetSpeed = 0 + 5 + 10 = 15
            // And so on. 
            GetSpeed = GetSpeed + 5 + spdResult;
            return GetSpeed;
        }

        public int Break(int spdResult)
        {
            //GetSpeed = GetSpeed - 5 + spdResult;
            GetSpeed = spdResult - 5 + GetSpeed;
            return GetSpeed;

        }

    }
}
