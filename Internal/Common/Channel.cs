using BonfireServer.Database;

namespace BonfireServer.Internal.Common;

public class Channel(LiteFlakeId? id) : ICachableType
{
    public LiteFlakeId Id { get; } =  id ?? new LiteFlakeId();

    public string Name { get; set; }

    public Server? Server { get; set; } = null;
    public List<Message?> Messages { get; set; } = [];
}