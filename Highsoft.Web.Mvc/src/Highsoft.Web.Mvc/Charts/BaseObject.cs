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

        internal List<List<object>> GetLists(IEnumerable list)
        {
            List<List<object>> objectListList = new List<List<object>>();
            foreach (IObjectList objectList in list)
                objectListList.Add(objectList.ToList());
            return objectListList;
        }
    }
}