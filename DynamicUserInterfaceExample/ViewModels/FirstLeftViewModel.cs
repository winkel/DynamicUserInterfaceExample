using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DynamicUserInterfaceExample.Model;
using System.Windows.Input;
using DynamicUserInterfaceExample.Common;
using System.ComponentModel;

namespace DynamicUserInterfaceExample.ViewModels
{
    class FirstLeftViewModel
    {
        public FirstLeftViewModel(FirstModel model)
        {
            if (model == null) throw new ArgumentNullException("model");

            this.Model = model;
        }

        FirstModel Model { get; set; }

        ICommand _alphaCommand = null;
        public ICommand AlphaCommand
        {
            get
            {
                if (_alphaCommand == null)
                    _alphaCommand = new RelayCommand(OnAlpha);
                return _alphaCommand;
            }
        }

        public void OnAlpha()
        {
            this.Model.State = State.Alpha;
        }

        ICommand _betaCommand = null;
        public ICommand BetaCommand
        {
            get
            {
                if (_betaCommand == null)
                    _betaCommand = new RelayCommand(OnBeta);
                return _betaCommand;
            }
        }

        public void OnBeta()
        {
            this.Model.State = State.Beta;
        }

        ICommand _gammaCommand = null;
        public ICommand GammaCommand
        {
            get
            {
                if (_gammaCommand == null)
                    _gammaCommand = new RelayCommand(OnGamma);
                return _gammaCommand;
            }
        }

        public void OnGamma()
        {
            this.Model.State = State.Gamma;
        }
    }
}
