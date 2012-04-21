using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DynamicUserInterfaceExample.Model
{
    enum State
    {
        Alpha,
        Beta,
        Gamma,
    }

    class FirstModel : INotifyPropertyChanged
    {
        State _state;
        public State State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    TriggerPropertyChangedEvent("State");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void TriggerPropertyChangedEvent(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
