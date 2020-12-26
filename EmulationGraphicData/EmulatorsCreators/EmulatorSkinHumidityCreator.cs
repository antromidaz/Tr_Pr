using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulationGraphicData
{
    class EmulatorSkinHumidityCreator : IEmulatorCreator
    {
        public EmulatorSkinHumidityCreator()
            : base()
        {
        }

        public IEmulator create(IDoctorPatientSurveyPresenterEmulator presenter, int surveyIndex)
        {
            return new EmulatorSkinHumidity(presenter, surveyIndex);
        }
    }
}
