using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Entity;

namespace Presenter
{
    public class DoctorPresenter
    {
        private IDoctorForm _view;
        private DoctorService _service;

        public DoctorPresenter(IDoctorForm view)
        {
            _view = view;
            _service = new DoctorService();
        }

        public void initView()
        {
            IEnumerable<patientLimited> database = requestDataBase();
            _view.fillDataGridView(getSNM(database), getId(database));
        }

        public void callDoctorPatientForm(int id)
        {
            _view.callDoctorPatientForm(id);
        }

        public void reloadView()
        {
            _view.clearDataGridView();
            initView();
        }

        private IEnumerable<patientLimited> requestDataBase()
        {
            return _service.getAllLimitedDatabase();
        }

        private IEnumerable<String> getSNM(IEnumerable<patientLimited> data)
        {
            String[] toReturn = new String[data.Count()];
            int i = 0;
            foreach (patientLimited element in data)
            {
                toReturn[i] = element.surname + ' ' + element.name + ' ' + element.middlename;
                i++;
            }
            return toReturn;
        }

        private IEnumerable<int> getId(IEnumerable<patientLimited> data)
        {
            int[] toReturn = new int[data.Count()];
            int i = 0;
            foreach (patientLimited element in data)
            {
                toReturn[i] = element.id;
                i++;
            }
            return toReturn;
        }

    }
}
