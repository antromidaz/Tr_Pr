using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulationGraphicData
{
    public interface IEmulatorCreator
    {
        IEmulator create(IDoctorPatientSurveyPresenterEmulator presenter, int surveyIndex);
    }
}
