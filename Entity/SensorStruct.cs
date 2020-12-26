using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public struct SensorStruct
    {
        public String name;
        public String type;
        public bool condition; //false - bad condition, true - sensor is ok
    }
}
