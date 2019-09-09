using GraphX.PCL.Common.Models;
using System.Windows;
using System.Windows.Media;

namespace Fss.Graph.Demo.Library.Models
{
    public class DataVertex : VertexViewModelBase
    {

        public DataVertex() : base() { }

        private string _text;
        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }


        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                Set(ref _isSelected, value);
            }
        }


        public override string ToString()
        {
            return Text;
        }

        private object _model;
        public object Model
        {
            get { return _model; }
            set
            {
                Set(ref _model, value);
            }
        }
    }
}
