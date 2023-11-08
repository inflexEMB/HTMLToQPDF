﻿using HtmlAgilityPack;
using HTMLToQPDFstandard.Components;
using HTMLToQPDFstandard.Components.Tags;
using QuestPDF.Infrastructure;
using System.Collections.Generic;

namespace HTMLToQPDFstandard
{
    internal static class HTMLMapSettings
    {
        public static readonly string[] LineElements = new string[] {
            "a",
            "b",
            "strong",
            "br",
            "i",
            "em",
            "s",
            "small",
            "space",
            "strike",
            "tbody",
            "td",
            "th",
            "thead",
            "tr",
            "u",
            "img",
            "text"
        };

        public static readonly string[] BlockElements = new string[] {
            "#document",
            "div",
            "h1",
            "h2",
            "h3",
            "h4",
            "h5",
            "h6",
            "li",
            "ol",
            "p",
            "table",
            "ul",
            "section",
            "header",
            "footer",
            "head",
            "html"
        };

        public static IComponent GetComponent(this HtmlNode node, HTMLComponentsArgs args)
        {
            switch (node.Name.ToLower())
            {
                case "#text":
                case "h1":
                case "h2":
                case "h3":
                case "h4":
                case "h5":
                case "h6":
                case "b":
                case "strong":
                case "s":
                case "strike":
                case "i":
                case "em":
                case "small":
                case "u":
                    return new ParagraphComponent(new List<HtmlNode>() { node }, args);

                case "br": return new BrComponent(node, args);
                case "a": return new AComponent(node, args);
                case "div": return new BaseHTMLComponent(node, args);
                case "table": return new TableComponent(node, args);

                case "ul":
                case "ol":
                    return new ListComponent(node, args);

                case "img": return new ImgComponent(node, args);

                default: return new BaseHTMLComponent(node, args);
            }
        }
    }
}
