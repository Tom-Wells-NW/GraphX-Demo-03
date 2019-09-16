using Fss.Graph.Demo.Library.Models;
using System.Collections.Generic;

namespace Fss.Graph.Demo.App01.ViewModels.Interfaces
{
    public interface IMainViewModel
    {
        string Name { get; set; }
        IUniverseGraphViewModel GraphViewModel { get; set; }
    }
}