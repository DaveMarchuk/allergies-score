using System;

namespace Allergies
{
  public class AllergyScore
  {
    public string AllergyCheck(int code)
    {
      string things = "";
      string[] allergies = {"Cats, ", "Pollen, ", "Chocolate, ", "Tomatoes, ", "Strawberies, ",  "Shellfish, ", "Peanuts, ", "Eggs, "};
      int[] scores = {128, 64, 32, 16, 8, 4, 2, 1};
      
      for(int i = 0; i < 8; i++)
      {
        if(code >= scores[i])
        {
          things += allergies[i];
          code -= scores[i];
        }
      }
    /*{  
       
      }
      if(code >= 128)
      {  
        things += "Cats, ";
        code -= 128;
      }
      if(code >= 64)
      {
        things += "Pollen, ";
        code -= 64;
      }
      if(code >= 32)
      {
        things += "Chocolate, ";
        code -= 32;
      }
      if(code >= 16)
      {
        things += "Tomatoes, ";
        code -= 16;
      }
      if (code >= 8)
      {
        things += "Strawberies, ";
        code -= 8;
      }
      if (code >= 4)
      {
        things += "Shellfish, ";
        code -= 4;
      }
      if (code >= 2)
      {
        things += "Peanuts, ";
        code -= 2;
      }
      if  (code >= 1)
      {
          things += "Eggs, ";
          code -= 1;
      }*/
      things = things.Remove(things.Length - 2, 2);  
      return things;
    }
  }
}