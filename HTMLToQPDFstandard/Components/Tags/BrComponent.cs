using HtmlAgilityPack;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace HTMLToQPDFstandard.Components.Tags
{
    internal class BrComponent : BaseHTMLComponent
    {
        public BrComponent(HtmlNode node, HTMLComponentsArgs args) : base(node, args)
        {
        }

        protected override void ComposeSingle(IContainer container)
        {
            container.Text("");
        }
    }
}
