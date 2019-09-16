using GalaSoft.MvvmLight;

namespace Fss.Graph.Demo.Library.Models
{
    public class UniverseModel : ObservableObject, IUniverseModel
    {
        public UniverseModel(int id, string author, string name)
        {
            Id = id;
            Author = author;
            Name = name;
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            private set { Set(ref _id, value); }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            private set { Set(ref _author, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            private set { Set(ref _name, value); }
        }
    }
}
