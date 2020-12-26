using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IMedRegistratorForm
    {
        void fillDataGridView(IEnumerable<String> SNMarray, IEnumerable<int> IDarray);
        void deleteSelectedRow();
        void clearDataGridView();
        void callMedRegistratorPatientForm(int id);
        void callMedRegistratorPatientForm();
        //void show();
    }
}
