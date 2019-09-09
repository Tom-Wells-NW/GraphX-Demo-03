using Fss.Graph.Demo.App01.Helpers;
using Fss.Graph.Demo.App01.ViewModels.Interfaces;
using Fss.Graph.Demo.Library.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fss.Graph.Demo.App01.ViewModels
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        public MainViewModel(IGraphViewModel graphViewModel) 
        {
            GraphViewModel = graphViewModel;
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }


        private IGraphViewModel _graphViewModel;
        public IGraphViewModel GraphViewModel
        {
            get { return _graphViewModel; }
            set { Set(ref _graphViewModel, value); }
        }
    }
}
