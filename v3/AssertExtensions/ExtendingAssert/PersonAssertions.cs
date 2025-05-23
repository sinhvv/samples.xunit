namespace Xunit;

// When importing xUnit.net's assertion library as source, the Assert class is partial and you can add
// additional methods directly to Assert.
public partial class Assert
{
    public static void IsBrad(Person person) =>
        Equal("Brad", person.FirstName);
}
