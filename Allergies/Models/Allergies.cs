using System.Collections.Generic;

namespace AllergenScore
{
  public class Allergies
  {
    public string[] Allergens {get; set;}
    public int[] Scores {get; set;}
    public List<string> UserAllergies {get; set;}

    public Allergies()
    {
      Allergens = new string[] { "eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats"};
      Scores = { 1, 2, 4, 8, 16, 32, 64, 128 };
      UserAllergies = {};
    }
  }
}