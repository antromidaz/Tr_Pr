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

namespace View
{
    public partial class DoctorPatientForm : Form, IDoctorPatientForm
    {
        DoctorPatientPresenter _presenter;
        private EnterForm _EnterView;
        private DoctorForm _DoctorView;
        private bool _closeWay; //true if closed by option Exit, false - otherwise

        public DoctorPatientForm(EnterForm EnterView, DoctorForm DoctorView, int id)
        {
            InitializeComponent();
            _presenter = new DoctorPatientPresenter(this, id);
            _presenter.initView();
            _EnterView = EnterView;
            _DoctorView = DoctorView;
            _closeWay = false;
        }

        public void fillViewInformation(patientFull data)
        {
            surnameTextBox.Text = data.surname;
            nameTextBox.Text = data.name;
            middlenameTextBox.Text = data.middlename;
            fillSurveysDataGridView(data);

        }

        private void fillSurveysDataGridView(patientFull data)
        {
            surveysDataGridView.Columns.Add("column0", "ID");
            surveysDataGridView.Columns.Add("column1", "Survey");
            surveysDataGridView.Columns.Add("column2", "Date");
            int arrayLength = data.surveys.Count<patientFull.Survey>();
            DataGridViewRow[] rows = new DataGridViewRow[arrayLength];
            for (int j = 0; j < arrayLength; j++)
            {
                DataGridViewRow row = new DataGridViewRow();
                rows[j] = row;
                row.CreateCells(surveysDataGridView);
            }
            int i = 0;
            foreach (patientFull.Survey element in data.surveys)
            {
                rows[i].Cells[0].Value = element.id.ToString();
                rows[i].Cells[1].Value = element.type;
                rows[i].Cells[2].Value = element.date;
                i++;
            }
            foreach (DataGridViewRow row in rows)
            {
                surveysDataGridView.Rows.Add(row);
            }
        }

        public void clearDataGridView()
        {
            surveysDataGridView.Rows.Clear();
            surveysDataGridView.Columns.Clear();
        }

        public void fillSurveyInformation()
        {
            dateTextBox.Text = _presenter._dateTextboxValue;
            if (_presenter._radioButtonValue == 1)
            {
                runRadioButton.Select();
            }
            else if (_presenter._radioButtonValue == 2)
            {
                walkRadioButton.Select();
            }
            else if (_presenter._radioButtonValue == 3)
            {
                strengthRadioButton.Select();
            }
            indicatorBloodPressureCheckBox.Checked = _presenter._checkBoxCounter.getBloodPressureValueCheckBox();
            indicatorSkinTemperatureCheckBox.Checked = _presenter._checkBoxCounter.getSkinTemperatureValueCheckBox();
            indicatorSkinHumidityCheckBox.Checked = _presenter._checkBoxCounter.getSkinHumidityValueCheckBox();
            indicatorHeartRateCheckBox.Checked = _presenter._checkBoxCounter.getHeartRateValueCheckBox();
            indicatorSkinElectricalConductivityCheckBox.Checked = _presenter._checkBoxCounter.getSkinElectrincalConductivityValueCheckBox();  
        }

        public void callDoctorPatientSurveyForm(patientFull.Survey survey)
        {
            new DoctorPatientSurveyForm(_EnterView, this, survey).Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _closeWay = true;
            this.Close();
            _DoctorView.Show();
        }

        private void surveysDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            try
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                _presenter.getSurvey(id);
            }
            catch
            {
            }
        }

        private void chooseSurveyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(surveysDataGridView.CurrentRow.Cells[0].Value.ToString());
                _presenter.callDoctorPatientSurveyForm(id);
            }
            catch
            {
                MessageBox.Show("Choose a survey", "Warning");
            }
        }

        private void DoctorPatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_closeWay == false)
            {
                _EnterView.Close();
            }
        }

    }
}
