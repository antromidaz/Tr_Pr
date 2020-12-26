using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IMedRegistratorPatientForm
    {
        void fillViewInformation(patientFull data);
        void clearDataGridView();
        void fillSurveyInformation();
        void showError();
        void showOkSaveMessage();
        void showFailedSaveMessage();
    }
}
