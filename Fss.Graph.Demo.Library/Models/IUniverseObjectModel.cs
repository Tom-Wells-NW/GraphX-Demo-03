namespace Fss.Graph.Demo.Library.Models
{
    public interface IUniverseObjectModel
    {
        int Id { get; }
        int UniverseId { get; }
        string ObjectName { get; }
        string ObjectType { get; }
    }
}