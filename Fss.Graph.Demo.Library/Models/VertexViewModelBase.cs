using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Common.Interfaces;
using System.Windows;

namespace Fss.Graph.Demo.Library.Models
{
    public abstract class VertexViewModelBase : ViewModelBase, IGraphXVertex
    {
        protected VertexViewModelBase()
        {
            ID = -1;
        }

        public bool Equals(IGraphXVertex other)
        {
            return Equals(this, other);
        }



        private double _angle;
        public double Angle 
        {
            get { return _angle; }
            set { Set(ref _angle, value); }
        }


        private int _groupId;
        public int GroupId
        {
            get { return _groupId; }
            set { Set(ref _groupId, value); }
        }


        private ProcessingOptionEnum _skipProcessing;
        public ProcessingOptionEnum SkipProcessing
        {
            get { return _skipProcessing; }
            set { Set(ref _skipProcessing, value); }
        }


        private long _id;
        public long ID
        {
            get { return _id; }
            set { Set(ref _id, value); }
        }
    }
}
