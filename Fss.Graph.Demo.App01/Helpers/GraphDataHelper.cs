using Fss.Graph.Demo.Library.Helpers;
using Fss.Graph.Demo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Graph.Demo.App01.Helpers
{
    public class GraphDataHelper : IGraphDataHelper
    {
        public NodeGraph LoadGraphData()
        {
            return LoadGraphData(200);
        } 
        public NodeGraph LoadGraphData(int vertexCount)
        {
            var helper = new DesignGraphDataHelper();

            var result = helper.GenerateDesignGraph(vertexCount);
            return result;
        }
    }
}
