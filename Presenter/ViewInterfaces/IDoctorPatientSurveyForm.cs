using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IDoctorPatientSurveyForm
    {
        void fillSensorsDataGridView();
        void initSensorTypeComboBox(IEnumerable<String> sensorsType);
        void addSensorToSensorsDataGridView(String name, String type, String condition);
        void showNewSensorError();
        void showNameSensorError();
        void showContinueSurveyError();
        void deleteSelectedRow();
        void activateSelectedSensor();
        void addChart(String name, String type);
        void removeCharts();
        void addDotToChart(double x, double y, int chartNum);
    }
}
