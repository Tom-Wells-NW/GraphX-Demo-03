using Fss.Graph.Demo.Library.Models;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.Generic;

namespace Fss.Graph.Demo.App01.ViewModels.Interfaces
{
    public interface IUniverseGraphViewModel
    {
        IList<UniverseEdge> Edges { get; set; }
        string Name { get; set; }
        int UniverseCount { get; set; }
        UniverseGraph UniverseGraph { get; set; }
        UniverseEdge SelectedEdge { get; set; }
        UniverseVertex SelectedVertex { get; set; }
        RelayCommand UnsetVerticesIsSelectedCommand { get; }
        string UnsetVerticesIsSelectedCommandName { get; set; }
        IList<UniverseVertex> Vertices { get; set; }
    }
}