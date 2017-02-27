// Type: Highsoft.Web.Mvc.Stocks.Navigation


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Navigation : BaseObject
    {
        public NavigationButtonOptions ButtonOptions { get; set; }

        private NavigationButtonOptions ButtonOptions_DefaultValue { get; set; }

        public Hashtable MenuItemHoverStyle { get; set; }

        private Hashtable MenuItemHoverStyle_DefaultValue { get; set; }

        public Hashtable MenuItemStyle { get; set; }

        private Hashtable MenuItemStyle_DefaultValue { get; set; }

        public Hashtable MenuStyle { get; set; }

        private Hashtable MenuStyle_DefaultValue { get; set; }

        public Navigation()
        {
            this.ButtonOptions = this.ButtonOptions_DefaultValue = new NavigationButtonOptions();
            this.MenuItemHoverStyle = this.MenuItemHoverStyle_DefaultValue = new Hashtable()
            {
                {
                    (object) "background",
                    (object) "#335cad"
                },
                {
                    (object) "color",
                    (object) "#ffffff"
                }
            };
            this.MenuItemStyle = this.MenuItemStyle_DefaultValue = new Hashtable()
            {
                {
                    (object) "padding",
                    (object) "0.5em 1em"
                },
                {
                    (object) "color",
                    (object) "#333333"
                },
                {
                    (object) "background",
                    (object) "none"
                }
            };
            this.MenuStyle = this.MenuStyle_DefaultValue = new Hashtable()
            {
                {
                    (object) "border",
                    (object) "1px solid #999999"
                },
                {
                    (object) "background",
                    (object) "#ffffff"
                },
                {
                    (object) "padding",
                    (object) "5px 0"
                }
            };
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ButtonOptions.IsDirty())
                hashtable.Add((object) "buttonOptions", (object) this.ButtonOptions.ToHashtable());
            if (this.MenuItemHoverStyle != this.MenuItemHoverStyle_DefaultValue)
                hashtable.Add((object) "menuItemHoverStyle", (object) this.MenuItemHoverStyle);
            if (this.MenuItemStyle != this.MenuItemStyle_DefaultValue)
                hashtable.Add((object) "menuItemStyle", (object) this.MenuItemStyle);
            if (this.MenuStyle != this.MenuStyle_DefaultValue)
                hashtable.Add((object) "menuStyle", (object) this.MenuStyle);
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