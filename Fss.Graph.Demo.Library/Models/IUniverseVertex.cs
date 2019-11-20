using GraphX.PCL.Common.Interfaces;
using System;

namespace Fss.Graph.Demo.Library.Models
{
    public interface IUniverseVertex : IGraphXVertex, IEquatable<IGraphXVertex>, IIdentifiableGraphDataObject
    {
        bool IsSelected { get; set; }
        object Model { get; set; }
        object ModelTypeString { get; set; }
        string Text { get; set; }

        string ToString();
    }
}