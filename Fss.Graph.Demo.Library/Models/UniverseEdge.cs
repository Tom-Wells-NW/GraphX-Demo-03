using GraphX.PCL.Common.Models;

namespace Fss.Graph.Demo.Library.Models
{
    public class UniverseEdge : EdgeBase<UniverseVertex>
    {
        public UniverseEdge(UniverseVertex source, UniverseVertex target, double weight = 1) : base(source, target, weight) { }

        public UniverseEdge() : base(null, null, 1) { }

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
