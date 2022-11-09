using System;
using System.Collections.Generic;
using Allergies;

namespace Allergies {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter in your Allergy score: ");
      string UserNumber = Console.ReadLine();
      int convertToInt = Int32.Parse(UserNumber);
      AllergyScore checker = new AllergyScore();
      Console.WriteLine("Based on your Allergy you score you are allergic to the following: ");
      Console.WriteLine(checker.AllergyCheck(convertToInt));
    }
  }
}
