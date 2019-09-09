using Fss.Graph.Demo.App01.Helpers;
using Fss.Graph.Demo.App01.ViewModels.Interfaces;
using Fss.Graph.Demo.Library.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Graph.Demo.App01.ViewModels
{
    public class GraphViewModel : ViewModelBase, IGraphViewModel
    {
        public GraphViewModel(IGraphDataHelper graphDataHelper)
        {
            this.GraphDataHelper = graphDataHelper;
            InitializeGraph();
            Name = "Graph View Model";
            UnsetVerticesIsSelectedCommandName = "Unselect All Vertices";
        }

        private void InitializeGraph()
        {
            ResetGraphData();
        }

        private void ResetGraphData()
        {
            if (Edges?.Count() > 0) Edges.Clear();
            if (Vertices?.Count() > 0) Vertices.Clear();
            if(NodeGraph != null) NodeGraph.Clear();

            NodeGraph = GraphDataHelper.LoadGraphData(300);

        }

        private IGraphDataHelper _graphDataHelper;
        private IGraphDataHelper GraphDataHelper
        {
            get { return _graphDataHelper; }
            set { Set(ref _graphDataHelper, value); }
        }

        private NodeGraph _nodeGraph;
        public NodeGraph NodeGraph
        {
            get { return _nodeGraph; }
            set
            {
                Set(ref _nodeGraph, value);
                Vertices = _nodeGraph.Vertices.ToList();

                SelectedVertex = (_nodeGraph.Vertices.FirstOrDefault());
                Edges = _nodeGraph.Edges.ToList();
                NodeCount = _nodeGraph.VertexCount;
            }
        }


        private DataVertex _selectedVertex;
        public DataVertex SelectedVertex
        {
            get { return _selectedVertex; }
            set
            {
                var prevSelectedVertex = _selectedVertex;
                Set(ref _selectedVertex, value);

                if (prevSelectedVertex != null && !prevSelectedVertex.Equals(value)) { prevSelectedVertex.IsSelected = false; }
                if (_selectedVertex != null && !_selectedVertex.Equals(prevSelectedVertex)) { _selectedVertex.IsSelected = true; }
            }
        }


        private IList<DataVertex> _vertices;
        public IList<DataVertex> Vertices
        {
            get { return _vertices; }
            set { Set(ref _vertices, value); }
        }


        private DataEdge _selectedEdge;
        public DataEdge SelectedEdge
        {
            get { return _selectedEdge; }
            set { Set(ref _selectedEdge, value); }
        }


        private IList<DataEdge> _edges;
        public IList<DataEdge> Edges
        {
            get { return _edges; }
            set { Set(ref _edges, value); }
        }


        private int _nodeCount;
        public int NodeCount
        {
            get { return _nodeCount; }
            set { Set(ref _nodeCount, value); }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }


        #region Command - Unset Vertices Is Selected 
        private string _unsetVerticesIsSelectedCommandName;
        public string UnsetVerticesIsSelectedCommandName
        {
            get { return _unsetVerticesIsSelectedCommandName; }
            set { Set(ref _unsetVerticesIsSelectedCommandName, value); }
        }

        private RelayCommand _unsetVerticesIsSelectedCommand;

        public RelayCommand UnsetVerticesIsSelectedCommand
        {
            get
            {
                return _unsetVerticesIsSelectedCommand
                    ?? (_unsetVerticesIsSelectedCommand = new RelayCommand(
                    () =>
                    {
                        foreach (var vertex in Vertices)
                        {
                            if (!vertex.Equals(SelectedVertex)) vertex.IsSelected = false;
                        }
                    },
                    () => true));
            }
        }
        #endregion Command - Unset Vertices Is Selected 

        #region Command - Rest Graph Data
        
        #endregion Command - Rest Graph Data
    }
}
