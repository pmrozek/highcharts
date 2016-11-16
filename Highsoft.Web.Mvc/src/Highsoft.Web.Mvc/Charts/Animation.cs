
// Type: Highsoft.Web.Mvc.Charts.Animation




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class Animation : BaseObject
  {
    public bool Enabled { get; set; }

    public int Duration { get; set; }

    public string Easing { get; set; }

    public Animation()
    {
      this.Enabled = true;
      this.Duration = 0;
      this.Easing = "";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (!string.IsNullOrEmpty(this.Easing))
        hashtable.Add((object) "easing", (object) this.Easing);
      if (this.Duration > 0)
        hashtable.Add((object) "duration", (object) this.Duration);
      return hashtable;
    }

    internal override string ToJSON()
    {
      if (this.ToHashtable().Count > 0)
        return JsonConvert.SerializeObject((object) this.ToHashtable());
      return this.Enabled.ToString().ToLower();
    }

    internal override bool IsDirty()
    {
      if (this.Enabled)
        return this.ToHashtable().Count > 0;
      return true;
    }
  }
}
