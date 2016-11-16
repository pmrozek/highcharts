
// Type: Highsoft.Web.Mvc.Stocks.Stop




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class Stop : BaseObject
  {
    public double Position { get; set; }

    public string Color { get; set; }

    public Stop()
    {
      this.Position = 0.0;
      this.Color = "";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (!string.IsNullOrEmpty(this.Color))
        hashtable.Add((object) "color", (object) this.Color);
      if (this.Position != 0.0)
        hashtable.Add((object) "position", (object) this.Position);
      return hashtable;
    }

    internal override string ToJSON()
    {
      return JsonConvert.SerializeObject((object) this.ToHashtable());
    }

    internal override bool IsDirty()
    {
      return this.ToHashtable().Count > 0;
    }
  }
}
