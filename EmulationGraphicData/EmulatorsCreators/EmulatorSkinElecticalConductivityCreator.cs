using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulationGraphicData
{
    class EmulatorSkinElecticalConductivityCreator : IEmulatorCreator
    {
        public EmulatorSkinElecticalConductivityCreator()
            : base()
        {
        }

        public IEmulator create(IDoctorPatientSurveyPresenterEmulator presenter, int surveyIndex)
        {
            return new EmulatorSkinElecticalConductivity(presenter, surveyIndex);
        }
    }
}
