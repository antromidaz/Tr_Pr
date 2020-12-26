using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class EnterPresenter
    {
        private int _chooseEnterType; //0 - no one is choosed, 1 - MedRegistrator is choosed, 2 - Doctor is choosed
        private IEnterForm _view;

        public EnterPresenter(IEnterForm view)
        {
            _view = view;
            _chooseEnterType = 0;
        }

        public void changeChooseEnterType(String radioButtonName)
        {
            if (radioButtonName == "MedRegistratorRadioButton")
            {
                _chooseEnterType = 1;
            }
            else
            {
                _chooseEnterType = 2;
            }
        }

        public void callForm()
        {
            if (_chooseEnterType == 0)
            {
                _view.showErrorMessage();
            }
            else if (_chooseEnterType == 1)
            {
                _view.callMedRegistratorForm();
            }
            else
            {
                _view.callDoctorForm();
            }
        }

        public void initView()
        {
        }

    }
}
