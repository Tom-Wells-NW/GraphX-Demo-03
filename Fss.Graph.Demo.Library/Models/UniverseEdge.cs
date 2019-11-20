using GraphX.PCL.Common.Interfaces;
using GraphX.PCL.Common.Models;
using QuickGraph;

namespace Fss.Graph.Demo.Library.Models
{
    public class UniverseEdge : EdgeBase<IUniverseVertex>, IUniverseEdge, IGraphXEdge<IUniverseVertex>, IGraphXCommonEdge, IIdentifiableGraphDataObject, IRoutingInfo, IWeightedEdge<IUniverseVertex>, IEdge<IUniverseVertex>
    {
        public UniverseEdge(IUniverseVertex source, IUniverseVertex target, double weight = 1) : base(source, target, weight) { }

        public UniverseEdge() : base(null, null, 1) { }

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
