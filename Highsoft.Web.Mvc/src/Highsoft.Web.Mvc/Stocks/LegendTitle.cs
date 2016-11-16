
// Type: Highsoft.Web.Mvc.Stocks.LegendTitle




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class LegendTitle : BaseObject
  {
    public Hashtable Style { get; set; }

    private Hashtable Style_DefaultValue { get; set; }

    public string Text { get; set; }

    private string Text_DefaultValue { get; set; }

    public LegendTitle()
    {
      Hashtable hashtable1 = new Hashtable();
      hashtable1.Add((object) "fontWeight", (object) "bold");
      Hashtable hashtable2 = hashtable1;
      this.Style_DefaultValue = hashtable1;
      this.Style = hashtable2;
      this.Text = this.Text_DefaultValue = "null";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Style != this.Style_DefaultValue)
        hashtable.Add((object) "style", (object) this.Style);
      if (this.Text != this.Text_DefaultValue)
        hashtable.Add((object) "text", (object) this.Text);
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
