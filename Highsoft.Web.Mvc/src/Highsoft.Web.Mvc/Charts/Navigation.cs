// Type: Highsoft.Web.Mvc.Charts.Navigation


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
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
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "background", (object) "#335cad");
            hashtable1.Add((object) "color", (object) "#ffffff");
            Hashtable hashtable2 = hashtable1;
            this.MenuItemHoverStyle_DefaultValue = hashtable1;
            this.MenuItemHoverStyle = hashtable2;
            Hashtable hashtable3 = new Hashtable();
            hashtable3.Add((object) "padding", (object) "0.5em 1em");
            hashtable3.Add((object) "color", (object) "#333333");
            hashtable3.Add((object) "background", (object) "none");
            Hashtable hashtable4 = hashtable3;
            this.MenuItemStyle_DefaultValue = hashtable3;
            this.MenuItemStyle = hashtable4;
            Hashtable hashtable5 = new Hashtable();
            hashtable5.Add((object) "border", (object) "1px solid #999999");
            hashtable5.Add((object) "background", (object) "#ffffff");
            hashtable5.Add((object) "padding", (object) "5px 0");
            Hashtable hashtable6 = hashtable5;
            this.MenuStyle_DefaultValue = hashtable5;
            this.MenuStyle = hashtable6;
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