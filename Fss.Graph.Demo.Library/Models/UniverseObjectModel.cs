using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Graph.Demo.Library.Models
{
    public class UniverseObjectModel : ObservableObject, IUniverseObjectModel
    {
        public UniverseObjectModel(int id, int universeId, string objectName, string objectType)
        {
            Id = id;
            UniverseId = universeId;
            ObjectName = objectName;
            ObjectType = objectType;
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            private set { Set(ref _id, value); }
        }

        private int _universeId;
        public int UniverseId
        {
            get { return _universeId; }
            private set { Set(ref _universeId, value); }
        }

        private string _objectName;
        public string ObjectName
        {
            get { return _objectName; }
            private set { Set(ref _objectName, value); }
        }

        private string _objectType;
        public string ObjectType
        {
            get { return _objectType; }
            private set { Set(ref _objectType, value); }
        }
    }
}
