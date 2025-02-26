﻿using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Repositories;
using Model;
using WpfApp3.Commands.TransitionCommands;
using WpfApp3.ViewModels.BulkShowEntitiesViewModels;

namespace WpfApp3.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private IPageViewModel _currentPageViewModel;

        public static MainWindowViewModel CurrentInstance { get; set; }
        private readonly OverviewViewModel _overviewViewModel;
        private readonly ShowAllFlightsViewModel _showAllFlightsViewModel;
        private readonly ShowAllRoutesViewModel _showAllRoutesViewModel;
        private readonly ShowAllAirplanesViewModel _showAllAirplanesViewModel;
        private readonly ShowAllAirportsViewModel _showAllAirportsViewModel;
        private readonly ShowAllPassengersViewModel _showAllPassengersViewModel;
        private readonly ShowAllTicketsViewModel _showAllTicketsViewModel;
        private readonly ShowAllCarriersViewModel _showAllCarriersViewModel;
        private readonly TicketsByFlightViewModel _ticketsByFlightViewModel;
        public MainWindowViewModel(ShowAllFlightsViewModel showAllFlightsViewModel, OverviewViewModel overviewViewModel, ShowAllRoutesViewModel showAllRoutesViewModel, ShowAllAirplanesViewModel showAllAirplanesViewModel, ShowAllAirportsViewModel showAllAirportsViewModel, ShowAllPassengersViewModel showAllPassengersViewModel, ShowAllTicketsViewModel showAllTicketsViewModel, TicketsByFlightViewModel ticketsByFlightViewModel, ShowAllCarriersViewModel showAllCarriersViewModel)
        {
            CurrentInstance = this;
            _overviewViewModel = overviewViewModel;
            _showAllAirplanesViewModel = showAllAirplanesViewModel;
            _showAllAirportsViewModel = showAllAirportsViewModel;
            _showAllFlightsViewModel = showAllFlightsViewModel;
            _showAllPassengersViewModel = showAllPassengersViewModel;
            _showAllRoutesViewModel = showAllRoutesViewModel;
            _showAllTicketsViewModel = showAllTicketsViewModel;
            _showAllCarriersViewModel = showAllCarriersViewModel;
            _ticketsByFlightViewModel = ticketsByFlightViewModel;

            _currentPageViewModel = overviewViewModel;
        }

        public IPageViewModel CurrentPageViewModel
        {
            get => _currentPageViewModel;
            set => Set(ref _currentPageViewModel, value);
        }

        public void ShowOverview()
        {
            CurrentPageViewModel = _overviewViewModel;
        }
        public void ShowAllFlights()
        {
            CurrentPageViewModel = _showAllFlightsViewModel;
        }
        public void ShowAllRoutes()
        {
            CurrentPageViewModel = _showAllRoutesViewModel;
        }
        public void ShowAllAirplanes()
        {
            CurrentPageViewModel = _showAllAirplanesViewModel;
        }

        public void ShowAllAirports()
        {
            CurrentPageViewModel = _showAllAirportsViewModel;
        }

        public void ShowAllPassengers()
        {
            CurrentPageViewModel = _showAllPassengersViewModel;
        }

        public void ShowAllTickets()
        {
            CurrentPageViewModel = _showAllTicketsViewModel;
        }

        public void ShowAllCarriers()
        {
            CurrentPageViewModel = _showAllCarriersViewModel;
        }

        public void ShowTicketsByFlight(FlightModel flightModel)
        {
            _ticketsByFlightViewModel.CurrentFlightModel = flightModel;
            _ticketsByFlightViewModel.UpdateTickets();
            CurrentPageViewModel = _ticketsByFlightViewModel;
        }
    }
}