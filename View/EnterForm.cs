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
    public partial class EnterForm : Form, IEnterForm
    {
        private EnterPresenter _presenter;

        public EnterForm()
        {
            InitializeComponent();
            _presenter = new EnterPresenter(this);
            _presenter.initView();
        }

        public void showErrorMessage()
        {
            MessageBox.Show("Choose your speciality!", "Warning");
        }

        public void callMedRegistratorForm()
        {
            new MedRegistratorForm(this).Show();
            this.Hide();
        }

        public void callDoctorForm()
        {
            new DoctorForm(this).Show();
            this.Hide();
        }

        private void EnterChoiseRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                _presenter.changeChooseEnterType(radioButton.Name);
            }

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            _presenter.callForm();
        }
    }
}
