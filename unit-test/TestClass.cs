using Xunit;
public class TestClass {

   // Theories are tests which are only true for a perticular set of data
   [Theory]
   [InlineData (3)]
   [InlineData (5)]
   [InlineData (9)]

   public void MyFirstTheory (int myNumber) {
      Assert.True (Program.IsOdd (myNumber));
   }

   // Fact is use to True
   [Fact]
   public void PassingAddTest () {
      Assert.Equal (4, Program.Add (2, 2));
   }

   [Fact]
   public void FailingAddTest () {
      Assert.NotEqual (5, Program.Add (2, 2));
   }
}