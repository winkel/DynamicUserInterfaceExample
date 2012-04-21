using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DynamicUserInterfaceExample.Model;
using System.ComponentModel;

namespace DynamicUserInterfaceExample.ViewModels
{
    class FirstRightViewModel : INotifyPropertyChanged
    {
        public FirstRightViewModel(FirstModel model)
        {
            if (model == null) throw new ArgumentNullException("model");

            this.Model = model;
            this.Model.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(Model_PropertyChanged);

            this.StateName = this.Model.State.ToString();
        }

        FirstModel Model { get; set; }

        void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "State")
            {
                this.StateName = this.Model.State.ToString();
            }
        }

        string _stateName;
        public string StateName
        {
            get { return _stateName; }
            set
            {
                if (_stateName != value)
                {
                    _stateName = value;
                    TriggerPropertyChangedEvent("StateName");
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
