
// Type: Highsoft.Web.Mvc.Charts.BaseObject




using System.Collections;
using System.Collections.Generic;

namespace Highsoft.Web.Mvc.Charts
{
  public abstract class BaseObject
  {
    internal abstract Hashtable ToHashtable();

    internal abstract string ToJSON();

    internal abstract bool IsDirty();

    internal List<Hashtable> HashifyList(IEnumerable list)
    {
      List<Hashtable> hashtableList = new List<Hashtable>();
      foreach (BaseObject baseObject in list)
        hashtableList.Add(baseObject.ToHashtable());
      return hashtableList;
    }
  }
}
