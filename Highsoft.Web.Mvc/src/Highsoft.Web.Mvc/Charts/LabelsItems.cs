
// Type: Highsoft.Web.Mvc.Charts.LabelsItems




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class LabelsItems : BaseObject
  {
    public string Html { get; set; }

    private string Html_DefaultValue { get; set; }

    public Hashtable Style { get; set; }

    private Hashtable Style_DefaultValue { get; set; }

    public LabelsItems()
    {
      this.Html = this.Html_DefaultValue = (string) null;
      this.Style = this.Style_DefaultValue = new Hashtable();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Html != this.Html_DefaultValue)
        hashtable.Add((object) "html", (object) this.Html);
      if (this.Style != this.Style_DefaultValue)
        hashtable.Add((object) "style", (object) this.Style);
      return hashtable;
    }

    internal override string ToJSON()
    {
      if (this.ToHashtable().Count > 0)
        return JsonConvert.SerializeObject((object) this.ToHashtable());
      return "";
    }

    internal override bool IsDirty()
    {
      return this.ToHashtable().Count > 0;
    }
  }
}
