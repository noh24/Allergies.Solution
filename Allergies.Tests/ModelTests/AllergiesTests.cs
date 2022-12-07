using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergenScore;

namespace AllergenScore.Tests
{
  [TestClass]
  public class AllergiesTests
  {
    [TestMethod]
    public void AllergiesConstructor_CreateInstancesOfAllergies_Allergies()
    {
      Allergies allergies = new Allergies();
      Assert.AreEqual(typeof(Allergies), allergies.GetType());
    }
    [TestMethod]
    public void AllergiesConstructor_AddProperties_Collections()
    {
      Allergies allergies = new Allergies();
      Assert.AreEqual(typeof(Allergies.Allergens), allergies.Allergens.GetType());
      Assert.AreEqual(typeof(Allergies.Scores), allergies.Scores.GetType());
      Assert.AreEqual(typeof(Allergies.UserAllergies), allergies.UserAllergies.GetType());
    }

        // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //   string result = newItem.Description;
    //   Assert.AreEqual(description, result);
    // }
  }
}