using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IEnterForm
    {
        void showErrorMessage();
        void callMedRegistratorForm();
        void callDoctorForm();
    }
}
