using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IDoctorPatientForm
    {
        void fillViewInformation(patientFull data);
        void fillSurveyInformation();
        void clearDataGridView();
        void callDoctorPatientSurveyForm(patientFull.Survey survey);
    }
}
