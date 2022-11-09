using System;

namespace Allergies
{
  public class AllergyScore
  {
    public string AllergyCheck(int code)
    {
        string things = "";
        if(code == 0)
        {
             things += "Peanuts";
        }
        

        return things;
    }
  }
}