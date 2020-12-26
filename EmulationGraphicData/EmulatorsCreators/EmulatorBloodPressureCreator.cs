using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulationGraphicData
{
    class EmulatorBloodPressureCreator : IEmulatorCreator
    {
        public EmulatorBloodPressureCreator()
            : base()
        {
        }

        public IEmulator create(IDoctorPatientSurveyPresenterEmulator presenter, int surveyIndex)
        {
            return new EmulatorBloodPressure(presenter, surveyIndex);
        }
    }
}
