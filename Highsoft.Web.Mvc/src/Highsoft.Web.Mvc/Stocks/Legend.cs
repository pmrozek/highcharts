// Type: Highsoft.Web.Mvc.Stocks.Legend


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Legend : BaseObject
    {
        public Legend()
        {
            this.Align = this.Align_DefaultValue = LegendAlign.Center;
            this.BackgroundColor = this.BackgroundColor_DefaultValue = (string) null;
            this.BorderColor = this.BorderColor_DefaultValue = "#999999";
            double? nullable1 = new double?(0.0);
            this.BorderRadius_DefaultValue = nullable1;
            this.BorderRadius = nullable1;
            nullable1 = new double?(0.0);
            this.BorderWidth_DefaultValue = nullable1;
            this.BorderWidth = nullable1;
            bool? nullable2 = new bool?(false);
            this.Enabled_DefaultValue = nullable2;
            this.Enabled = nullable2;
            nullable2 = new bool?(false);
            this.Floating_DefaultValue = nullable2;
            this.Floating = nullable2;
            nullable1 = new double?(20.0);
            this.ItemDistance_DefaultValue = nullable1;
            this.ItemDistance = nullable1;
            this.ItemHiddenStyle = this.ItemHiddenStyle_DefaultValue = new Hashtable()
            {
                {
                    (object) "color",
                    (object) "#cccccc"
                }
            };
            this.ItemHoverStyle = this.ItemHoverStyle_DefaultValue = new Hashtable()
            {
                {
                    (object) "color",
                    (object) "#000000"
                }
            };
            nullable1 = new double?(0.0);
            this.ItemMarginBottom_DefaultValue = nullable1;
            this.ItemMarginBottom = nullable1;
            nullable1 = new double?(0.0);
            this.ItemMarginTop_DefaultValue = nullable1;
            this.ItemMarginTop = nullable1;
            this.ItemStyle = this.ItemStyle_DefaultValue = new Hashtable()
            {
                {
                    (object) "color",
                    (object) "#333333"
                },
                {
                    (object) "cursor",
                    (object) "pointer"
                },
                {
                    (object) "fontSize",
                    (object) "12px"
                },
                {
                    (object) "fontWeight",
                    (object) "bold"
                }
            };
            double? nullable3 = new double?();
            this.ItemWidth_DefaultValue = nullable3;
            this.ItemWidth = nullable3;
            this.LabelFormat = this.LabelFormat_DefaultValue = "{name}";
            this.LabelFormatter = this.LabelFormatter_DefaultValue = "";
            this.Layout = this.Layout_DefaultValue = LegendLayout.Horizontal;
            double? nullable4 = new double?();
            this.Margin_DefaultValue = nullable4;
            this.Margin = nullable4;
            double? nullable5 = new double?();
            this.MaxHeight_DefaultValue = nullable5;
            this.MaxHeight = nullable5;
            this.Navigation = this.Navigation_DefaultValue = new LegendNavigation();
            nullable5 = new double?(8.0);
            this.Padding_DefaultValue = nullable5;
            this.Padding = nullable5;
            nullable2 = new bool?(false);
            this.Reversed_DefaultValue = nullable2;
            this.Reversed = nullable2;
            this.Shadow = this.Shadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            nullable2 = new bool?(true);
            this.SquareSymbol_DefaultValue = nullable2;
            this.SquareSymbol = nullable2;
            double? nullable6 = new double?();
            this.SymbolHeight_DefaultValue = nullable6;
            this.SymbolHeight = nullable6;
            nullable6 = new double?(5.0);
            this.SymbolPadding_DefaultValue = nullable6;
            this.SymbolPadding = nullable6;
            double? nullable7 = new double?();
            this.SymbolRadius_DefaultValue = nullable7;
            this.SymbolRadius = nullable7;
            double? nullable8 = new double?();
            this.SymbolWidth_DefaultValue = nullable8;
            this.SymbolWidth = nullable8;
            this.Title = this.Title_DefaultValue = new LegendTitle();
            nullable2 = new bool?(false);
            this.UseHTML_DefaultValue = nullable2;
            this.UseHTML = nullable2;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = LegendVerticalAlign.Bottom;
            double? nullable9 = new double?();
            this.Width_DefaultValue = nullable9;
            this.Width = nullable9;
            nullable9 = new double?(0.0);
            this.X_DefaultValue = nullable9;
            this.X = nullable9;
            nullable9 = new double?(0.0);
            this.Y_DefaultValue = nullable9;
            this.Y = nullable9;
        }

        public LegendAlign Align { get; set; }

        private LegendAlign Align_DefaultValue { get; set; }

        public string BackgroundColor { get; set; }

        private string BackgroundColor_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderRadius { get; set; }

        private double? BorderRadius_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public bool? Floating { get; set; }

        private bool? Floating_DefaultValue { get; set; }

        public double? ItemDistance { get; set; }

        private double? ItemDistance_DefaultValue { get; set; }

        public Hashtable ItemHiddenStyle { get; set; }

        private Hashtable ItemHiddenStyle_DefaultValue { get; set; }

        public Hashtable ItemHoverStyle { get; set; }

        private Hashtable ItemHoverStyle_DefaultValue { get; set; }

        public double? ItemMarginBottom { get; set; }

        private double? ItemMarginBottom_DefaultValue { get; set; }

        public double? ItemMarginTop { get; set; }

        private double? ItemMarginTop_DefaultValue { get; set; }

        public Hashtable ItemStyle { get; set; }

        private Hashtable ItemStyle_DefaultValue { get; set; }

        public double? ItemWidth { get; set; }

        private double? ItemWidth_DefaultValue { get; set; }

        public string LabelFormat { get; set; }

        private string LabelFormat_DefaultValue { get; set; }

        public string LabelFormatter { get; set; }

        private string LabelFormatter_DefaultValue { get; set; }

        public LegendLayout Layout { get; set; }

        private LegendLayout Layout_DefaultValue { get; set; }

        public double? Margin { get; set; }

        private double? Margin_DefaultValue { get; set; }

        public double? MaxHeight { get; set; }

        private double? MaxHeight_DefaultValue { get; set; }

        public LegendNavigation Navigation { get; set; }

        private LegendNavigation Navigation_DefaultValue { get; set; }

        public double? Padding { get; set; }

        private double? Padding_DefaultValue { get; set; }

        public bool? Reversed { get; set; }

        private bool? Reversed_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public bool? SquareSymbol { get; set; }

        private bool? SquareSymbol_DefaultValue { get; set; }

        public double? SymbolHeight { get; set; }

        private double? SymbolHeight_DefaultValue { get; set; }

        public double? SymbolPadding { get; set; }

        private double? SymbolPadding_DefaultValue { get; set; }

        public double? SymbolRadius { get; set; }

        private double? SymbolRadius_DefaultValue { get; set; }

        public double? SymbolWidth { get; set; }

        private double? SymbolWidth_DefaultValue { get; set; }

        public LegendTitle Title { get; set; }

        private LegendTitle Title_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public LegendVerticalAlign VerticalAlign { get; set; }

        private LegendVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? Width { get; set; }

        private double? Width_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highstock.FirstCharacterToLower(this.Align.ToString()));
            if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
                hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            double? nullable1 = this.BorderRadius;
            double? nullable2 = this.BorderRadius_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
            nullable2 = this.BorderWidth;
            nullable1 = this.BorderWidth_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            bool? nullable3 = this.Enabled;
            bool? nullable4 = this.Enabled_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            nullable4 = this.Floating;
            nullable3 = this.Floating_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "floating", (object) this.Floating);
            nullable1 = this.ItemDistance;
            nullable2 = this.ItemDistance_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "itemDistance", (object) this.ItemDistance);
            if (this.ItemHiddenStyle != this.ItemHiddenStyle_DefaultValue)
                hashtable.Add((object) "itemHiddenStyle", (object) this.ItemHiddenStyle);
            if (this.ItemHoverStyle != this.ItemHoverStyle_DefaultValue)
                hashtable.Add((object) "itemHoverStyle", (object) this.ItemHoverStyle);
            nullable2 = this.ItemMarginBottom;
            nullable1 = this.ItemMarginBottom_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "itemMarginBottom", (object) this.ItemMarginBottom);
            nullable1 = this.ItemMarginTop;
            nullable2 = this.ItemMarginTop_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "itemMarginTop", (object) this.ItemMarginTop);
            if (this.ItemStyle != this.ItemStyle_DefaultValue)
                hashtable.Add((object) "itemStyle", (object) this.ItemStyle);
            nullable2 = this.ItemWidth;
            nullable1 = this.ItemWidth_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "itemWidth", (object) this.ItemWidth);
            if (this.LabelFormat != this.LabelFormat_DefaultValue)
                hashtable.Add((object) "labelFormat", (object) this.LabelFormat);
            if (this.LabelFormatter != this.LabelFormatter_DefaultValue)
            {
                hashtable.Add((object) "labelFormatter", (object) this.LabelFormatter);
                Highstock.AddFunction("LegendLabelFormatter.labelFormatter", this.LabelFormatter);
            }
            if (this.Layout != this.Layout_DefaultValue)
                hashtable.Add((object) "layout", (object) Highstock.FirstCharacterToLower(this.Layout.ToString()));
            nullable1 = this.Margin;
            nullable2 = this.Margin_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "margin", (object) this.Margin);
            nullable2 = this.MaxHeight;
            nullable1 = this.MaxHeight_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "maxHeight", (object) this.MaxHeight);
            if (this.Navigation.IsDirty())
                hashtable.Add((object) "navigation", (object) this.Navigation.ToHashtable());
            nullable1 = this.Padding;
            nullable2 = this.Padding_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "padding", (object) this.Padding);
            nullable3 = this.Reversed;
            nullable4 = this.Reversed_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "reversed", (object) this.Reversed);
            if (this.Shadow.IsDirty())
                hashtable.Add((object) "shadow", (object) this.Shadow.ToHashtable());
            nullable4 = this.SquareSymbol;
            nullable3 = this.SquareSymbol_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "squareSymbol", (object) this.SquareSymbol);
            nullable2 = this.SymbolHeight;
            nullable1 = this.SymbolHeight_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "symbolHeight", (object) this.SymbolHeight);
            nullable1 = this.SymbolPadding;
            nullable2 = this.SymbolPadding_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "symbolPadding", (object) this.SymbolPadding);
            nullable2 = this.SymbolRadius;
            nullable1 = this.SymbolRadius_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "symbolRadius", (object) this.SymbolRadius);
            nullable1 = this.SymbolWidth;
            nullable2 = this.SymbolWidth_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "symbolWidth", (object) this.SymbolWidth);
            if (this.Title.IsDirty())
                hashtable.Add((object) "title", (object) this.Title.ToHashtable());
            nullable3 = this.UseHTML;
            nullable4 = this.UseHTML_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highstock.FirstCharacterToLower(this.VerticalAlign.ToString()));
            nullable2 = this.Width;
            nullable1 = this.Width_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "width", (object) this.Width);
            nullable1 = this.X;
            nullable2 = this.X_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable2 = this.Y;
            nullable1 = this.Y_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "y", (object) this.Y);
            return hashtable;
        }

        internal override string ToJSON()
        {
            Hashtable hashtable = this.ToHashtable();


            if (hashtable.Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}