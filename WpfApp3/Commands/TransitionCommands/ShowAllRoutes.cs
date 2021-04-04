﻿using WpfApp3.ViewModels;

namespace WpfApp3.Commands.TransitionCommands
{
    public class ShowAllRoutes : BaseCommand
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            Mediator.Notify("ShowAllRoutes");
        }
    }
}