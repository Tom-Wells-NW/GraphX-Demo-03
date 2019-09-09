using System;
using System.Windows;
using Fss.Graph.Demo.Library.Models;
using GraphX.Controls;
using QuickGraph;

namespace Fss.Graph.Demo.App01.Controls
{
    //Layout visual class
    public class NodesGraphArea : GraphArea<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>
    {
        public NodesGraphArea() : base()
        {
            this.SourceUpdated += NodesGraphArea_SourceUpdated;
        }

        private void NodesGraphArea_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            Console.WriteLine("NodesGraphArea_SourceUpdated...");
            HasGraphData = true;
        }

        

        public static readonly DependencyProperty HasGraphDataProperty = DependencyProperty.Register
            (
                "HasGraphData", typeof(Boolean),
                typeof(NodesGraphArea)
            );

        public bool HasGraphData
        {
            get { return (bool)GetValue(HasGraphDataProperty); }
            set { SetValue(HasGraphDataProperty, value); }
        }
    }
}
