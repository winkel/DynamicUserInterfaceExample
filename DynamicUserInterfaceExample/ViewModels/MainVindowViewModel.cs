using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using DynamicUserInterfaceExample.Common;

namespace DynamicUserInterfaceExample.ViewModels
{
    public class MainVindowViewModel : INotifyPropertyChanged
    {
        private object _leftPanel = new FirstLeftViewModel();
        public object LeftPanel
        {
            get { return _leftPanel; }
            set
            {
                _leftPanel = value;
                TriggerPropertyChangedEvent("LeftPanel");
            }
        }

        private object _rightPanel = new FirstRightViewModel();
        public object RightPanel
        {
            get { return _rightPanel; }
            set
            {
                _rightPanel = value;
                TriggerPropertyChangedEvent("RightPanel");
            }
        }

        ICommand _firstOptionCommand = null;
        public ICommand FirstOptionCommand
        {
            get
            {
                if (_firstOptionCommand == null)
                    _firstOptionCommand = new RelayCommand(OnFirstOption);
                return _firstOptionCommand;
            }
        }

        public void OnFirstOption()
        {
            this.LeftPanel = new FirstLeftViewModel();
            this.RightPanel = new FirstRightViewModel();
        }

        ICommand _secondOptionCommand = null;
        public ICommand SecondOptionCommand
        {
            get
            {
                if (_secondOptionCommand == null)
                    _secondOptionCommand = new RelayCommand(OnSecondOption);
                return _secondOptionCommand;
            }
        }

        public void OnSecondOption()
        {
            this.LeftPanel = new SecondLeftViewModel();
            this.RightPanel = new SecondRightViewModel();
        }

        ICommand _thirdOptionCommand = null;
        public ICommand ThirdOptionCommand
        {
            get
            {
                if (_thirdOptionCommand == null)
                    _thirdOptionCommand = new RelayCommand(OnThirdOption);
                return _thirdOptionCommand;
            }
        }

        public void OnThirdOption()
        {
            this.LeftPanel = new ThirdLeftViewModel();
            this.RightPanel = new ThirdRightViewModel();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void TriggerPropertyChangedEvent(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
