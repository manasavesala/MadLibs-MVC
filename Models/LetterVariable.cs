namespace MadLibs.Models
{
  public class LetterVariable
  {
    private string _name;
    private string _place;
    private string _adjective1;

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPlace()
    {
      return _place;
    }

    public void SetPlace(string newPlace)
    {
      _place = newPlace;
    }

    public string GetAdjective1()
    {
      return _adjective1;
    }

    public void SetAdjective1(string newAdjective1)
    {
      _adjective1 = newAdjective1;
    }

  }
}
