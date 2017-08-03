using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class CD
  {
    private string _cdName;
    private string _genre;
    private int _cdId;
    private static List<CD> _cdList = new List<CD> ();

    public CD (string cdName, string genre)
    {
      _cdName = cdName;
      _genre = genre;
      _cdList.Add(this);
      _cdId = _cdList.Count;
    }

    public void SetCdName(string cdName)
    {
      _cdName = cdName;
    }
    public string GetCdName()
    {
      return _cdName;
    }
    public void SetGenre(string genre)
    {
      _genre = genre;
    }
    public string GetGenre()
    {
      return _genre;
    }
    public List<CD> GetAllCds()
    {
      return _cdList;
    }
    public void ClearCdList()
    {
      _cdList.Clear();
    }
    public CD Find(int searchId)
    {
      return _cdList[searchId -1];
    }

  }
  public class Artist
  {
    private string _artistName;
    private int _artistId;
    private List<CD> _cdList;
    private static List<Artist> _artistList = new List<Artist>();

    public Artist(string artistName)
    {
      _artistName = artistName;
      _artistList.Add(this);
      _artistId = _artistList.Count;
      _cdList = new List<CD>();
    }
    public void SetArtistName(string artistName)
    {
      _artistName = artistName;
    }
    public string GetArtistName()
    {
      return _artistName;
    }
    public void SetArtistId(int artistId)
    {
      _artistId = artistId;
    }
    public int GetArtistId()
    {
      return _artistId;
    }
  }
}
