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
    public partial class MedRegistratorPatientForm : Form, IMedRegistratorPatientForm
    {
        MedRegistratorPatientPresenter _presenter;
        MedRegistratorForm _MedRegistratorView;
        EnterForm _EnterView;
        private bool _closeWay; //true if closed by option Exit, false - otherwise

        public MedRegistratorPatientForm(MedRegistratorForm MedRegistratorView, EnterForm EnterView)
        {
            InitializeComponent();
            _presenter = new MedRegistratorPatientPresenter(this);
            _presenter.initView();
            _MedRegistratorView = MedRegistratorView;
            _EnterView = EnterView;
            _closeWay = false;
        }

        public MedRegistratorPatientForm(MedRegistratorForm MedRegistratorView, EnterForm EnterView, int id)
        {
            InitializeComponent();
            _presenter = new MedRegistratorPatientPresenter(this, id);
            _presenter.initView();
            _MedRegistratorView = MedRegistratorView;
            _EnterView = EnterView;
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

        public void showError()
        {
            MessageBox.Show("Please, write full information about survey", "Warning");
        }

        public void showOkSaveMessage()
        {
            MessageBox.Show("Saved succesfull", "Message");
        }

        public void showFailedSaveMessage()
        {
            MessageBox.Show("Failed to save", "Warning");
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (nameTextBox.Text != null && surnameTextBox.Text != null && middlenameTextBox.Text != null)
            {
                _presenter.savePatient();
            }
            else
            {
                showError();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _closeWay = true;
            this.Close();
            _MedRegistratorView.Show();
        }

        private void surveysGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            try
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                _presenter.getSurvey(id);
            }
            catch
            {
                //Clear all checkBoxes and radioButtons
                walkRadioButton.Checked = false;
                runRadioButton.Checked = false;
                strengthRadioButton.Checked = false;
                _presenter._radioButtonValue = 0;
                indicatorBloodPressureCheckBox.Checked = false;
                indicatorSkinTemperatureCheckBox.Checked = false;
                indicatorSkinHumidityCheckBox.Checked = false;
                indicatorHeartRateCheckBox.Checked = false;
                indicatorSkinElectricalConductivityCheckBox.Checked = false;
                _presenter._checkBoxCounter.setNullValue();
                dateTextBox.Text = "";
            }
        }

        private void surveyTypeRadioButton_Checked(object sender, EventArgs e)
        {
            RadioButton checkbox = (RadioButton)sender;
            if (checkbox.Text == "Run")
            {
                _presenter._radioButtonValue = 1;
            }
            else if (checkbox.Text == "Walk")
            {
                _presenter._radioButtonValue = 2;
            }
            else if (checkbox.Text == "Strengh")
            {
                _presenter._radioButtonValue = 3;
            }
        }

        private void saveSureveyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(surveysDataGridView.CurrentRow.Cells[0].Value.ToString());
                _presenter.changeSurvey(id);
            }
            catch
            {
                MessageBox.Show("Choose a survey", "Warning");
            } 
        }

        private void createSurveyButton_Click(object sender, EventArgs e)
        {
            _presenter.createSurvey();
        }

        private void deleteSurveyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(surveysDataGridView.CurrentRow.Cells[0].Value.ToString());
                _presenter.deleteSurvey(id);
            }
            catch
            {
                MessageBox.Show("Choose a survey", "Warning");
            } 
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            _presenter._dateTextboxValue = textBox.Text;
        }

        private void indicatorBloodPressureCheckBox_Click(object sender, EventArgs e)
        {
            _presenter._checkBoxCounter.changeBloodPressureValueCheckBox();
        }

        private void indicatorSkinTemperatureCheckBox_Click(object sender, EventArgs e)
        {
            _presenter._checkBoxCounter.changeSkinTemperatureValueCheckBox();
        }

        private void indicatorSkinHumidityCheckBox_Click(object sender, EventArgs e)
        {
            _presenter._checkBoxCounter.changeSkinHumidityValueCheckBox();
        }

        private void indicatorHeartRateCheckBox_Click(object sender, EventArgs e)
        {
            _presenter._checkBoxCounter.changeHeartRateValueCheckBox();
        }

        private void indicatorSkinElectrincalConductivityCheckBox_Click(object sender, EventArgs e)
        {
            _presenter._checkBoxCounter.changeSkinElectrincalConductivityValueCheckBox();
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            _presenter.setSurname(textBox.Text);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            _presenter.setName(textBox.Text);
        }

        private void middlenameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            _presenter.setMiddlename(textBox.Text);
        }

        private void MedRegistratorPatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_closeWay == false)
            {
                _EnterView.Close();
            }
        }

    }
}
