
// Type: Highsoft.Web.Mvc.Charts.NoData




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class NoData : BaseObject
  {
    public Hashtable Attr { get; set; }

    private Hashtable Attr_DefaultValue { get; set; }

    public Hashtable Position { get; set; }

    private Hashtable Position_DefaultValue { get; set; }

    public Hashtable Style { get; set; }

    private Hashtable Style_DefaultValue { get; set; }

    public NoData()
    {
      this.Attr = this.Attr_DefaultValue = (Hashtable) null;
      Hashtable hashtable1 = new Hashtable();
      hashtable1.Add((object) "x", (object) "0");
      hashtable1.Add((object) "y", (object) "0");
      hashtable1.Add((object) "align", (object) "center");
      hashtable1.Add((object) "verticalAlign", (object) "middle");
      Hashtable hashtable2 = hashtable1;
      this.Position_DefaultValue = hashtable1;
      this.Position = hashtable2;
      Hashtable hashtable3 = new Hashtable();
      hashtable3.Add((object) "fontSize", (object) "12px");
      hashtable3.Add((object) "fontWeight", (object) "bold");
      hashtable3.Add((object) "color", (object) "#60606a");
      Hashtable hashtable4 = hashtable3;
      this.Style_DefaultValue = hashtable3;
      this.Style = hashtable4;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Attr != this.Attr_DefaultValue)
        hashtable.Add((object) "attr", (object) this.Attr);
      if (this.Position != this.Position_DefaultValue)
        hashtable.Add((object) "position", (object) this.Position);
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
