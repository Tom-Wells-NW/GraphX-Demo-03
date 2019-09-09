using Fss.Graph.Demo.Library.Models;
using System.Collections.Generic;

namespace Fss.Graph.Demo.App01.ViewModels.Interfaces
{
    public interface IMainViewModel
    {
        string Name { get; set; }
        IGraphViewModel GraphViewModel { get; set; }
        //NodeGraph NodeGraph { get; set; }
        //int NodeCount { get; set; }
        //DataVertex SelectedVertex { get; set; }
        //IList<DataVertex> Vertices { get; set; }
        //DataEdge SelectedEdge { get; set; }
        //IList<DataEdge> Edges { get; set; }
    }
}