using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Entity;

namespace Presenter
{
    public class DoctorPatientPresenter
    {
        DoctorPatientService _service;
        IDoctorPatientForm _view;
        public byte _radioButtonValue;
        public CheckBoxCounter _checkBoxCounter;
        public String _dateTextboxValue;

        public DoctorPatientPresenter(IDoctorPatientForm view, int id)
        {
            _service = new DoctorPatientService(id);
            _view = view;
            _checkBoxCounter = new CheckBoxCounter();
        }

        public void initView()
        {
            _view.fillViewInformation(_service.getPatient());
            _radioButtonValue = 0;
        }

        public void reloadView()
        {
            _view.clearDataGridView();
            initView();
        }

        public void getSurvey(int id)
        {
            patientFull.Survey survey = _service.getSurvey(id);
            calculate_radioButtonValue(survey);
            calculate_checkBoxValue(survey.sensors);
            _dateTextboxValue = survey.date;
            _view.fillSurveyInformation();
        }

        public void callDoctorPatientSurveyForm(int id)
        {
            _view.callDoctorPatientSurveyForm(_service.getSurvey(id));
        }

        private void calculate_checkBoxValue(patientFull.Survey.Sensors data)
        {
            _checkBoxCounter.setNullValue();
            if (data.sensor1 == true)
            {
                _checkBoxCounter.changeValueCheckBox(1);
            }
            if (data.sensor2 == true)
            {
                _checkBoxCounter.changeValueCheckBox(2);
            }
            if (data.sensor3 == true)
            {
                _checkBoxCounter.changeValueCheckBox(3);
            }
            if (data.sensor4 == true)
            {
                _checkBoxCounter.changeValueCheckBox(4);
            }
            if (data.sensor5 == true)
            {
                _checkBoxCounter.changeValueCheckBox(5);
            }
        }

        private void calculate_radioButtonValue(patientFull.Survey data)
        {
            if (data.type.Equals("Run"))
            {
                _radioButtonValue = 1;
            }
            else if (data.type.Equals("Walk"))
            {
                _radioButtonValue = 2;
            }
            else if (data.type.Equals("Strengh"))
            {
                _radioButtonValue = 3;
            }
        }

        private String calculateServiceType()
        {
            if (_radioButtonValue == 1)
            {
                return "Run";
            }
            else if (_radioButtonValue == 2)
            {
                return "Walk";
            }
            else if (_radioButtonValue == 3)
            {
                return "Strengh";
            }
            return null;
        }

        private patientFull.Survey.Sensors calculateServiceSensors()
        {
            patientFull.Survey.Sensors sensors;
            sensors.sensor1 = _checkBoxCounter.getValueCheckBox(1);
            sensors.sensor2 = _checkBoxCounter.getValueCheckBox(2);
            sensors.sensor3 = _checkBoxCounter.getValueCheckBox(3);
            sensors.sensor4 = _checkBoxCounter.getValueCheckBox(4);
            sensors.sensor5 = _checkBoxCounter.getValueCheckBox(5);
            return sensors;
        }
    }
}
