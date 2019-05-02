using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FloatEntryBug
{
    public class FloatEntryBugViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private float _floatProp;
        public float FloatProp
        {
            get
            {
                return _floatProp;
            }
            set
            {
                _floatProp = value;
                OnPropertyChanged(nameof(FloatProp));
            }
        }

        private double _doubleProp;
        public double DoubleProp
        {
            get
            {
                return _doubleProp;
            }
            set
            {
                _doubleProp = value;
                OnPropertyChanged(nameof(DoubleProp));
            }
        }

        private decimal _decimalProp;
        public decimal DecimalProp
        {
            get
            {
                return _decimalProp;
            }
            set
            {
                _decimalProp = value;
                OnPropertyChanged(nameof(DecimalProp));
            }
        }

        private string _appCulture;
        public string AppCulture
        {
            get
            {
                return _appCulture;
            }
            set
            {
                _appCulture = value;
                OnPropertyChanged(nameof(AppCulture));
            }
        }

        private string _appUiCulture;
        public string AppUiCulture
        {
            get
            {
                return _appUiCulture;
            }
            set
            {
                _appUiCulture = value;
                OnPropertyChanged(nameof(AppUiCulture));
            }
        }


        public FloatEntryBugViewModel(float floatVal, double doubleVal, decimal decimalVal)
        {
            FloatProp = floatVal;
            DoubleProp = doubleVal;
            DecimalProp = decimalVal;

            AppCulture = System.Threading.Thread.CurrentThread.CurrentCulture.ToString();
            AppUiCulture = System.Threading.Thread.CurrentThread.CurrentUICulture.ToString();
        }
    }
}
