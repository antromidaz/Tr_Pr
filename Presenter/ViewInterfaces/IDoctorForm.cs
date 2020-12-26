using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IDoctorForm
    {
        void fillDataGridView(IEnumerable<String> SNMarray, IEnumerable<int> IDarray);
        void callDoctorPatientForm(int id);
        void clearDataGridView();
    }
}
