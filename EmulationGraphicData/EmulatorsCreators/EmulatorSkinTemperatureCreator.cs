using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulationGraphicData
{
    class EmulatorSkinTemperatureCreator : IEmulatorCreator
    {
        public EmulatorSkinTemperatureCreator()
            : base()
        {
        }

        public IEmulator create(IDoctorPatientSurveyPresenterEmulator presenter, int surveyIndex)
        {
            return new EmulatorSkinTemperature(presenter, surveyIndex);
        }
    }
}
