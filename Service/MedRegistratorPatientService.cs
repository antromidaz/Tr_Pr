using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entity;

namespace Service
{
    public class MedRegistratorPatientService : BaseService
    {
        BasicRepository _repository;
        patientFull _patient;
        bool _newPatient;
        bool _succesfullPatientInfoSaving;

        public MedRegistratorPatientService(int id)
        {
            _repository = repository;
            _patient = copyPatient(_repository.getPatientFullDatabase(id));
            _newPatient = false;
            _succesfullPatientInfoSaving = false;
        }

        public MedRegistratorPatientService()
        {
            _repository = repository;
            _patient = new patientFull();
            _patient.surveys = new List<patientFull.Survey>();
            _newPatient = true;
            _succesfullPatientInfoSaving = false;
        }

        public patientFull getPatient()
        {
            return _patient;
        }

        public void savePatient()
        {
            if (_newPatient == true)
            {
                addPatient();
            }
            else
            {
                changePatient();
            }
        }

        public void deleteSurvey(int id)
        {
            try
            {
                _patient.surveys.Remove(searchSurvey(id));
            }
            catch
            {
            }
        }

        public patientFull.Survey getSurvey(int id)
        {
            return searchSurvey(id);
        }

        public void changeSurvey(int id, String date, String type, patientFull.Survey.Sensors sensors)
        {
            patientFull.Survey surveyToChange;
            surveyToChange.id = id;
            surveyToChange.date = date;
            surveyToChange.type = type;
            surveyToChange.sensors = sensors;
            try
            {
                _patient.surveys[searchSurveyForIndex(id)] = surveyToChange;
            }
            catch
            {
                Console.WriteLine("MedRegistratorPatientServiceError: indexError");
            }
        }

        public void createSurvey(String date, String type, patientFull.Survey.Sensors sensors)
        {
            patientFull.Survey newSurvey;
            newSurvey.id = calculateSurveyId(date, type, sensors);
            newSurvey.date = date;
            newSurvey.type = type;
            newSurvey.sensors = sensors;
            _patient.surveys.Add(newSurvey);
        }

        public void setName(String name)
        {
            _patient.name = name;
        }

        public void setSurname(String surname)
        {
            _patient.surname = surname;
        }

        public void setMiddlename(String middlename)
        {
            _patient.middlename = middlename;
        }

        public bool getPatientInfoSaving()
        {
            return _succesfullPatientInfoSaving;
        }

        private patientFull.Survey searchSurvey(int id)
        {
            foreach (var element in _patient.surveys)
            {
                if (element.id == id)
                {
                    return element;
                }
            }
            return new patientFull.Survey();
        }

        private int searchSurveyForIndex(int id)
        {
            int i = 0;
            foreach (var element in _patient.surveys)
            {
                if (element.id == id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private int calculateSurveyId(String date, String type, patientFull.Survey.Sensors sensors)
        {
            int dateHash;
            int typeHash;
            int sensorsHash;
            try
            {
                dateHash = date.GetHashCode();
            }
            catch
            {
                dateHash = 0;
            }
            try
            {
                typeHash = type.GetHashCode();
            }
            catch
            {
                typeHash = 0;
            }
            try
            {
                sensorsHash = sensors.GetHashCode();
            }
            catch
            {
                sensorsHash = 0;
            }
            return dateHash + typeHash + sensorsHash;
        }

        private int calculatePatientId(String name, String surname, String middlename)
        {
            return name.GetHashCode() + surname.GetHashCode() + middlename.GetHashCode();
        }

        private void changePatient()
        {
            try
            {
                _repository.changePatientFull(_patient);
                _succesfullPatientInfoSaving = true;
            }
            catch
            {
                _succesfullPatientInfoSaving = false;
            }
        }

        private void addPatient()
        {
            try
            {
                _patient.id = calculatePatientId(_patient.name, _patient.surname, _patient.middlename);
                _repository.add(_patient);
                _newPatient = false;
                _succesfullPatientInfoSaving = true;
            }
            catch
            {
                _succesfullPatientInfoSaving = false;
            }
        }


        private patientFull copyPatient(patientFull toCopy)
        {
            patientFull toReturn = new patientFull();
            toReturn.id = toCopy.id;
            toReturn.surname = toCopy.surname;
            toReturn.name = toCopy.name;
            toReturn.middlename = toCopy.middlename;
            toReturn.surveys = new List<patientFull.Survey>();
            foreach (var element in toCopy.surveys)
            {
                toReturn.surveys.Add(element);
            }
            return toReturn;
        }

    }
}
