namespace MadLibs.Models
{
  public class StoryVariable
  {
    private string _noun;
    private string _place;
    private string _adjective;
    private string _noun2;

    public string GetNoun()
    {
      return _noun;
    }

    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }

    public string GetPlace()
    {
      return _place;
    }

    public void SetPlace(string newPlace)
    {
      _place = newPlace;
    }

    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }

    public string GetNoun2()
    {
      return _noun2;
    }

    public void SetNoun2(string newNoun2)
    {
      _noun2 = newNoun2;
    }

  }
}
