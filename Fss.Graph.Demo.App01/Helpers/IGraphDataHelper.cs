using Fss.Graph.Demo.Library.Models;

namespace Fss.Graph.Demo.App01.Helpers
{
    public interface IGraphDataHelper
    {
        NodeGraph LoadGraphData();
        NodeGraph LoadGraphData(int vertexCount);
    }
}