﻿using GraphX.PCL.Common.Models;

namespace Fss.Graph.Demo.Library.Models
{
    //Edge data object
    public class DataEdge : EdgeBase<DataVertex>
    {
        public DataEdge(DataVertex source, DataVertex target, double weight = 1) : base(source, target, weight) { }

        public DataEdge() : base(null, null, 1) { }

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
