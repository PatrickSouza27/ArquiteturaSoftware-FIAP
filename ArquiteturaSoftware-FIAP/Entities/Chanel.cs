namespace ArquiteturaSoftware_FIAP.Entities;

public class Chanel
{
    private readonly IList<User> _members;
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private  set; }
    public bool Privates { get; private set; }
    
    public IReadOnlyCollection<User> Members => _members.ToList();
    
    public Chanel(string name, string description, bool privates, IList<User> members)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Privates = privates;
        _members = members;
        _members = new List<User>();
    }
    
    public void AddMember(User user)
        => _members.Add(user);
    
    public void RemoveMember(User user)
        => _members.Remove(user);
}