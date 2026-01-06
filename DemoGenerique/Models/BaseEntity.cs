using DemoGenerique.Interfaces;

namespace DemoGenerique.Models;

public class BaseEntity : IBaseEntity
{
    public int Id { get; set; }
}
