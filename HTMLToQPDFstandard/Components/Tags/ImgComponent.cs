using HtmlAgilityPack;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace HTMLToQPDFstandard.Components.Tags
{
    internal class ImgComponent : BaseHTMLComponent
    {
        private readonly GetImgBySrc getImgBySrc;

        public ImgComponent(HtmlNode node, HTMLComponentsArgs args) : base(node, args)
        {
            this.getImgBySrc = args.GetImgBySrc;
        }

        protected override void ComposeSingle(IContainer container)
        {
            var src = node.GetAttributeValue("src", "");
            var img = getImgBySrc(src) ?? Placeholders.Image(200, 100);
            container.Image(img, ImageScaling.FitArea);
        }
    }
}
