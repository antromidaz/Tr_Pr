using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Repository
{
    public class BasicRepository
    {
        //Temporary variable, emulates database until I make a real database
        private List<patientFull> database;

        //Constructor of the class
        public BasicRepository()
        {
            database = new List<patientFull>();
            createDatabase();
        }

        //Function that adds new informarion to database
        public void add(patientFull data)
        {
            database.Add(data);
        }

        //Function that deletes info from database, using full info
        public void delete(patientFull data)
        {
            database.Remove(data);
        }

        //Function that deletes info from database, using limited info
        public void delete(patientLimited data)
        {
            database.Remove(searchPatient(data));
        }

        //Function that deletes info from database, using full id
        public void delete(int id)
        {
            database.Remove(searchPatient(id));
        }

        //Function that returns all database, consisting of full info
        public IEnumerable<patientFull> getAllFullDatabase()
        {
            return database;
        }

        //Function that returns all database, consisting of limited info
        public IEnumerable<patientLimited> getAllLimitedDatabase()
        {
            int databaseSize = database.Count<patientFull>();
            patientLimited[] toReturn = new patientLimited[databaseSize];
            int i = 0;
            foreach (patientFull element in database)
            {
                toReturn[i].id = element.id;
                toReturn[i].name = element.name;
                toReturn[i].surname = element.surname;
                toReturn[i].middlename = element.middlename;
                i++;
            }
            return toReturn;
        }

        //Function that returns full info, using a limimited one
        public patientFull getPatientFullDatabase(patientLimited data)
        {
            return searchPatient(data);
        }

        //Function that returns full info, using an id
        public patientFull getPatientFullDatabase(int id)
        {
            return searchPatient(id);
        }

        //Function that returns limited info, using an id
        public patientLimited getPatientLimitedDatabase(int id)
        {
            patientLimited toReturn;
            patientFull findedPatient = searchPatient(id);
            toReturn.id = id;
            toReturn.name = findedPatient.name;
            toReturn.surname = findedPatient.surname;
            toReturn.middlename = findedPatient.middlename;
            return toReturn;
        }

        public void changePatientFull(patientFull data)
        {
            try
            {
                database[searchPatientForIndex(data.id)] = data;
            }
            catch
            {
                Console.WriteLine("ReposiroryError: indexError");
            }
        }

        //Create database for emulating, until I make a real one
        private void createDatabase()
        {
            patientFull patient0;
            patient0.id = 1;
            patient0.name = "Ivan";
            patient0.surname = "Ivanov";
            patient0.middlename = "Ivanovich";
            patient0.surveys = new List<patientFull.Survey>();
            patientFull.Survey survey00;
            survey00.type = "Strengh";
            survey00.date = "01.01.2020";
            survey00.id = 1;
            survey00.sensors.sensor1 = true;
            survey00.sensors.sensor2 = false;
            survey00.sensors.sensor3 = false;
            survey00.sensors.sensor4 = false;
            survey00.sensors.sensor5 = false;
            patientFull.Survey survey01;
            survey01.type = "Run";
            survey01.date = "01.02.2020";
            survey01.id = 2;
            survey01.sensors.sensor1 = false;
            survey01.sensors.sensor2 = true;
            survey01.sensors.sensor3 = false;
            survey01.sensors.sensor4 = false;
            survey01.sensors.sensor5 = false;
            patient0.surveys.Add(survey00);
            patient0.surveys.Add(survey01);

            patientFull patient1;
            patient1.id = 2;
            patient1.name = "Petr";
            patient1.surname = "Petrov";
            patient1.middlename = "Petrovich";
            patient1.surveys = new List<patientFull.Survey>();
            patientFull.Survey survey10;
            survey10.type = "Walk";
            survey10.date = "01.01.2020";
            survey10.id = 1;
            survey10.sensors.sensor1 = true;
            survey10.sensors.sensor2 = false;
            survey10.sensors.sensor3 = false;
            survey10.sensors.sensor4 = false;
            survey10.sensors.sensor5 = false;
            patientFull.Survey survey11;
            survey11.type = "Run";
            survey11.date = "02.02.2020";
            survey11.id = 2;
            survey11.sensors.sensor1 = false;
            survey11.sensors.sensor2 = true;
            survey11.sensors.sensor3 = false;
            survey11.sensors.sensor4 = false;
            survey11.sensors.sensor5 = false;
            patient1.surveys.Add(survey10);
            patient1.surveys.Add(survey11);

            add(patient0);
            add(patient1);
        }

        //Search patient in database, returning full info and using id
        private patientFull searchPatient(int id)
        {
            foreach (patientFull element in database)
            {
                if (element.id == id)
                {
                    return element;
                }
            }
            return new patientFull();
        }
        
        //Search patient in database, returning full info and using limited info
        private patientFull searchPatient(patientLimited data)
        {
            foreach (patientFull element in database)
            {
                if (element.id == data.id)
                {
                    return element;
                }
            }
            return new patientFull();
        }

        private int searchPatientForIndex(int id)
        {
            int i = 0;
            foreach (patientFull element in database)
            {
                if (element.id == id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}