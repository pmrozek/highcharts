
// Type: Highsoft.Web.Mvc.Stocks.ExportingButtons




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class ExportingButtons : BaseObject
  {
    public ExportingButtonsContextButton ContextButton { get; set; }

    private ExportingButtonsContextButton ContextButton_DefaultValue { get; set; }

    public ExportingButtons()
    {
      this.ContextButton = this.ContextButton_DefaultValue = new ExportingButtonsContextButton();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.ContextButton.IsDirty())
        hashtable.Add((object) "contextButton", (object) this.ContextButton.ToHashtable());
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
