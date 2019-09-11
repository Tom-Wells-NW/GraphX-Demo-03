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
    public class UniverseGraphViewModel : ViewModelBase, IUniverseGraphViewModel
    {
        public UniverseGraphViewModel(IUniverseGraphDataHelper graphDataHelper)
        {
            this.GraphDataHelper = graphDataHelper;
            InitializeGraph();
            Name = "Universe Graph View Model";
            UnsetVerticesIsSelectedCommandName = "Unselect All Vertices";
            SetVerticesIsSelectedCommandName = "Select All Vertices";
        }

        private void InitializeGraph()
        {
            ResetGraphData();
        }

        private void ResetGraphData()
        {
            if (Edges?.Count() > 0) Edges.Clear();
            if (Vertices?.Count() > 0) Vertices.Clear();
            if (NodeGraph != null) NodeGraph.Clear();

            NodeGraph = GraphDataHelper.LoadGraphData(300);

        }

        private IUniverseGraphDataHelper _graphDataHelper;
        private IUniverseGraphDataHelper GraphDataHelper
        {
            get { return _graphDataHelper; }
            set { Set(ref _graphDataHelper, value); }
        }

        private UniverseGraph _universeGraph;
        public UniverseGraph UniverseGraph
        {
            get { return _universeGraph; }
            set
            {
                Set(ref _universeGraph, value);
                Vertices = _universeGraph.Vertices.ToList();

                SelectedVertex = (_universeGraph.Vertices.FirstOrDefault());
                Edges = _universeGraph.Edges.ToList();
                NodeCount = _universeGraph.VertexCount;
            }
        }


        private UniverseVertex _selectedVertex;
        public UniverseVertex SelectedVertex
        {
            get { return _selectedVertex; }
            set
            {
                var prevSelectedVertex = _selectedVertex;
                Set(ref _selectedVertex, value);

                if (ShouldUpdateIsSelected(prevSelectedVertex, value)) { prevSelectedVertex.IsSelected = false; }
                if (ShouldUpdateIsSelected(_selectedVertex, prevSelectedVertex)) { _selectedVertex.IsSelected = true; }
            }
        }

        private static bool ShouldUpdateIsSelected(UniverseVertex updateTarget, UniverseVertex compareTarget)
        {
            return updateTarget != null && !updateTarget.Equals(compareTarget);
        }

        private IList<UniverseVertex> _vertices;
        public IList<UniverseVertex> Vertices
        {
            get { return _vertices; }
            set { Set(ref _vertices, value); }
        }


        private UniverseEdge _selectedEdge;
        public UniverseEdge SelectedEdge
        {
            get { return _selectedEdge; }
            set { Set(ref _selectedEdge, value); }
        }


        private IList<UniverseEdge> _edges;
        public IList<UniverseEdge> Edges
        {
            get { return _edges; }
            set { Set(ref _edges, value); }
        }


        private int _universeCount;
        public int UniverseCount
        {
            get { return _universeCount; }
            set { Set(ref _universeCount, value); }
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


        #region Command - Set Vertices Is Selected 
        private string _setVerticesIsSelectedCommandName;
        public string SetVerticesIsSelectedCommandName
        {
            get { return _setVerticesIsSelectedCommandName; }
            set { Set(ref _setVerticesIsSelectedCommandName, value); }
        }

        private RelayCommand _setVerticesIsSelectedCommand;

        public RelayCommand SetVerticesIsSelectedCommand
        {
            get
            {
                return _setVerticesIsSelectedCommand
                    ?? (_setVerticesIsSelectedCommand = new RelayCommand(
                    () =>
                    {
                        foreach (var vertex in Vertices)
                        {
                            if (!vertex.Equals(SelectedVertex)) vertex.IsSelected = true;
                        }
                    },
                    () => true));
            }
        }
        #endregion Command - Set Vertices Is Selected 


        #region Command - Rest Graph Data

        #endregion Command - Rest Graph Data
    }
}
