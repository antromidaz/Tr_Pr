using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulationGraphicData
{
    class EmulatorHeartRateCreator : IEmulatorCreator
    {
        public EmulatorHeartRateCreator()
            : base()
        {
        }

        public IEmulator create(IDoctorPatientSurveyPresenterEmulator presenter, int surveyIndex)
        {
            return new EmulatorHeartRate(presenter, surveyIndex);
        }
    }
}
