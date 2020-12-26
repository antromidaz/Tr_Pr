using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;
using Entity;
using System.Windows.Forms.DataVisualization.Charting;
using EmulationGraphicData;

namespace View
{
    public partial class DoctorPatientSurveyForm : Form, IDoctorPatientSurveyForm
    {
        private DoctorPatientSurveyPresenter _presenter;
        private EnterForm _EnterView;
        private DoctorPatientForm _DoctorPatientView;
        private bool _closeWay; //true if closed by option Exit, false - otherwise
        private List<Series> _chartPointsList;
        delegate void AddDot(double x, double y, int chartIndex);
        private AddDot _delegate;

        public DoctorPatientSurveyForm(EnterForm EnterView, DoctorPatientForm DoctorPatientView, patientFull.Survey survey)
        {
            InitializeComponent();
            _presenter = new DoctorPatientSurveyPresenter(this, survey);
            _presenter.initView();
            _EnterView = EnterView;
            _DoctorPatientView = DoctorPatientView;
            _closeWay = false;
            _chartPointsList = new List<Series>();
            _delegate = new AddDot(addDot);
        }

        public void fillSensorsDataGridView()
        {
            sensorsDataGridView.Columns.Add("column0", "Name");
            sensorsDataGridView.Columns.Add("column1", "Type");
            sensorsDataGridView.Columns.Add("column2", "Condition");
        }

        public void initSensorTypeComboBox(IEnumerable<String> sensorsType)
        {
            foreach (var element in sensorsType)
            {
                sensorTypeComboBox.Items.Add(element);
            }
        }

        public void addChart(String name, String type)
        {
            Chart newChart = new Chart();
            newChart.Dock = DockStyle.Fill;
            newChart.Titles.Add(name + "-" + type);
            newChart.ChartAreas.Add(new ChartArea(name));
            Axis ax = new Axis();
            ax.Title = "Time, s";
            Axis ay = new Axis();
            ay.Title = "Value";
            newChart.ChartAreas[0].AxisX = ax;
            newChart.ChartAreas[0].AxisY = ay;
            Series newSeriesOfPoint = new Series();
            newSeriesOfPoint.ChartType = SeriesChartType.Line;
            newSeriesOfPoint.ChartArea = name;
            newChart.Series.Add(newSeriesOfPoint);
            chartTableLayoutPanel.Controls.Add(newChart);
            _chartPointsList.Add(newSeriesOfPoint);
        }

        public void removeCharts()
        {
            _chartPointsList.Clear();
            chartTableLayoutPanel.Controls.Clear();
        }

        public void addDotToChart(double x, double y, int chartIndex)
        {
            Invoke(_delegate, x, y, chartIndex);
        }

        public void showNewSensorError()
        {
            MessageBox.Show("Fill information about sensor", "Warning");
        }

        public void showNameSensorError()
        {
            MessageBox.Show("Sensors' names must be uniqe", "Warning");
        }

        public void showContinueSurveyError()
        {
            MessageBox.Show("Stop the survey first", "Warning");
        }

        public void addSensorToSensorsDataGridView(String name, String type, String condition)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(sensorsDataGridView);
            row.Cells[0].Value = name;
            row.Cells[1].Value = type;
            row.Cells[2].Value = condition;
            sensorsDataGridView.Rows.Add(row);
        }

        public void deleteSelectedRow()
        {
            sensorsDataGridView.Rows.Remove(sensorsDataGridView.CurrentRow);
        }

        public void activateSelectedSensor()
        {
            sensorsDataGridView.CurrentRow.Cells[2].Value = "OK";
        }

        public void showSurveyError(int chartIndex)
        {
            try
            {
                String name = sensorsDataGridView.Rows[chartIndex].Cells[0].Value.ToString();
                MessageBox.Show("Sensor " + name + " is down", "Warning");
            }
            catch
            {
                Console.WriteLine("There was an error with 'showSurveyError'");
            }
        }

        private void addDot(double x, double y, int chartIndex)
        {
            _chartPointsList[chartIndex].Points.AddXY(x, y);
        }

        private void addSensorButton_Click(object sender, EventArgs e)
        {
            _presenter.addNewSensor(sensorNameTextBox.Text, sensorTypeComboBox.Text);
        }

        private void sensorsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            try
            {
                sensorNameLabel.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                sensorTypeLabel.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                sensorConditionLabel.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                sensorNameLabel.Text = "Not choised";
                sensorTypeLabel.Text = "Not choised";
                sensorConditionLabel.Text = "Not choised";
            }
        }

        private void deleteSensorButton_Click(object sender, EventArgs e)
        {
            try
            {
                String name = sensorsDataGridView.CurrentRow.Cells[0].Value.ToString();
                _presenter.deleteSensor(name);
            }
            catch
            {
                MessageBox.Show("Choose a sensor", "Warning");
            }    
        }

        private void activateSensorButton_Click(object sender, EventArgs e)
        {
            try
            {
                String name = sensorsDataGridView.CurrentRow.Cells[0].Value.ToString();
                _presenter.activateSensor(name);
            }
            catch
            {
                MessageBox.Show("Choose a sensor", "Warning");
            }    
        }

        private void DoctorPatientSurveyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _presenter.stopSurvey();
            if (_closeWay == false)
            {
                _EnterView.Close();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presenter.stopSurvey();
            _closeWay = true;
            this.Close();
            _DoctorPatientView.Show();
        }

        private void startAndStopSurveyButton_Click(object sender, EventArgs e)
        {
            _presenter.changeSurveyGoing();
        }
    }
}
