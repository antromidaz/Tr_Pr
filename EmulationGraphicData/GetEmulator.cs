using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulationGraphicData
{
    public class GetEmulator
    {
        IEmulator toReturnEmulator;

        public GetEmulator(IDoctorPatientSurveyPresenterEmulator presenter, int index, String type)
        {
            if (type.Equals("Blood pressure"))
            {
                IEmulatorCreator creator = new EmulatorHeartRateCreator();
                toReturnEmulator = creator.create(presenter, index);
            }
            else if (type.Equals("Skin's temperature"))
            {
                IEmulatorCreator creator = new EmulatorSkinTemperatureCreator();
                toReturnEmulator = creator.create(presenter, index);
            }
            else if (type.Equals("Skin's humidity"))
            {
                IEmulatorCreator creator = new EmulatorSkinHumidityCreator();
                toReturnEmulator = creator.create(presenter, index);
            }
            else if (type.Equals("Heart rate"))
            {
                IEmulatorCreator creator = new EmulatorHeartRateCreator();
                toReturnEmulator = creator.create(presenter, index);
            }
            else if (type.Equals("Skin's electrical conductivity"))
            {
                IEmulatorCreator creator = new EmulatorSkinElecticalConductivityCreator();
                toReturnEmulator = creator.create(presenter, index);
            }

        }

        public IEmulator getEmulator()
        {
            return toReturnEmulator;
        }
    }
}
