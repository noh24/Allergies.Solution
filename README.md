#### Allergies
Here's something a bit trickier and please only attempt this if you have completed the previous projects and had them checked by an instructor. An allergy score is a single number that tells what someone is allergic to. The scores for each allergen are:

<!-- Store as DICT -->
  DICTIONARY  + <datatype, datatype> + variableName = new (instance of) DICTIONARY + <same datatype, same datatype> + {};
  Retrieve data with → variableName[“key’]

  dictionary <string><int> allergens = new dictionary <string><int> {
    eggs         1
    peanuts      2
    shellfish    4
    strawberries 8
    tomatoes     16
    chocolate    32
    pollen       64
    cats         128
  }

  string allergen = allergens[""]

  <!-- How to retrieve string given value -->

<!-- Store as LISTs -->
class 
  string[] Allergies = {};
  string[] AllergenScores = { 1, 2, 4, 8, 16, 32, 64, 128 }
  int[] Allergens =  {"eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats"}

So if someone is allergic to eggs and strawberries, they get a score of 9.

Build a console app that uses a method that is called on someone's score — i.e. the score is the object, and returns an array listing what they're allergic to. For example, running allergies(3) should print a list of the person's allergies (eggs and peanuts) to the screen.

Input: 9
Output: [eggs, strawberries]

Input: 3
Output: [eggs, peanuts]

<!-- Test Ideas -->

<!-- Return no allergies -->
ListAllergies(input)
Input: 0
Output: []

<!-- Return single allergy -->
ListAllergies(input)
Input: 1
Output: [eggs]

ListAllergies(input)
Input: 2
Output: [peanuts]

ListAllergies(input)
Input: 3
Output: [shellfish]

... for all allergens

<!-- Return multiple allergies -->
if input 18
GetAllergies(), returns string[] 
  find largest allergen score without closest input (if 18, then 16 || if 4, 4)
  // using an array of allergen scores [1, 2, 4, 8, 16, 32, 64, 128]
  // switch (input)
  // case 1
   // break
  // case 2
    //break;
  // case 4
  
  // for (int i=0; i <8; i++)
    // if ((score[i] > input) && (score[i-1] < input)) 
      // Allergen1 = score[i-1] // 16
      // int indexAllergen1 = i - 1
      // ResultArray.Add(allergens.indexAllergen1)
      // input - Allergen1
  
  // 2
  

  working from highest to lowest
  test
  if input - allergenScore == 0, then one allergy 
    else two allergies

19 - 16 == 3 other allergen 2
  working form high to low
  3 - 2 === 1 find other allergen