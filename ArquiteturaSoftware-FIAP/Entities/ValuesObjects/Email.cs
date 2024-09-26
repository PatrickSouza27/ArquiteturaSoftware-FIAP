namespace ArquiteturaSoftware_FIAP.Entities.ValuesObjects;

public class Email(string address) : ValueObject
{
    public string Address { get; private set; } = address;
}