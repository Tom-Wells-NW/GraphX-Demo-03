using GraphX.PCL.Common.Interfaces;
using QuickGraph;

namespace Fss.Graph.Demo.Library.Models
{
    public interface IUniverseEdge : IGraphXEdge<IUniverseVertex>, IGraphXCommonEdge, IIdentifiableGraphDataObject, IRoutingInfo, IWeightedEdge<IUniverseVertex>, IEdge<IUniverseVertex>
    {
        string Text { get; set; }

        string ToString();
    }
}