﻿using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Entities;
using Model;
using WpfApp3.Commands;

namespace WpfApp3.ViewModels.EntityEditViewModels
{
    public class EditRouteViewModel : BaseViewModel, IPageViewModel
    {
        private RouteModel _route;
        private IEnumerable<AirportModel> _airports;
        private IEnumerable<CarrierModel> _carriers;
        private ICommand _closeDialog;

        public ICommand CloseDialog => _closeDialog ??= new RelayCommand(OnCloseDialogCommandExecute,
            (param) => _route.AirportArrive != null && _route.AirportDepart != null);
        
        private void OnCloseDialogCommandExecute(object parameter)
        {
            var window = (Window) parameter;
            window.DialogResult = true;
            window.Close();
        }
        public RouteModel Route
        {
            get => _route;
            set => Set(ref _route, value);
        }

        public IEnumerable<AirportModel> Airports
        {
            get => _airports;
            set => Set(ref _airports, value);
        }

        public IEnumerable<CarrierModel> Carriers
        {
            get => _carriers;
            set => Set(ref _carriers, value);
        }

    }
}
