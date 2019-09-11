using Fss.Graph.Demo.Library.Models;

namespace Fss.Graph.Demo.App01.Helpers
{
    public interface IUniverseGraphDataHelper
    {
        UniverseGraph LoadGraphData();
        UniverseGraph LoadGraphData(int vertexCount);
    }
}