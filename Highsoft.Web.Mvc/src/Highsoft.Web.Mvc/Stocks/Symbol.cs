// Type: Highsoft.Web.Mvc.Stocks.Symbol


using System.Collections;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Symbol : BaseObject
    {
        public string Url { get; set; }

        public SymbolEnum SymbolEnum { get; set; }

        public Symbol()
        {
            this.Url = "";
            this.SymbolEnum = SymbolEnum.Null;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Url != null)
                hashtable.Add((object) "symbol", (object) this.Url);
            else if ((uint) this.SymbolEnum > 0U)
                hashtable.Add((object) "symbol", (object) this.SymbolEnum.ToString().ToLower());
            return hashtable;
        }

        internal override string ToJSON()
        {
            if (this.Url != null)
                return this.Url.ToString();
            if ((uint) this.SymbolEnum > 0U)
                return this.SymbolEnum.ToString().ToLower();
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}