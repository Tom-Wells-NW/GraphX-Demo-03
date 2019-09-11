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

        private object _viewModelTypeString;
        public object ViewModelTypeString
        {
            get { return _viewModelTypeString; }
            set { Set(ref _viewModelTypeString, value); }
        }

        private object _viewModel;
        public object ViewModel
        {
            get { return _viewModel; }
            set
            {
                Set(ref _viewModel, value);
                if (_viewModel != null) ViewModelTypeString = _viewModel.GetType().ToString();
            }
        }
    }
}
