using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;

namespace Allergies.Test
{
  [TestClass]
  public class AllergyScoreTests
  {
    [TestMethod]
    public void DoesAllergyScoreReturnValue_True()
    {
      AllergyScore returnValue = new AllergyScore();
      Assert.AreEqual("Peanuts, ", returnValue.AllergyCheck(2));
    }
    
    [TestMethod]
    public void DoesAllergyScoreReturnAllergies_True()
    {
      AllergyScore returnValue = new AllergyScore();
      Assert.AreEqual("Peanuts, Eggs, ", returnValue.AllergyCheck(3));
    }
  }
}