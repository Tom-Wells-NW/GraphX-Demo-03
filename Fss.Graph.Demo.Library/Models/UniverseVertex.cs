namespace Fss.Graph.Demo.Library.Models
{
    public class UniverseVertex : VertexViewModelBase
    {

        public UniverseVertex() : base() { }

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
            set { Set(ref _isSelected, value); }
        }


        public override string ToString()
        {
            return Text;
        }

        private object _modelTypeString;
        public object ModelTypeString
        {
            get { return _modelTypeString; }
            set { Set(ref _modelTypeString, value); }
        }

        private object _model;
        public object Model
        {
            get { return _model; }
            set
            {
                Set(ref _model, value);
                if (_model != null) ModelTypeString = _model.GetType().ToString();
            }
        }
    }
}
