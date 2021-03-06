﻿using System;

namespace HtmlTags.Extended
{
    namespace TagBuilders
    {
        public static class TagBuilderExtensions
        {
            public static HtmlTag Span(this HtmlTag tag, Action<HtmlTag> configure)
            {
                var span = new HtmlTag("span");
                configure(span);
                return HtmlTagExtensions.Append(tag, span);
            }

            public static HtmlTag Div(this HtmlTag tag, Action<HtmlTag> configure)
            {
                var div = new HtmlTag("div");
                configure(div);

                return HtmlTagExtensions.Append(tag, div);
            }

            public static LinkTag ActionLink(this HtmlTag tag, string text, params string[] classes)
            {
                var child = new LinkTag(text, "#", classes);
                tag.Append(child);

                return child;
            }
        }
    }
}