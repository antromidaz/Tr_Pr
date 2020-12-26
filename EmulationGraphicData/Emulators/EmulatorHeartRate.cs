using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmulationGraphicData
{
    public class EmulatorHeartRate : IEmulator
    {
        IDoctorPatientSurveyPresenterEmulator _presenter;
        Thread _writingThread;
        int _surveyIndex;
        bool emulatingIsGoing;

        public EmulatorHeartRate(IDoctorPatientSurveyPresenterEmulator presenter, int surveyIndex)
        {
            _presenter = presenter;
            _surveyIndex = surveyIndex;
            emulatingIsGoing = false;
        }

        public void startWritingGraphic()
        {
            _writingThread = new Thread(writingFunction);
            emulatingIsGoing = true;
            _writingThread.Start();
        }

        public void stopWritingGraphic()
        {
            emulatingIsGoing = false;
        }

        private void writingFunction()
        {
            double x = 0;
            double y;
            Random random = new Random(_surveyIndex + (new Random()).Next());
            while (emulatingIsGoing)
            {
                x += 0.1;
                y = random.NextDouble() * 120 + 60;  //from 60 to 180
                _presenter.addDotToChart(x, y, _surveyIndex);
                Thread.Sleep(1000);
            }
        }
    }
}
