using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CheckBoxCounter
    {
        private byte _checkBoxValue;

        public CheckBoxCounter()
        {
            _checkBoxValue = 0;
        }

        public CheckBoxCounter(byte checkBoxValue)
        {
            _checkBoxValue = checkBoxValue;
        }

        public void changeBloodPressureValueCheckBox()
        {
            changeValueCheckBox(1);
        }

        public void changeSkinTemperatureValueCheckBox()
        {
            changeValueCheckBox(2);
        }

        public void changeSkinHumidityValueCheckBox()
        {
            changeValueCheckBox(3);
        }

        public void changeHeartRateValueCheckBox()
        {
            changeValueCheckBox(4);
        }

        public void changeSkinElectrincalConductivityValueCheckBox()
        {
            changeValueCheckBox(5);
        }

        public bool getBloodPressureValueCheckBox()
        {
            return getValueCheckBox(1);
        }

        public bool getSkinTemperatureValueCheckBox()
        {
            return getValueCheckBox(2);
        }

        public bool getSkinHumidityValueCheckBox()
        {
            return getValueCheckBox(3);
        }

        public bool getHeartRateValueCheckBox()
        {
            return getValueCheckBox(4);
        }

        public bool getSkinElectrincalConductivityValueCheckBox()
        {
            return getValueCheckBox(5);
        }

        public bool checkNullValue()
        {
            return _checkBoxValue == 0;
        }

        public void setNullValue()
        {
            _checkBoxValue = 0;
        }

        public void changeValueCheckBox(int numCheckBox)
        {
            byte byteNumber = Convert.ToByte(Math.Pow(2, numCheckBox));
            if ((_checkBoxValue & byteNumber) == byteNumber)
            {
                _checkBoxValue -= byteNumber;
            }
            else
            {
                _checkBoxValue += byteNumber;
            }
        }

        public bool getValueCheckBox(int numCheckBox)
        {
            byte byteNumber = Convert.ToByte(Math.Pow(2, numCheckBox));
            return (_checkBoxValue & byteNumber) == byteNumber;
        }
    }
}
