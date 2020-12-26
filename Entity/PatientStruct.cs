using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public struct patientFull
    {
        public int id;
        public String name;
        public String surname;
        public String middlename;
        public struct Survey
        {
            public int id;
            public String type;
            public String date;
            public struct Sensors
            {
                public bool sensor1;
                public bool sensor2;
                public bool sensor3;
                public bool sensor4;
                public bool sensor5;
            }
            public Sensors sensors;
        }
        public List<Survey> surveys;
    }

    //Public struct, that describes patient's id, name, surname, middlename
    public struct patientLimited
    {
        public int id;
        public String name;
        public String surname;
        public String middlename;
    }
}
