using Xunit;

namespace ResourcesTest.Tests
{
  public class UnitTestPerson
  {
    [Fact]
    public void FullNameTest()
    {
      Person person = new Person { FirstName = "John", LastName = "Wick" };

      Assert.Equal(person.FirstName + " " + person.LastName, person.FullName);
    }
  }
}
