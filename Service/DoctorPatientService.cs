using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DoctorPatientService : BaseService
    {
        BasicRepository _repository;
        patientFull _patient;

        public DoctorPatientService(int id)
        {
            _repository = repository;
            _patient = copyPatient(_repository.getPatientFullDatabase(id));
        }

        public patientFull getPatient()
        {
            return _patient;
        }

        public patientFull.Survey getSurvey(int id)
        {
            return searchSurvey(id);
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
