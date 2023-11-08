﻿using HtmlAgilityPack;
using HTMLToQPDFstandard.Extensions;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace HTMLToQPDFstandard.Components.Tags
{
    internal class AComponent : BaseHTMLComponent
    {
        public AComponent(HtmlNode node, HTMLComponentsArgs args) : base(node, args)
        {
        }

        protected override IContainer ApplyStyles(IContainer container)
        {
            container = base.ApplyStyles(container);
            return node.TryGetLink(out string link) ? container.Hyperlink(link) : container;
        }
    }
}
