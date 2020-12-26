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

namespace View
{
    public partial class DoctorForm : Form, IDoctorForm
    {
        private DoctorPresenter _presenter;
        private EnterForm _EnterView;
        private bool _closeWay; //true if closed by option Exit, false - otherwise

        public DoctorForm(EnterForm EnterView)
        {
            InitializeComponent();
            _presenter = new DoctorPresenter(this);
            _presenter.initView();
            _EnterView = EnterView;
            _closeWay = false;
        }

        public void fillDataGridView(IEnumerable<String> SNMarray, IEnumerable<int> IDarray)
        {
            patientsDataGridView.Columns.Add("column1", "ID");
            patientsDataGridView.Columns.Add("column0", "ФИО");
            int arrayLength = SNMarray.Count<String>();
            DataGridViewRow[] rows = new DataGridViewRow[arrayLength];
            for (int j = 0; j < arrayLength; j++)
            {
                DataGridViewRow row = new DataGridViewRow();
                rows[j] = row;
                row.CreateCells(patientsDataGridView);
            }
            int i = 0;
            foreach (var element in IDarray)
            {
                rows[i].Cells[0].Value = element.ToString();
                i++;
            }
            i = 0;
            foreach (var element in SNMarray)
            {
                rows[i].Cells[1].Value = element;
                i++;
            }
            foreach (DataGridViewRow row in rows)
            {
                patientsDataGridView.Rows.Add(row);
            }
        }

        public void clearDataGridView()
        {
            patientsDataGridView.Rows.Clear();
            patientsDataGridView.Columns.Clear();
        }

        public void callDoctorPatientForm(int id)
        {
            new DoctorPatientForm(_EnterView, this, id).Show();
            this.Hide();
        }

        private void showAllPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _closeWay = true;
            this.Close();
            _EnterView.Show();
        }

        private void searchPatienttoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void patientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            try
            {
                patientNameLabel.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                patientNameLabel.Text = "Not choised";
            }
        }

        private void choosePatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(patientsDataGridView.CurrentRow.Cells[0].Value.ToString());
                _presenter.callDoctorPatientForm(id);
            }
            catch
            {
                MessageBox.Show("Choose a patient", "Warning");
            }
        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_closeWay == false)
            {
                _EnterView.Close();
            }
        }
    }
}
