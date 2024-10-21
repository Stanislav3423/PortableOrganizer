using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using AutoMapper;
using Organizer.Model;
using Organizer.UI.Base;
using Organizer.UI.ViewModels;

namespace Organizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel _model;
        private DataViewModel _viewModel;
        public App()
        {
            new Mapping().Create();
            _model = DataModel.Load();
            _viewModel = Mapper.Map<DataModel, DataViewModel>(_model);
            var window = new MainWindow() { DataContext = _viewModel };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                _model = Mapper.Map<DataViewModel, DataModel>(_viewModel);
                _model.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }
}
