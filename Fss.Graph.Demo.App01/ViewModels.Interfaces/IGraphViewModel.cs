using System.Collections.Generic;
using Fss.Graph.Demo.Library.Models;
using GalaSoft.MvvmLight.CommandWpf;

namespace Fss.Graph.Demo.App01.ViewModels.Interfaces
{
    public interface IGraphViewModel
    {
        IList<DataEdge> Edges { get; set; }
        string Name { get; set; }
        int NodeCount { get; set; }
        NodeGraph NodeGraph { get; set; }
        DataEdge SelectedEdge { get; set; }
        DataVertex SelectedVertex { get; set; }
        RelayCommand UnsetVerticesIsSelectedCommand { get; }
        string UnsetVerticesIsSelectedCommandName { get; set; }
        IList<DataVertex> Vertices { get; set; }
    }
}