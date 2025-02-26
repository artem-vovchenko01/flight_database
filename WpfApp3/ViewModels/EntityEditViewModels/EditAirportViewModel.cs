﻿using Model;

namespace WpfApp3.ViewModels.EntityEditViewModels
{
    public class EditAirportViewModel : BaseViewModel, IPageViewModel
    {
        private AirportModel _airport;
        
        public AirportModel Airport
        {
            get => _airport;
            set => Set(ref _airport, value);
        }
    }
}